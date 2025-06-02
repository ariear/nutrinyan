using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
using NutriNyan.Models.Enums;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

public class ChatController
{
    public static readonly IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
    public static string GoogleAIApiKey => configuration["GoogleAIStudio:ApiKey"];
    public static string GoogleAIEndpoint => configuration["GoogleAIStudio:Endpoint"];
    private readonly HttpClient _httpClient;

    public ChatController()
    {
        _httpClient = new HttpClient();
    }

    public static List<Chat> GetChatHistory(int userId)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                return dbContext.Chats
                    .Where(c => c.UserId == userId)
                    .OrderBy(c => c.CreatedAt)
                    .ToList();
            }
        }
        catch
        {
            return new List<Chat>();
        }
    }

    public static bool SaveChatMessage(int userId, SenderType sender, string message)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                dbContext.Chats.Add(new Chat
                {
                    UserId = userId,
                    Sender = sender,
                    Message = message,
                    CreatedAt = DateTime.UtcNow
                });
                dbContext.SaveChanges();
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static bool DeleteChatByUserId(int userId)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                var entries = dbContext.Chats.Where(c => c.UserId == userId).ToList();
                if (entries.Any())
                {
                    dbContext.Chats.RemoveRange(entries);
                    dbContext.SaveChanges();
                    return true;
                }
            }
        }
        catch
        {
            return false;
        }

        return false;
    }

    public async Task<string> GetAIResponseAsync(string userMessage)
    {
        string systemInstruction = "Kamu adalah NyanBot, seorang asisten virtual ahli di bidang gizi dan kesehatan. Tugasmu adalah memberikan saran dan konsultasi seputar gizi, berdasarkan data yang diberikan pengguna.\r\n\r\nPengguna akan memberikan informasi berikut:\r\n- Jenis kelamin \r\n- Usia (dalam tahun)\r\n- Tinggi badan (dalam cm)\r\n- Berat badan (dalam kg)\r\n- Tingkat aktivitas fisik (rendah / sedang / tinggi)\r\n- Tujuan (diet / bulking / hidup sehat)\r\n\r\nCatatan penting:\r\n- Hanya jawab pertanyaan yang berkaitan dengan gizi dan kesehatan.\r\n- Jangan menjawab pertanyaan yang tidak relevan atau di luar topik (misalnya tentang teknologi, politik, hiburan, dan sebagainya).\r\n- Sampaikan jawaban dengan nada ramah, jelas, dan mudah dipahami oleh orang awam.\r\n- Jangan memberi diagnosis medis. Jika ada gejala atau kondisi serius, arahkan pengguna untuk berkonsultasi dengan tenaga kesehatan profesional.";
        
        try
        {
            var requestUrl = $"{GoogleAIEndpoint}{GoogleAIApiKey}";
            
            var requestBody = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[]
                        {
                            new { text = systemInstruction },
                            new { text = userMessage }
                        }
                    }
                }
            };

            var json = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(requestUrl, content);
            response.EnsureSuccessStatusCode();

            var responseJson = await response.Content.ReadAsStringAsync();
            var responseObject = JsonSerializer.Deserialize<JsonElement>(responseJson);

            return responseObject.GetProperty("candidates")[0]
                .GetProperty("content")
                .GetProperty("parts")[0]
                .GetProperty("text")
                .GetString();
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }
}