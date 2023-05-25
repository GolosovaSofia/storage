using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storage
{
    public partial class Products : Form
    {
        const string FILE_PRODUCTS = "Products.json";
        const string FILE_USERS = "Users.json";

        int n_pr = 0;
        int numberr = 0;

        public Products()
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
        

        async void ad_pr_Click(object sender, EventArgs e)
        {
            Product_add FormAdd = new Product_add();
            FormAdd.ShowDialog();

            uint idForm = Product_add.IdForm;
            string typeForm = Product_add.TypeForm;
            uint numberForm = Product_add.NumberForm;
            uint lifeForm = Product_add.LifeForm;
            uint costForm = Product_add.CostForm;
            string giveForm = Product_add.GiveForm;
            bool chet = false;
            var users = await ReadFromFile<InfoUsers>(FILE_USERS);

            InfoProducts newProduct = new InfoProducts(idForm, typeForm, numberForm, lifeForm, costForm, giveForm);

            if ((idForm > 0) && !string.IsNullOrEmpty(typeForm) && (numberForm > 0) && (lifeForm > 0) && (costForm > 0) && !string.IsNullOrEmpty(giveForm))
            {
                var products = await ReadFromFile<InfoProducts>(FILE_PRODUCTS);

                
                if (!products.Contains(newProduct))
                {
                    foreach (var us in users)
                    {
                        if (idForm == us.ID)
                        {
                            chet = true;
                        
                        }
                    }
                    if (!chet)
                    {
                    MessageBox.Show($"Имущество не может быть добавлено, " +
                            $"так как в базе контрагентов нет соответствующего ID!" +
                            $" {Environment.NewLine} " +
                            $"Совет: На вкладке <Контрагенты> добавьте контрагента с соответствующим ID!"
                            , "Добавление позиции", 0, MessageBoxIcon.Information);
                    return;
                    }
                    foreach (var pr in products)
                    {
                        if (pr.ID == idForm)
                        {
                            MessageBox.Show($"Имущество с таким ID  <{pr.ID}>  уже есть в базе. "
                                , "Добавление позиции", 0, MessageBoxIcon.Information);
                            return;
                        }                        
                    }
                    
                    products.Add(newProduct);

                    n_pr = products.Count;
                    count_of_products.Text = Convert.ToString(n_pr);

                    await WriteToFile(products, FILE_PRODUCTS);

                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[numberr].Cells[0].Value = idForm;
                    dataGridView2.Rows[numberr].Cells[1].Value = typeForm;
                    dataGridView2.Rows[numberr].Cells[2].Value = numberForm;
                    dataGridView2.Rows[numberr].Cells[3].Value = lifeForm;
                    dataGridView2.Rows[numberr].Cells[4].Value = costForm;
                    dataGridView2.Rows[numberr].Cells[5].Value = giveForm;
                    numberr++;
                }
                else
                {
                    MessageBox.Show($"Данное имущество было занесено в базу ранее", "Добавление позиции", 0, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        async void Products_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_PRODUCTS))
            {

                var table_of_products = await ReadFromFile<InfoProducts>(FILE_PRODUCTS);

                n_pr = table_of_products.Count;
                count_of_products.Text = Convert.ToString(n_pr);

                if (table_of_products != null)

                    foreach (var products in table_of_products)
                    {
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[numberr].Cells[0].Value = products.ID;
                        dataGridView2.Rows[numberr].Cells[1].Value = products.Type;
                        dataGridView2.Rows[numberr].Cells[2].Value = products.Number;
                        dataGridView2.Rows[numberr].Cells[3].Value = products.Life;
                        dataGridView2.Rows[numberr].Cells[4].Value = products.Cost;
                        dataGridView2.Rows[numberr].Cells[5].Value = products.Give;
                        numberr++;
                    }
            }
        }

        async void del_pr_Click(object sender, EventArgs e)
        {
            Int32 selectCount =
                        dataGridView2.GetCellCount(DataGridViewElementStates.Selected);

            if (selectCount > 0)
            {

                var products = await ReadFromFile<InfoProducts>(FILE_PRODUCTS);

                uint id = Convert.ToUInt32(dataGridView2.SelectedCells[0].Value.ToString());
                string type = dataGridView2.SelectedCells[1].Value.ToString();
                uint number = Convert.ToUInt32(dataGridView2.SelectedCells[2].Value.ToString());
                uint life = Convert.ToUInt32(dataGridView2.SelectedCells[3].Value.ToString());
                uint cost = Convert.ToUInt32(dataGridView2.SelectedCells[4].Value.ToString());
                string give = dataGridView2.SelectedCells[5].Value.ToString();

                foreach (var pr in products)
                {
                    if (id == pr.ID && type == pr.Type && number == pr.Number
                        && life == pr.Life && cost == pr.Cost && give == pr.Give)
                    {
                        products.Remove(pr);
                        n_pr = products.Count;
                        count_of_products.Text = Convert.ToString(n_pr);
                        dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                        numberr--;
                        MessageBox.Show($"Позиция  <{pr.ID}>  удалена!", "Удаление одной позиции", 0, MessageBoxIcon.Information);
                        break;
                    }
                }

                await WriteToFile(products, FILE_PRODUCTS);
            }
            else
            {
                MessageBox.Show("Нет ни одной позиции!", "Удаление позиции", 0, MessageBoxIcon.Information);
                return;
            }
        }

        async void del_allpr_Click(object sender, EventArgs e)
        {
            var products = await ReadFromFile<InfoProducts>(FILE_PRODUCTS);

            if (dataGridView2.Rows.Count != 0)
            {
                products.Clear();
                n_pr = products.Count;
                count_of_products.Text = Convert.ToString(n_pr);
                dataGridView2.Rows.Clear();
                numberr = 0;
                MessageBox.Show("Данные удалены!", "Удалить все позиции", 0, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нет ни одной позиции!", "Удалить все позиции", 0, MessageBoxIcon.Information);
            }

            await WriteToFile(products, FILE_PRODUCTS);
        }

        async void filtr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(v_filtr.Text))
            {
                MessageBox.Show("Заполните поле!", "Фильтрация", 0, MessageBoxIcon.Information);
                v_filtr.BackColor = Color.MistyRose;
            }
            else
            {
                string filtr = v_filtr.Text;

                dataGridView2.Rows.Clear();
                numberr = 0;

                bool flag = false;
                label2.Text = "Включена фильтрация";
                var products = await ReadFromFile<InfoProducts>(FILE_PRODUCTS);

                foreach (var pr in products)
                {
                    if (pr.Cost == Convert.ToUInt32(filtr))
                    {
                        flag = true;
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[numberr].Cells[0].Value = pr.ID;
                        dataGridView2.Rows[numberr].Cells[1].Value = pr.Type;
                        dataGridView2.Rows[numberr].Cells[2].Value = pr.Number;
                        dataGridView2.Rows[numberr].Cells[3].Value = pr.Life;
                        dataGridView2.Rows[numberr].Cells[4].Value = pr.Cost;
                        dataGridView2.Rows[numberr].Cells[5].Value = pr.Give;
                        numberr++;
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show($"Позиции с такой стоимостью {filtr} не найдены!", "Фильтрация", 0, MessageBoxIcon.Information);
                }
                
            }
        }

        async void del_f_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(v_filtr.Text))
            {
                MessageBox.Show($"Вы не применяли фильтрацию ранее!", "Фильтрация", 0, MessageBoxIcon.Information);
                return;
            }
            v_filtr.Text = "";
            label2.Text = "";
            dataGridView2.Rows.Clear();
            numberr = 0;

            var products = await ReadFromFile<InfoProducts>(FILE_PRODUCTS);

            foreach (var pr in products)
            {

                dataGridView2.Rows.Add();
                dataGridView2.Rows[numberr].Cells[0].Value = pr.ID;
                dataGridView2.Rows[numberr].Cells[1].Value = pr.Type;
                dataGridView2.Rows[numberr].Cells[2].Value = pr.Number;
                dataGridView2.Rows[numberr].Cells[3].Value = pr.Life;
                dataGridView2.Rows[numberr].Cells[4].Value = pr.Cost;
                dataGridView2.Rows[numberr].Cells[5].Value = pr.Give;
                numberr++;
            }
        }

        async void escape_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(v_escape.Text))
            {
                MessageBox.Show("Заполните поле!", "Поиск", 0, MessageBoxIcon.Information);
                v_escape.BackColor = Color.MistyRose;
            }
            else
            {
                string escape = v_escape.Text;

                numberr = 0;
                int i = 0;

                bool flag = false;

                var products = await ReadFromFile<InfoProducts>(FILE_PRODUCTS);

                foreach (var pr in products)
                {
                    if (pr.Type == Convert.ToString(escape))
                    {
                        flag = true;
                        dataGridView2.Rows[i].Selected = true;
                        numberr++;
                    }
                    i++;
                }
                if (flag == false)
                {
                    MessageBox.Show($"Позиции с таким типом не найдены!", "Поиск", 0, MessageBoxIcon.Information);
                }
            }
        }

        async void del_esc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(v_escape.Text))
            {
                MessageBox.Show($"Вы не применяли поиск ранее!", "Поиск", 0, MessageBoxIcon.Information);
                return;
            }
            v_escape.Text = "";
            dataGridView2.Rows.Clear();
            numberr = 0;

            var products = await ReadFromFile<InfoProducts>(FILE_PRODUCTS);

            foreach (var pr in products)
            {

                dataGridView2.Rows.Add();
                dataGridView2.Rows[numberr].Cells[0].Value = pr.ID;
                dataGridView2.Rows[numberr].Cells[1].Value = pr.Type;
                dataGridView2.Rows[numberr].Cells[2].Value = pr.Number;
                dataGridView2.Rows[numberr].Cells[3].Value = pr.Life;
                dataGridView2.Rows[numberr].Cells[4].Value = pr.Cost;
                dataGridView2.Rows[numberr].Cells[5].Value = pr.Give;
                numberr++;
            }
        }

        async void edit_Click(object sender, EventArgs e)
        {
            Int32 selectCount =
                        dataGridView2.GetCellCount(DataGridViewElementStates.Selected);
            if (selectCount > 0)
            {
                //форма редактирования
                Edit EditForm = new Edit();
                EditForm.ShowDialog();

                uint idForm = Edit.IdForm;
                string typeForm = Edit.TypeForm;
                uint numberForm = Edit.NumberForm;
                uint lifeForm = Edit.LifeForm;
                uint costForm = Edit.CostForm;
                string giveForm = Edit.GiveForm;
                bool chet = false;
                var users = await ReadFromFile<InfoUsers>(FILE_USERS);

                InfoProducts newProduct = new InfoProducts(idForm, typeForm, numberForm, lifeForm, costForm, giveForm);

                if ((idForm > 0) && !string.IsNullOrEmpty(typeForm) && (numberForm > 0) && (lifeForm > 0) && (costForm > 0) && !string.IsNullOrEmpty(giveForm))
                {
                    var products = await ReadFromFile<InfoProducts>(FILE_PRODUCTS);


                    if (!products.Contains(newProduct))
                    {
                        foreach (var us in users)
                        {
                            if (idForm == us.ID)
                            {
                                chet = true;

                            }
                        }
                        if (!chet)
                        {
                            MessageBox.Show($"Имущество не может быть добавлено, " +
                                    $"так как в базе контрагентов нет соответствующего ID!" +
                                    $" {Environment.NewLine} " +
                                    $"Совет: На вкладке <Контрагенты> добавьте контрагента с соответствующим ID!"
                                    , "Добавление позиции", 0, MessageBoxIcon.Information);
                            return;
                        }

                        products.Add(newProduct);

                        n_pr = products.Count;
                        count_of_products.Text = Convert.ToString(n_pr);

                        uint id = Convert.ToUInt32(dataGridView2.SelectedCells[0].Value.ToString());
                        string type = dataGridView2.SelectedCells[1].Value.ToString();
                        uint number = Convert.ToUInt32(dataGridView2.SelectedCells[2].Value.ToString());
                        uint life = Convert.ToUInt32(dataGridView2.SelectedCells[3].Value.ToString());
                        uint cost = Convert.ToUInt32(dataGridView2.SelectedCells[4].Value.ToString());
                        string give = dataGridView2.SelectedCells[5].Value.ToString();

                        foreach (var pr in products)
                        {
                            if (id == pr.ID && type == pr.Type && number == pr.Number
                                && life == pr.Life && cost == pr.Cost && give == pr.Give)
                            {
                                products.Remove(pr);
                                n_pr = products.Count;
                                count_of_products.Text = Convert.ToString(n_pr);
                                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                                numberr--;
                                break;
                            }
                        }

                        await WriteToFile(products, FILE_PRODUCTS);

                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[numberr].Cells[0].Value = idForm;
                        dataGridView2.Rows[numberr].Cells[1].Value = typeForm;
                        dataGridView2.Rows[numberr].Cells[2].Value = numberForm;
                        dataGridView2.Rows[numberr].Cells[3].Value = lifeForm;
                        dataGridView2.Rows[numberr].Cells[4].Value = costForm;
                        dataGridView2.Rows[numberr].Cells[5].Value = giveForm;
                        numberr++;
                    }
                    else
                    {
                        MessageBox.Show($"Данное имущество было занесено в базу ранее", "Добавление позиции", 0, MessageBoxIcon.Information);
                        return;
                    }
                }

            }
        }
    }
}
