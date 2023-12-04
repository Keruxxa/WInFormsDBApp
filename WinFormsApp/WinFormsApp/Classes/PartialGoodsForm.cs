using WinFormsApp.Classes;

namespace WinFormsApp
{
    public partial class GoodsForm : Form
    {
        public User User { get; set; }

        DataBase dataBase = new();

        public void CreateColumnsGoods(DataGridView dataGridGoods)
        {
            dataGridGoods.Columns.Add("Good_ID", "ID");
            dataGridGoods.Columns.Add("Good_Category", "Категория");
            dataGridGoods.Columns.Add("Good_Name", "Наименование");
            dataGridGoods.Columns.Add("Good_Description", "Описание");
            dataGridGoods.Columns.Add("Good_UnitPrice", "Цена единицы");
            dataGridGoods.Columns[0].Width = 40;
            dataGridGoods.Columns[1].Width = 130;
            dataGridGoods.Columns[2].Width = 200;
            dataGridGoods.Columns[3].Width = 265;
            dataGridGoods.Columns[4].Width = 120;
        }

        private void textBoxSearchGoods_TextChanged(object sender, EventArgs e)
        {
            dataGridGoods.Rows.Clear();

            string querySearch = $"""
                SELECT G.Good_Id AS Good_ID,
                	   G.Good_Category AS Категория,
                       G.Good_Name AS Наименование,
                	   G.Good_Description AS Описание,
                       G.Good_UnitPrice AS Цена
                FROM Goods G
                WHERE CONCAT(G.Good_Name,
                             G.Good_Category,
                             G.Good_Description,
                             G.Good_UnitPrice)
                LIKE '%{textBoxSearchGoods.Text.Trim()}%'
                """;

            DataGridPerformer.FillColumnsGoods(dataGridGoods, dataBase, querySearch);
        }

        private void GoodsForm_Load(object sender, EventArgs e)
        {
            ParentForm.Enabled = false;
            buttonAddGood.Enabled = User.IsAdmin;
            buttonDeleteGood.Enabled = User.IsAdmin;
            buttonEditGood.Enabled = User.IsAdmin;
        }

        private void GoodsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm.Enabled = true;
        }

        //labelAddGoods
        private void buttonAddGood_MouseEnter(object sender, EventArgs e)
        {
            labelAddGoods.BackColor = Color.LightGray;
        }

        private void buttonAddGood_MouseLeave(object sender, EventArgs e)
        {
            labelAddGoods.BackColor = Color.Transparent;
        }

        private void buttonAddGood_MouseDown(object sender, MouseEventArgs e)
        {
            labelAddGoods.BackColor = Color.DarkGray;
        }

        private void buttonAddGood_MouseUp(object sender, MouseEventArgs e)
        {
            labelAddGoods.BackColor = Color.LightGray;
        }


        //labelDeleteGoods
        private void buttonDeleteGood_MouseEnter(object sender, EventArgs e)
        {
            labelDeleteGoods.BackColor = Color.LightGray;
        }

        private void buttonDeleteGood_MouseLeave(object sender, EventArgs e)
        {
            labelDeleteGoods.BackColor = Color.Transparent;
        }

        private void buttonDeleteGood_MouseDown(object sender, MouseEventArgs e)
        {
            labelDeleteGoods.BackColor = Color.DarkGray;
        }

        private void buttonDeleteGood_MouseUp(object sender, MouseEventArgs e)
        {
            labelDeleteGoods.BackColor = Color.LightGray;
        }

        //labelEditGoods
        private void buttonEditGood_MouseEnter(object sender, EventArgs e)
        {
            labelEditGoods.BackColor = Color.LightGray;
        }

        private void buttonEditGood_MouseLeave(object sender, EventArgs e)
        {
            labelEditGoods.BackColor = Color.Transparent;
        }

        private void buttonEditGood_MouseDown(object sender, MouseEventArgs e)
        {
            labelEditGoods.BackColor = Color.DarkGray;
        }

        private void buttonEditGood_MouseUp(object sender, MouseEventArgs e)
        {
            labelEditGoods.BackColor = Color.LightGray;
        }
    }
}
