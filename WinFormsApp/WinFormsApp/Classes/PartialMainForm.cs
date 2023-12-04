using System.Data.SqlClient;
using WinFormsApp.Classes;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        public User User { get; set; }

        DataBase dataBase = new();

        public void CreateColumnsSupplies(DataGridView dataGridSupplies)
        {
            dataGridSupplies.Columns.Add("Supply_Id", "Номер");
            dataGridSupplies.Columns.Add("Good_Name", "Товар");
            dataGridSupplies.Columns.Add("Provider_Name", "Поставщик");
            dataGridSupplies.Columns.Add("Stock_Name", "Склад");
            dataGridSupplies.Columns.Add("Good_Amount", "Количество");
            dataGridSupplies.Columns.Add("Unit_Price", "Стоимость");
            dataGridSupplies.Columns.Add("Supply_Date", "Дата");
            dataGridSupplies.Columns[0].Width = 55;
            dataGridSupplies.Columns[1].Width = 159;
            dataGridSupplies.Columns[2].Width = 159;
            dataGridSupplies.Columns[3].Width = 159;
            dataGridSupplies.Columns[4].Width = 159;
            dataGridSupplies.Columns[5].Width = 159;
            dataGridSupplies.Columns[6].Width = 159;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridSupplies.Rows.Clear();

            string querySearch = $"""
                WITH Temp AS
                (
                	SELECT Supply.Supply_Id AS Supply_Id,
                		   Goods.Good_Name AS Наименование_товара,
                		   Providers.Provider_Name AS Поставщик,
                		   Stocks.Stock_Name AS Склад,
                		   Supply.Good_Amount AS Количество,
                           Supply.Unit_Price AS Цена,
                		   Supply.Supply_Date AS Дата
                	FROM Supply
                	JOIN Goods ON Supply.Good_Id = Goods.Good_Id
                	JOIN Providers ON Supply.Provider_Id = Providers.Provider_Id
                	JOIN Stocks ON Supply.Stock_Id = Stocks.Stock_Id
                )
                SELECT * FROM Temp
                WHERE CONCAT(Supply_Id,
                             Наименование_товара,
                             Поставщик,
                             Склад,
                			 Количество,
                			 Цена,
                			 Дата)
                LIKE '%{textBoxSearch.Text.Trim()}%'
                """;

            DataGridPerformer.FillColumnsSupplies(dataGridSupplies, dataBase, querySearch);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonAddSupply.Enabled = User.IsAdmin;
            buttonDeleteSupply.Enabled = User.IsAdmin;
            IsAdmin();
        }

        private void buttonDeleteSupply_Click(object sender, EventArgs e)
        {
            if (dataGridSupplies.SelectedRows.Count != 1)
            {
                MessageBox.Show("Количество выбранных строк должно равняться одному!", "Ошибка!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Удалить поставку?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridSupplies.CurrentCell.RowIndex;

                int id = Convert.ToInt32(dataGridSupplies.Rows[index].Cells[0].Value);

                dataBase.OpenConnection();

                string queryString = $"DELETE FROM Supply WHERE Supply_Id = {id}";

                var command = new SqlCommand(queryString, dataBase.GetConnection());
                command.ExecuteNonQuery();

                dataBase.CloseConnection();

                MessageBox.Show("Поставка была успешно удалена!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridSupplies.Rows.RemoveAt(index);
                dataGridSupplies.Update();
                dataGridSupplies.Refresh();
            }
        }

        public void IsAdmin()
        {
            if (User.IsAdmin)
            {
                labelUser.Text = $"Пользователь: {User.Login}. Администратор";
                labelUser.ForeColor = Color.Red;
            }
            else
                labelUser.Text = $"Пользователь: {User.Login}. Пользователь";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        //labelAddSupply
        private void buttonAddSupply_MouseEnter(object sender, EventArgs e)
        {
            labelAddSupply.BackColor = Color.LightGray;
        }

        private void buttonAddSupply_MouseLeave(object sender, EventArgs e)
        {
            labelAddSupply.BackColor = Color.Transparent;
        }

        private void buttonAddSupply_MouseDown(object sender, MouseEventArgs e)
        {
            labelAddSupply.BackColor = Color.DarkGray;
        }

        private void buttonAddSupply_MouseUp(object sender, MouseEventArgs e)
        {
            labelAddSupply.BackColor = Color.LightGray;
        }


        //labelGoods
        private void buttonGoods_MouseEnter(object sender, EventArgs e)
        {
            labelGoods.BackColor = Color.LightGray;
        }

        private void buttonGoods_MouseLeave(object sender, EventArgs e)
        {
            labelGoods.BackColor = Color.Transparent;
        }

        private void buttonGoods_MouseDown(object sender, MouseEventArgs e)
        {
            labelGoods.BackColor = Color.DarkGray;
        }

        private void buttonGoods_MouseUp(object sender, MouseEventArgs e)
        {
            labelGoods.BackColor = Color.LightGray;
        }


        //labelStocks
        private void buttonStocks_MouseEnter(object sender, EventArgs e)
        {
            labelStocks.BackColor = Color.LightGray;
        }

        private void buttonStocks_MouseLeave(object sender, EventArgs e)
        {
            labelStocks.BackColor = Color.Transparent;
        }

        private void buttonStocks_MouseDown(object sender, MouseEventArgs e)
        {
            labelStocks.BackColor = Color.DarkGray;
        }

        private void buttonStocks_MouseUp(object sender, MouseEventArgs e)
        {
            labelStocks.BackColor = Color.LightGray;
        }

        //labelProviders
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            labelProviders.BackColor = Color.LightGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            labelProviders.BackColor = Color.Transparent;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            labelProviders.BackColor = Color.DarkGray;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            labelProviders.BackColor = Color.LightGray;
        }

        //buttonDeleteSupply
        private void buttonDeleteSupply_MouseEnter(object sender, EventArgs e)
        {
            labelDeleteSupply.BackColor = Color.LightGray;
        }

        private void buttonDeleteSupply_MouseLeave(object sender, EventArgs e)
        {
            labelDeleteSupply.BackColor = Color.Transparent;
        }

        private void buttonDeleteSupply_MouseDown(object sender, MouseEventArgs e)
        {
            labelDeleteSupply.BackColor = Color.DarkGray;
        }

        private void buttonDeleteSupply_MouseUp(object sender, MouseEventArgs e)
        {
            labelDeleteSupply.BackColor = Color.LightGray;
        }

        //buttonStrocksGoods
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            labelSG.BackColor = Color.LightGray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            labelSG.BackColor = Color.Transparent;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            labelSG.BackColor = Color.DarkGray;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            labelSG.BackColor = Color.LightGray;
        }
    }
}
