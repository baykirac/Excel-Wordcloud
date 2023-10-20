using System.Data;

namespace Excel_Wordcloud
{
    internal class Functions
    {
        public DataTable DictToDatatable(Dictionary<string, int> dict, bool sort)
        {
            Dictionary<string, int> new_dict = new Dictionary<string, int>();
            if (sort)
            {
                List<KeyValuePair<string, int>> myList = dict.ToList();
                myList.Sort(
                delegate (KeyValuePair<string, int> pair1,
                KeyValuePair<string, int> pair2)
                {
                    return pair2.Value.CompareTo(pair1.Value);
                }
                );
                new_dict = myList.ToDictionary<KeyValuePair<string, int>, string, int>(pair => pair.Key, pair => pair.Value);
            }
            else
            {
                new_dict = dict.ToDictionary(entry => entry.Key, entry => entry.Value);
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Kelime");
            dt.Columns.Add("Tekrar Sayisi");
            foreach (var entry in new_dict)
            {
                DataRow row = dt.NewRow();
                row["Kelime"] = entry.Key;
                row["Tekrar Sayisi"] = entry.Value;
                dt.Rows.Add(row);
            }
            return dt;
        }
        public void ExportToExcel(DataTable tbl, string excelFilePath = null)
        {

            if (tbl == null || tbl.Columns.Count == 0)
                throw new Exception("ExportToExcel: Null or empty input table!");

            using (var package = new OfficeOpenXml.ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("WorksheetName");

                worksheet.Cells["A1"].LoadFromDataTable(tbl, true);

                if (!string.IsNullOrEmpty(excelFilePath))
                {
                    File.WriteAllBytes(excelFilePath, package.GetAsByteArray());
                    Console.WriteLine("Dosya başarıyla dışarı aktarıldı.");
                }
                else
                {
                    package.SaveAs(new FileInfo("TempExcelFile.xlsx"));
                    System.Diagnostics.Process.Start("TempExcelFile.xlsx");
                }
            }
            MessageBox.Show("Dosya başarıyla dışarı aktarıldı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void DataTableToCSV(DataTable dataTable, string filePath, string sep)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    writer.Write(column.ColumnName);
                    if (column.Ordinal < dataTable.Columns.Count - 1)
                    {
                        writer.Write(sep);
                    }
                }
                writer.WriteLine();

                foreach (DataRow row in dataTable.Rows)
                {
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        writer.Write(row[i]);
                        if (i < dataTable.Columns.Count - 1)
                        {
                            writer.Write(sep);
                        }
                    }
                    writer.WriteLine();
                }
            }
            MessageBox.Show("Dosya başarıyla dışarı aktarıldı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
