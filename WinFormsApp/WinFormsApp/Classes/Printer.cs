using Excel = Microsoft.Office.Interop.Excel;

namespace WinFormsApp.Classes
{
    public static class Printer
    {
        public static void FillGrid(DataGridView dataGridView, Excel.Worksheet wsh)
        {
            for (int i = 2; i < dataGridView.RowCount + 2; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridView[j, i - 2].Value.ToString();
                }
            }
        }


        public static void PrintSupplies(DataGridView dataGridSupplies)
        {
            Excel.Application exApp = new();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            wsh.Cells[1, 1] = "Поставки предприятия";
            wsh.Cells[2, 1] = "Номер";
            wsh.Cells[2, 2] = "Товар";
            wsh.Cells[2, 3] = "Поставщик";
            wsh.Cells[2, 4] = "Склад";
            wsh.Cells[2, 5] = "Количество";
            wsh.Cells[2, 6] = "Стоимость";
            wsh.Cells[2, 7] = "Дата";

            FillGrid(dataGridSupplies, wsh);
            exApp.Visible = true;
        }

        public static async Task PrintSuppliesAsync(DataGridView dataGridSupplies)
        {
            await Task.Run(() => PrintSupplies(dataGridSupplies));
        }


        public static void PrintGoods(DataGridView dataGridGoods)
        {
            Excel.Application exApp = new();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            wsh.Cells[1, 1] = "Товары предприятия";
            wsh.Cells[2, 1] = "ID";
            wsh.Cells[2, 2] = "Категория";
            wsh.Cells[2, 3] = "Наименование";
            wsh.Cells[2, 4] = "Описание";
            wsh.Cells[2, 5] = "Цена";

            FillGrid(dataGridGoods, wsh);
            exApp.Visible = true;
        }

        public static async Task PrintGoodsAsync(DataGridView dataGridGoods)
        {
            await Task.Run(() => PrintGoods(dataGridGoods));
        }


        public static void PrintStocks(DataGridView dataGridStocks)
        {
            Excel.Application exApp = new();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            wsh.Cells[1, 1] = "Склады предприятия";
            wsh.Cells[2, 1] = "ID";
            wsh.Cells[2, 2] = "Наименование";
            wsh.Cells[2, 3] = "Категория";
            wsh.Cells[2, 4] = "Адрес";

            FillGrid(dataGridStocks, wsh);
            exApp.Visible = true;
        }

        public static async Task PrintStocksAsync(DataGridView dataGridStocks)
        {
            await Task.Run(() => PrintStocks(dataGridStocks));
        }


        public static void PrintProviders(DataGridView dataGridProviders)
        {
            Excel.Application exApp = new();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            wsh.Cells[1, 1] = "Поставщики предприятия";
            wsh.Cells[2, 1] = "ID";
            wsh.Cells[2, 2] = "Наименование";
            wsh.Cells[2, 3] = "Адрес";
            wsh.Cells[2, 4] = "Телефон";

            FillGrid(dataGridProviders, wsh);
            exApp.Visible = true;
        }

        public static async Task PrintProvidersAsync(DataGridView dataGridProviders)
        {
            await Task.Run(() => PrintProviders(dataGridProviders));
        }


        public static void PrintStocksGoods(DataGridView dataGridSG)
        {
            Excel.Application exApp = new();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            wsh.Cells[1, 1] = "Товары на складах предприятия";
            wsh.Cells[2, 1] = "Категория";
            wsh.Cells[2, 2] = "Товар";
            wsh.Cells[2, 3] = "Склад";
            wsh.Cells[2, 4] = "Количество";
            wsh.Cells[2, 5] = "Стоимость";

            FillGrid(dataGridSG, wsh);
            exApp.Visible = true;
        }

        public static async Task PrintStocksGoodsAsync(DataGridView dataGridSG)
        {
            await Task.Run(() => PrintStocksGoods(dataGridSG));
        }
    }
}
