using OfficeOpenXml;
using System.Data;

namespace Excel_Wordcloud
{
    public partial class excelWordcloud : Form
    {
        private bool isUpluoded = false;
        Dictionary<string, int> wordcloud = new Dictionary<string, int>();
        public excelWordcloud()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void gozatBTN_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                    ofd.Title = "Bir excel dosyasý seçiniz.";
                    if (ofd.ShowDialog() == DialogResult.OK)
                        excelFilePathTXT.Texts = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Dosya Eklenirken Hata Oluþtu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isUpluoded = false;
            }
            try
            {
                sutunlarCMB.Items.Clear();
                using (ExcelPackage paket = new ExcelPackage(new FileInfo(excelFilePathTXT.Texts)))
                {
                    ExcelWorksheet sheet = paket.Workbook.Worksheets[0];
                    for (int i = 1; i <= sheet.Dimension.End.Column; i++)
                    {
                        sutunlarCMB.Items.Add(sheet.Cells[1, i].Text);
                    }
                }
                if (sutunlarCMB.Items.Count != 0)
                    isUpluoded = true;
                else
                {
                    MessageBox.Show("Yüklediðiniz excelde sütun bulunmamaktadýr. Lütfen tekrar içeri aktarýnýz.", "Excel Sütun Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isUpluoded = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Dosya Eklenirken Hata Oluþtu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isUpluoded = false;
            }
            if (isUpluoded)
            {
                MessageBox.Show("Dosya baþarýyla içeri aktarýldý!", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sutunlarCMB.Enabled = true;
            }

        }

        private async void analizBTN_Click(object sender, EventArgs e)
        {
            if (isUpluoded && excelFilePathTXT.Texts != "")
            {
                int column = sutunlarCMB.SelectedIndex + 1;
                Functions func = new Functions();
                await Task.Run(async () =>
                {
                    try
                    {
                        using (ExcelPackage package = new ExcelPackage(new FileInfo(excelFilePathTXT.Texts)))
                        {
                            ExcelWorksheet sheet = package.Workbook.Worksheets[0];
                            for (int row = sheet.Dimension.Start.Row + 1; row <= sheet.Dimension.End.Row; row++)
                            {
                                string cell_value = sheet.Cells[row, column].Text;
                                string[] values;
                                if (checkBox1.Checked)
                                {
                                    values = cell_value.Split(' ');
                                }
                                else
                                    values = cell_value.Select(c => c.ToString()).ToArray();
                                foreach (string value in values)
                                {
                                    if (!wordcloud.ContainsKey(value))
                                        wordcloud[value] = 1;
                                    else
                                        wordcloud[value]++;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Analiz Sýrasýnda Bir Hata Oluþtu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });

                await Task.Run(async () =>
                {
                    try
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (dosyaIsýmTXT.Texts != "" && klasorIsýmTXT.Texts != "")
                            {
                                DataTable dt = func.DictToDatatable(wordcloud, checkBox2.Checked);
                                if (uzantiCMB.SelectedIndex == 0)
                                    func.ExportToExcel(dt, klasorIsýmTXT.Texts + @"\" + dosyaIsýmTXT.Texts + uzantiCMB.Text);
                                else
                                    func.DataTableToCSV(dt, klasorIsýmTXT.Texts + @"\" + dosyaIsýmTXT.Texts + uzantiCMB.Text, ";");
                            }
                            else
                                MessageBox.Show("Lütfen çýktý ayarlarýnýzý yapýnýz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        });


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Çýktý Dýþarý Aktarýlýrken Bir Hata Oluþtu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });

            }
            else
                MessageBox.Show("Lütfen excel dosyasýnný seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void gozat2BTN_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog diag = new FolderBrowserDialog();
                if (diag.ShowDialog() == DialogResult.OK)
                {
                    klasorIsýmTXT.Texts = diag.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}