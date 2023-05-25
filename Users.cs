using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storage
{
    public partial class Users : Form
    {
        const string FILE_PRODUCTS = "Products.json";
        const string FILE_USERS = "Users.json";

        int n = 0;
        int numbers = 0;
        public Users()
        {
            Task.Run(() => File.Open(FILE_USERS, FileMode.OpenOrCreate).Close());

            Task.Run(() => File.Open(FILE_PRODUCTS, FileMode.OpenOrCreate).Close());

            InitializeComponent();
        }

        //запись в файл json
        async Task WriteToFile<T>(List<T> data, string FILE_NAME)
        {
            using (var streamWriter = new StreamWriter(FILE_NAME, false))
            {
                await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
            }
        }

        //чтение из файла json
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () => JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
            }
        }

        async void ad_us_Click(object sender, EventArgs e)
        {
            User_add FormAddUser = new User_add();
            FormAddUser.ShowDialog();

            uint idForm = User_add.IdForm;
            string famForm = User_add.FamForm;
            string nameForm = User_add.NameForm;
            uint phoneForm = User_add.PhoneForm;
            uint creditcForm = User_add.CreditcForm;

            InfoUsers newUser = new InfoUsers(idForm, famForm, nameForm, phoneForm, creditcForm);

            if ((idForm > 0) && !string.IsNullOrEmpty(famForm) && !string.IsNullOrEmpty(nameForm) && (phoneForm > 0) && (creditcForm > 0))
            {
                var users = await ReadFromFile<InfoUsers>(FILE_USERS);

                if (!users.Contains(newUser))
                {
                    foreach (var us in users)
                    {
                        if (us.ID == idForm)
                        {
                            MessageBox.Show($"Контрагент {us.ID} уже занесён в базу. "
                                , "Добавление контрагента", 0, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    users.Add(newUser);

                    n = users.Count;
                    count_of_users.Text = Convert.ToString(n);

                    await WriteToFile(users, FILE_USERS);

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[numbers].Cells[0].Value = idForm;
                    dataGridView1.Rows[numbers].Cells[1].Value = famForm;
                    dataGridView1.Rows[numbers].Cells[2].Value = nameForm;
                    dataGridView1.Rows[numbers].Cells[3].Value = phoneForm;
                    dataGridView1.Rows[numbers].Cells[4].Value = creditcForm;
                    numbers++;
                }
                else
                {
                    MessageBox.Show($"Этот контрагент был занесён в базу ранее", "Добавление контрагента", 0, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        async void del_us_Click(object sender, EventArgs e)
        {
            Int32 selectCount =
                        dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            uint idForm = User_add.IdForm;
            if (selectCount > 0)
            {
                var users = await ReadFromFile<InfoUsers>(FILE_USERS);
                var products = await ReadFromFile<InfoProducts>(FILE_PRODUCTS);
                uint id = Convert.ToUInt32(dataGridView1.SelectedCells[0].Value.ToString());
                string fam = dataGridView1.SelectedCells[1].Value.ToString();
                string name = dataGridView1.SelectedCells[2].Value.ToString();
                uint phone = Convert.ToUInt32(dataGridView1.SelectedCells[3].Value.ToString());
                uint creditc = Convert.ToUInt32(dataGridView1.SelectedCells[4].Value.ToString());
                var flag = true;
                bool chet = false;
                foreach (var pr in products)
                {
                    if (id == pr.ID)
                    {
                        chet = true;
                        
                    }

                }
                if (chet)
                {
                    flag = false;
                    MessageBox.Show($"Вы не можете удалить контрагента, так как" +
                        $" на складе хранится его имущество!", "Удаление одного контрагента", 0, MessageBoxIcon.Information);
                    return;
                }
                if (flag)
                {
                    foreach (var us in users)
                    {
                        if (id == us.ID && fam == us.Fam && name == us.Name && phone == us.Phone && creditc == us.Creditc)
                        {
                            users.Remove(us);
                            n = users.Count;
                            count_of_users.Text = Convert.ToString(n);
                            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                            numbers--;
                            MessageBox.Show($"Контрагент  {us.ID}  удалён!", "Удаление одного контрагента", 0, MessageBoxIcon.Information);
                            break;
                        }
                    }

                    await WriteToFile(users, FILE_USERS);
                }
                
            }
            else
            {
                MessageBox.Show("Нет ни одного контрагента!", "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }

        async void del_allpr_Click(object sender, EventArgs e)
        {
            var users = await ReadFromFile<InfoUsers>(FILE_USERS);

            var products = await ReadFromFile<InfoProducts>(FILE_PRODUCTS);


            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Нет ни одного контрагента!", "Удалить всех контрагентов", 0, MessageBoxIcon.Information);
            }
            else if (products.Count > 0)
            {
                MessageBox.Show("Вы не можете удалить всех контрагентов, так как в базе склада есть имущество!",
                    "Удалить всех контрагентов", 0, MessageBoxIcon.Information);
            }
            else
            {
                users.Clear();
                n = users.Count;
                count_of_users.Text = Convert.ToString(n);
                dataGridView1.Rows.Clear();
                numbers = 0;
                MessageBox.Show("Данные всех контрагентов удалены!", "Удалить всех контрагентов", 0, MessageBoxIcon.Information);

            }

            await WriteToFile(users, FILE_USERS);
        }

        async void Users_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_USERS))
            {

                var table_of_users = await ReadFromFile<InfoUsers>(FILE_USERS);

                n = table_of_users.Count;
                count_of_users.Text = Convert.ToString(n);

                if (table_of_users != null)

                    foreach (var user in table_of_users)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[numbers].Cells[0].Value = user.ID;
                        dataGridView1.Rows[numbers].Cells[1].Value = user.Fam;
                        dataGridView1.Rows[numbers].Cells[2].Value = user.Name;
                        dataGridView1.Rows[numbers].Cells[3].Value = user.Phone;
                        dataGridView1.Rows[numbers].Cells[4].Value = user.Creditc;
                        numbers++;
                    }
            }
        }
    }
}
