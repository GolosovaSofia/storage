using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace storage
{
    public partial class Product_add : Form
    {
        public static uint IdForm = 0;
        public static string TypeForm = "";
        public static uint NumberForm = 0;
        public static uint LifeForm = 0;
        public static uint CostForm = 0;
        public static string GiveForm = "";

        public Product_add()
        {
            InitializeComponent();
        }
       bool CheckOnCorrectComboBox(ComboBox cb) => !(cb.SelectedItem is null) || (cb.BackColor = Color.MistyRose) != Color.MistyRose;

        bool CheckOnCorrectNumberBox(TextBox nb) => uint.TryParse(nb.Text, out _) || (nb.BackColor = Color.MistyRose) != Color.MistyRose;

        bool FlagCorrect =>
            CheckOnCorrectNumberBox(add_id) &
            CheckOnCorrectComboBox(add_type) &
            CheckOnCorrectNumberBox(add_number) &
            CheckOnCorrectNumberBox(add_life) &
            CheckOnCorrectNumberBox(add_cost) &
            CheckOnCorrectComboBox(add_give);

        private void addpr_button_Click(object sender, EventArgs e)
        {
            if (FlagCorrect)
            {
                IdForm = Convert.ToUInt32(add_id.Text);
                TypeForm = add_type.SelectedItem as string;
                NumberForm = Convert.ToUInt32(add_number.Text);
                LifeForm = Convert.ToUInt32(add_life.Text);
                CostForm = Convert.ToUInt32(add_cost.Text);
                GiveForm = add_give.SelectedItem as string;

                Close();
            }
            else
                MessageBox.Show($"Некорректные данные", "Добавление позиции", 0, MessageBoxIcon.Information);


        }
    }
}
