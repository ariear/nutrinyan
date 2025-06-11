using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
using NutriNyan.Models.Enums;

namespace NutriNyan.Views.Dashboard
{
    public partial class SettingControl : UserControl
    {
        User? user = Database.userLogged.Get();
        public SettingControl()
        {
            InitializeComponent();
        }

        private void SettingControl_Load(object sender, EventArgs e)
        {
            GetCurrentUserAndRenderIt();
        }

        private void GetCurrentUserAndRenderIt()
        {
            NamaBox.Text = user.Username;
            TGLlahirdates.Value = user.DateBirth;
            TBbox.Text = Convert.ToString(user.Tb);
            BBbox.Text = Convert.ToString(user.Bb);
            TargetAirbox.Text = Convert.ToString(user.DefaultTargetWater);
            TingkatAktivitasbox.DataSource = Enum.GetValues(typeof(ActivityLevel));

            // var _optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            // using (var dbContext = new AppDbContext(_optionsBuilder.Options))
            // {
                

                // JKbox.DataSource = dbContext.Genders.Select(b => new { b.Type, b.Id }).ToList(); // Get only Type column of Genders table
                // JKbox.DisplayMember = "Type";
                // JKbox.ValueMember = "Id";

                // var purposes = dbContext.Purposes.Select(b => new { b.Title, b.Id }).ToList(); // Get only Title column of Purposes table

            
            // }
            JKbox.DataSource = Database.genders; // Get only Type column of Genders table
            JKbox.DisplayMember = "GenderName";
            JKbox.ValueMember = "DbGenderId";

            TargetTujuanbox.DataSource = Database.purposes;
            TargetTujuanbox.DisplayMember = "purposeName";
            TargetTujuanbox.ValueMember = "purposeId";

            JKbox.SelectedValue = user.GenderId;
            TargetTujuanbox.SelectedValue = user.PurposeId;
            if (Enum.TryParse(user.TingkatAktivitas, out ActivityLevel defaultLevel))
            {
                TingkatAktivitasbox.SelectedItem = defaultLevel;
            }
        }

        private void PerbaruiButton_Click(object sender, EventArgs e)
        {
            User userUpdate = Database.userLogged.Get();
            if (Single.Parse("1,001") < Single.Parse("1.001"))
            {
                userUpdate.Tb = Single.Parse(TBbox.Text);
                userUpdate.Bb = Single.Parse(BBbox.Text);
            }
            else
            {
                userUpdate.Tb = Single.Parse(TBbox.Text.Replace(",","."));
                userUpdate.Bb = Single.Parse(BBbox.Text.Replace(",","."));
            }
            userUpdate.Username = NamaBox.Text;
            userUpdate.DateBirth = TGLlahirdates.Value;
            userUpdate.DefaultTargetWater = Convert.ToInt32(TargetAirbox.Text);
            userUpdate.GenderId = (int)JKbox.SelectedValue;
            userUpdate.PurposeId = (int)TargetTujuanbox.SelectedValue;
            userUpdate.TingkatAktivitas = TingkatAktivitasbox.SelectedItem.ToString();

            Database.userLogged.Update(userUpdate);
        }

        private void PerbaruiPasswordButton_Click(object sender, EventArgs e)
        {
            if (PWbaruBox.Text == "" || PWlamaBox.Text == "")
            {
                MessageBox.Show("Password lama atau Password baru belum diisi", "Informasi");
            } else if (user.Password != Logic.Get_PWDHash(PWlamaBox.Text))
            {
                MessageBox.Show("Password lama salah", "Informasi");
            } else if (!Logic.IsValidPwd(PWbaruBox.Text))
            {
                MessageBox.Show("Password baru tidak valid!!", "Informasi");
            } else
            {
                bool updatePw = Database.userLogged.UpdatePassword(PWbaruBox.Text);
                if (updatePw)
                {
                    PWlamaBox.Text = "";
                    PWbaruBox.Text = "";
                }
            }
        }
    }
}
