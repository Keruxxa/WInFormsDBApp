using WinFormsApp.Classes;

namespace WinFormsApp
{
    public partial class ProvidersForm : Form
    {
        DataBase dataBase = new();

        public void CreateColumnsProviders(DataGridView dataGridProviders)
        {
            dataGridProviders.Columns.Add("Provider_Id", "ID");
            dataGridProviders.Columns.Add("Provider_Name", "Наименование");
            dataGridProviders.Columns.Add("Provider_Address", "Адрес");
            dataGridProviders.Columns.Add("Provider_Phone", "Телефон");
            dataGridProviders.Columns[0].Width = 40;
            dataGridProviders.Columns[1].Width = 198;
            dataGridProviders.Columns[2].Width = 338;
            dataGridProviders.Columns[3].Width = 179;
        }

        private void textBoxSearchProvider_TextChanged(object sender, EventArgs e)
        {
            dataGridProviders.Rows.Clear();

            string querySearch = $"""
                SELECT S.Provider_Id AS Provider_Id,
                       S.Provider_Name AS Наименование,
                       S.Provider_Address AS Адрес,
                       S.Provider_Phone AS Телефон
                FROM Providers S
                WHERE CONCAT(S.Provider_Name,
                             S.Provider_Address,
                             S.Provider_Phone)
                LIKE '%{textBoxSearchProvider.Text.Trim()}%'
                """;

            DataGridPerformer.FillColumnsProviders(dataGridProviders, dataBase, querySearch);
        }

        private void ProvidersForm_Load(object sender, EventArgs e)
        {
            ParentForm.Enabled = false;
            buttonAddProvider.Enabled = User.IsAdmin;
            buttonDeleteProvider.Enabled = User.IsAdmin;
            buttonEditProvider.Enabled = User.IsAdmin;
        }

        private void ProvidersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm.Enabled = true;
        }


        //labelAddProvider
        private void buttonAddProvider_MouseEnter(object sender, EventArgs e)
        {
            labelAddProvider.BackColor = Color.LightGray;
        }

        private void buttonAddProvider_MouseLeave(object sender, EventArgs e)
        {
            labelAddProvider.BackColor = Color.Transparent;
        }

        private void buttonAddProvider_MouseDown(object sender, MouseEventArgs e)
        {
            labelAddProvider.BackColor = Color.DarkGray;
        }

        private void buttonAddProvider_MouseUp(object sender, MouseEventArgs e)
        {
            labelAddProvider.BackColor = Color.LightGray;
        }


        //labelDeleteProvider
        private void buttonDeleteProvider_MouseEnter(object sender, EventArgs e)
        {
            labelDeleteProvider.BackColor = Color.LightGray;
        }

        private void buttonDeleteProvider_MouseLeave(object sender, EventArgs e)
        {
            labelDeleteProvider.BackColor = Color.Transparent;
        }

        private void buttonDeleteProvider_MouseDown(object sender, MouseEventArgs e)
        {
            labelDeleteProvider.BackColor = Color.DarkGray;
        }

        private void buttonDeleteProvider_MouseUp(object sender, MouseEventArgs e)
        {
            labelDeleteProvider.BackColor = Color.LightGray;
        }

        //labelEditProvider
        private void buttonEditProvider_MouseEnter(object sender, EventArgs e)
        {
            labelEditProvider.BackColor = Color.LightGray;
        }

        private void buttonEditProvider_MouseLeave(object sender, EventArgs e)
        {
            labelEditProvider.BackColor = Color.Transparent;
        }

        private void buttonEditProvider_MouseDown(object sender, MouseEventArgs e)
        {
            labelEditProvider.BackColor = Color.DarkGray;
        }

        private void buttonEditProvider_MouseUp(object sender, MouseEventArgs e)
        {
            labelEditProvider.BackColor = Color.LightGray;
        }
    }
}
