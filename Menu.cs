using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storage
{
    public partial class Menu : Form
    {
        public Menu()
        {            
            InitializeComponent();
        }
        private void Users_Click(object sender, EventArgs e)
        {
            Users User = new Users();
            User.ShowDialog();
        }
        private void Products_Click(object sender, EventArgs e)
        {
            Products Product = new Products();
            Product.ShowDialog();
        }
    }
}
