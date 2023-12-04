using System.Data.SqlClient;
using WinFormsApp.Classes;


namespace WinFormsApp
{

    public partial class AddEditGoods : Form
    {
        DataBase dataBase = new();

        public bool AddMode { get; set; }
        public DataGridView DataGrid { get; set; }

        public AddEditGoods(string buttonName, DataGridView dataGrid, bool addMode)
        {
            InitializeComponent();
            buttonGoodAccept.Text = buttonName;
            AddMode = addMode;
            DataGrid = dataGrid;
        }

        private void buttonGoodCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGoodAccept_Click(object sender, EventArgs e)
        {
            if (textBoxGoodName.Text == string.Empty ||
                textBoxGoodCategory.Text == string.Empty ||
                numericPrice.Value == 0)
            {
                MessageBox.Show("Поля с наименованием, категорией и ценой должны быть заполнены!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            if (AddMode)
            {
                try
                {
                    Goods good = new Goods()
                    {
                        Name = textBoxGoodName.Text,
                        Category = textBoxGoodCategory.Text,
                        Description = textBoxGoodDesc.Text,
                        UnitPrice = numericPrice.Value.ToString()
                    };

                    dataBase.OpenConnection();

                    string insertQueryString = $"INSERT INTO Goods (Good_Category, Good_Name, Good_Description, Good_UnitPrice)" +
                                         $"VALUES ('{good.Category}', '{good.Name}', '{good.Description}', {good.UnitPrice})";

                    var command = new SqlCommand(insertQueryString, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                    dataBase.CloseConnection();

                    MessageBox.Show("Товар был успешно добавлен!", "Внимание!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataGrid.Rows.Clear();
                    DataGridPerformer.FillColumnsGoods(DataGrid, dataBase, queryString);
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Товар уже существует, или введенные данные неверны!", "Внимание!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int index = DataGrid.CurrentCell.RowIndex;
                int id = Convert.ToInt32(DataGrid.Rows[index].Cells[0].Value);
                try
                {
                    Goods good = new Goods()
                    {
                        ID = id.ToString(),
                        Name = textBoxGoodName.Text,
                        Category = textBoxGoodCategory.Text,
                        Description = textBoxGoodDesc.Text,
                        UnitPrice = numericPrice.Value.ToString()
                    };

                    dataBase.OpenConnection();

                    string insertQueryString = $"""
                        UPDATE Goods
                        SET Goods.Good_Name = '{good.Name}',
                        	Goods.Good_Category = '{good.Category}',
                        	Goods.Good_Description = '{good.Description}',
                            Goods.Good_UnitPrice = {good.UnitPrice}
                        WHERE Goods.Good_Id = {good.ID}
                        """;

                    var command = new SqlCommand(insertQueryString, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                    dataBase.CloseConnection();

                    MessageBox.Show("Товар был успешно изменен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataGrid.Rows.Clear();
                    DataGridPerformer.FillColumnsGoods(DataGrid, dataBase, queryString);
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Изменение прошло неудачно! Данный товар существует, или введенные данные неверны!", "Внимание!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        string queryString = """
                SELECT G.Good_Id as Good_ID, 
                	   G.Good_Category AS Категория,
                       G.Good_Name AS Наименование,
                	   G.Good_Description AS Описание,
                	   G.Good_UnitPrice AS Цена
                FROM Goods G
                """;

        private void AddEdirGoodsForm_Load(object sender, EventArgs e)
        {
            if (!AddMode)
            {
                int index = DataGrid.CurrentCell.RowIndex;
                textBoxGoodCategory.Text = DataGrid.Rows[index].Cells[1].Value.ToString();
                textBoxGoodName.Text = DataGrid.Rows[index].Cells[2].Value.ToString();
                textBoxGoodDesc.Text = DataGrid.Rows[index].Cells[3].Value.ToString();
                numericPrice.Value = Convert.ToDecimal(DataGrid.Rows[index].Cells[4].Value);
            }
        }
    }
}
