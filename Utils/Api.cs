public static class Api
{
    public static string fatsecretLinkFormat = "https://www.fatsecret.co.id/kalori-gizi/umum/";
    /// <summary>
    /// Get nutrition information of a food from the fatsecret web. Null if there is error such as no internet connection
    /// <para>
    /// Keys: ["Lemak", "Protein", "Karbohidrat", "Serat", "Gula", "1 porsi"]
    /// </para>
    /// </summary>
    /// <param name="http_string"></param>
    /// <returns></returns>
    public static async Task<Dictionary<string, float>?> GetReq(string http_string)
    {
        Dictionary<string, float> my_dict = new Dictionary<string, float>();
        try
        {

            // create HttpClient
            using (var req_client = new HttpClient())
            {
                // create http reuqest message
                using (var request = new HttpRequestMessage(
                    HttpMethod.Get,
                    http_string))
                {
                    // Adding header to the http request message
                    request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
                    request.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");

                    var response = await req_client.SendAsync(request); // Send the https request

                    // Is the request succes and page is found
                    if (response.IsSuccessStatusCode && response.RequestMessage.RequestUri.ToString() != "https://www.fatsecret.co.id/Default.aspx")
                    {
                        string html = await response.Content.ReadAsStringAsync(); // Serialize the html from the web and treat it to a string
                        string html2 = html.Substring(10050, 24000).Replace("\t", "");//.Split("<div class=\"nutrition_facts international\">")[1]; // .Split("<div class=\"nutrition_facts international\">");
                        string UkuranPorsi = html2.Split("Ukuran Porsi")[1].Split("<div class=\"serving_size black serving_size_value\">")[1].Split("<")[0];
                        if (UkuranPorsi != "100 gram (g)")
                        {
                            my_dict = await GetReq(http_string: "https://www.fatsecret.co.id" + html2.Split("\">100 gram")[0].Split("<a href=\"").Last());
                        }
                        else
                        {
                            // Adding nutrition value of search the item
                            bool isComma = false;
                            if (Single.Parse("1,001") < Single.Parse("1.001"))
                            {
                                isComma = true;
                            }
                            List<string> listGet = ["Lemak", "Protein", "Karbohidrat", "Serat", "Gula"];
                            foreach (string item in listGet)
                            {
                                string replace_html2 = html2;
                                string value = replace_html2.Split($"{item}</div>")[1].Split("</div>")[0].Split(">")[1];
                                if (isComma)
                                {
                                    my_dict.Add(item, float.Parse(value.Substring(0, value.Length - 1)));
                                }
                                else
                                {
                                    my_dict.Add(item, float.Parse(value.Substring(0, value.Length - 1).Replace(",",".")));
                                }
                            }
                            // Adding a portion weight of the item if "1 porsi" exist in the html
                            if (html2.Contains("1 porsi"))
                            {
                                if (isComma)
                                {
                                    my_dict.Add("1 Porsi", float.Parse(html2.Split("1 porsi</a> <span class=\"smallText greyText\">(")[1].Split(" ")[0]));
                                }
                                else
                                {
                                    my_dict.Add("1 Porsi", float.Parse(html2.Split("1 porsi</a> <span class=\"smallText greyText\">(")[1].Split(" ")[0].Replace(",", ".")));
                                }
                            }
                                else
                                {
                                    my_dict.Add("1 Porsi", 0F);
                                }
                        }
                        return my_dict;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        catch //(Exception e)
        {
            return null;
        }
    }
    /// <summary>
    /// Get recomendation food. Don't forget to format the foodName first using GetFoodName. Return format [[foodName, nutritionFact], ...]. Return null if error
    /// </summary>
    /// <param name="http_string"></param>
    /// <returns></returns>
    public static async Task<List<List<string>>?> GetRecomendation(string foodName)
    {
        try
        {
            string http_string = "https://www.fatsecret.co.id/kalori-gizi/search?q=" + foodName;
            using (var req_client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(
                    HttpMethod.Get,
                    http_string))
                {
                    request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
                    request.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");

                    var response = await req_client.SendAsync(request);

                    string html = await response.Content.ReadAsStringAsync();
                    if (html.Contains("Tidak ada hasil pencarian"))
                    {
                        return null;
                    }
                    html = html.Split("class=\"searchResultSummary\"")[1].Split("class=\"searchResultsPaging\"")[0].Replace("\n", "");
                    List<string> my_list = html.Split("<a class=\"prominent\" href=\"/kalori-gizi/umum/").ToList();
                    my_list = my_list.Slice(1, my_list.Count - 1);
                    List<List<string>> store = [];
                    for (int i = 0; i < 4 && i < my_list.Count; i++)
                    {
                        string diss = my_list[i].Split("<br />Ukuran Lainnya:")[0].Split(", <i>lagi")[0];
                        store.Add([(diss.Split("\"")[0]), (diss.Replace("\t", "").Split("<div class=\"smallText greyText greyLink\">")[1].Substring(5))]);
                    }
                    return store;
                }
            }
        }
        catch
        {
            return null;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="task"></param>
    /// <returns></returns>
    public static async Task WaitingWindow(Task task)
    {
        var loadWindow = new NutriNyan.Views.Loading.LoadingWindow();
        loadWindow.StartPosition = FormStartPosition.CenterScreen;
        loadWindow.Show();
        string initText = loadWindow.Controls[0].Text;
        int count = 0;
        while (!task.IsCompleted)
        {
            await Task.Delay(100);
            if (count == 6)
            {
                loadWindow.Controls[0].Text = initText;
                count = 0;
            }
            else
            {
                loadWindow.Controls[0].Text = loadWindow.Controls[0].Text + ".";
                count++;
            }
        }
        loadWindow.Hide();
        loadWindow.Dispose();
    }
}