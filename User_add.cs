using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace storage
{
    public partial class User_add : Form
    {
        public static uint IdForm = 0;
        public static string FamForm = "";
        public static string NameForm = "";
        public static uint PhoneForm = 0;
        public static uint CreditcForm = 0;

        public User_add()
        {
            InitializeComponent();
        }


        bool CheckOnCorrectTextBox(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-ЯЁ]+[а-яё]") || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (lb1.Text = "Пример: Николаев") != "Пример: Николаев";

        bool CheckOnCorrectTextBox2(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
           Regex.IsMatch(tb.Text, @"^[А-ЯЁ]+[а-яё]") || (tb.BackColor = Color.MistyRose) != Color.MistyRose
           || (lb2.Text = "Пример: Николай") != "Пример: Николай";

        bool CheckOnCorrectNumberBox(TextBox nb) => uint.TryParse(nb.Text, out _) || (nb.BackColor = Color.MistyRose) != Color.MistyRose;

        bool FlagCorrect =>
            CheckOnCorrectNumberBox(add_ID) &
            CheckOnCorrectTextBox(add_fam) &
            CheckOnCorrectTextBox2(add_name) &
            CheckOnCorrectNumberBox(add_phone) &
            CheckOnCorrectNumberBox(add_creditc);

        private void addus_button_Click(object sender, EventArgs e)
        {
            if (FlagCorrect)
            {
                IdForm = Convert.ToUInt32(add_ID.Text);
                FamForm = add_fam.Text;
                NameForm = add_name.Text;
                PhoneForm = Convert.ToUInt32(add_phone.Text);
                CreditcForm = Convert.ToUInt32(add_creditc.Text);

                Close();

            }
            else
                MessageBox.Show($"Некорректные данные", "Добавление контрагента", 0, MessageBoxIcon.Information);
        }
    }
}
