namespace Excel_Wordcloud
{
    partial class excelWordcloud
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(excelWordcloud));
            this.excelFilePathTXT = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gozatBTN = new CustomControls.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.sutunlarCMB = new CustomControls.RJControls.RJComboBox();
            this.analizBTN = new CustomControls.RJControls.RJButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.splitterTXT = new CustomControls.RJControls.RJTextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uzantiCMB = new System.Windows.Forms.ComboBox();
            this.dosyaIsımTXT = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gozat2BTN = new CustomControls.RJControls.RJButton();
            this.klasorIsımTXT = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // excelFilePathTXT
            // 
            this.excelFilePathTXT.BackColor = System.Drawing.SystemColors.Window;
            this.excelFilePathTXT.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.excelFilePathTXT.BorderFocusColor = System.Drawing.Color.Teal;
            this.excelFilePathTXT.BorderRadius = 10;
            this.excelFilePathTXT.BorderSize = 2;
            this.excelFilePathTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.excelFilePathTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.excelFilePathTXT.Location = new System.Drawing.Point(196, 18);
            this.excelFilePathTXT.Margin = new System.Windows.Forms.Padding(4);
            this.excelFilePathTXT.Multiline = false;
            this.excelFilePathTXT.Name = "excelFilePathTXT";
            this.excelFilePathTXT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.excelFilePathTXT.PasswordChar = false;
            this.excelFilePathTXT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.excelFilePathTXT.PlaceholderText = "";
            this.excelFilePathTXT.Size = new System.Drawing.Size(304, 31);
            this.excelFilePathTXT.TabIndex = 0;
            this.excelFilePathTXT.Texts = "";
            this.excelFilePathTXT.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Excel Dosyasını Seçiniz:";
            // 
            // gozatBTN
            // 
            this.gozatBTN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gozatBTN.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.gozatBTN.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.gozatBTN.BorderRadius = 10;
            this.gozatBTN.BorderSize = 0;
            this.gozatBTN.FlatAppearance.BorderSize = 0;
            this.gozatBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gozatBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gozatBTN.ForeColor = System.Drawing.Color.White;
            this.gozatBTN.Image = global::Excel_Wordcloud.Properties.Resources.icons8_browse_28__2_;
            this.gozatBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gozatBTN.Location = new System.Drawing.Point(508, 15);
            this.gozatBTN.Name = "gozatBTN";
            this.gozatBTN.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.gozatBTN.Size = new System.Drawing.Size(109, 36);
            this.gozatBTN.TabIndex = 2;
            this.gozatBTN.Text = "Gözat";
            this.gozatBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gozatBTN.TextColor = System.Drawing.Color.White;
            this.gozatBTN.UseVisualStyleBackColor = false;
            this.gozatBTN.Click += new System.EventHandler(this.gozatBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wordcloud Oluşturmak İstediğiniz Sütunu Seçiniz:";
            // 
            // sutunlarCMB
            // 
            this.sutunlarCMB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sutunlarCMB.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.sutunlarCMB.BorderSize = 1;
            this.sutunlarCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.sutunlarCMB.Enabled = false;
            this.sutunlarCMB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sutunlarCMB.ForeColor = System.Drawing.Color.DimGray;
            this.sutunlarCMB.IconColor = System.Drawing.Color.CornflowerBlue;
            this.sutunlarCMB.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.sutunlarCMB.ListTextColor = System.Drawing.Color.DimGray;
            this.sutunlarCMB.Location = new System.Drawing.Point(375, 72);
            this.sutunlarCMB.MinimumSize = new System.Drawing.Size(200, 30);
            this.sutunlarCMB.Name = "sutunlarCMB";
            this.sutunlarCMB.Padding = new System.Windows.Forms.Padding(1);
            this.sutunlarCMB.Size = new System.Drawing.Size(200, 30);
            this.sutunlarCMB.TabIndex = 6;
            this.sutunlarCMB.Texts = "";
            // 
            // analizBTN
            // 
            this.analizBTN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.analizBTN.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.analizBTN.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.analizBTN.BorderRadius = 10;
            this.analizBTN.BorderSize = 0;
            this.analizBTN.FlatAppearance.BorderSize = 0;
            this.analizBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analizBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.analizBTN.ForeColor = System.Drawing.Color.White;
            this.analizBTN.Image = ((System.Drawing.Image)(resources.GetObject("analizBTN.Image")));
            this.analizBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.analizBTN.Location = new System.Drawing.Point(256, 325);
            this.analizBTN.Name = "analizBTN";
            this.analizBTN.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.analizBTN.Size = new System.Drawing.Size(229, 38);
            this.analizBTN.TabIndex = 7;
            this.analizBTN.Text = "Analiz Et ve Dışarı Aktar";
            this.analizBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.analizBTN.TextColor = System.Drawing.Color.White;
            this.analizBTN.UseVisualStyleBackColor = false;
            this.analizBTN.Click += new System.EventHandler(this.analizBTN_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(6, 118);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(211, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Sütundaki Kelimeleri Böl:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // splitterTXT
            // 
            this.splitterTXT.BackColor = System.Drawing.SystemColors.Window;
            this.splitterTXT.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.splitterTXT.BorderFocusColor = System.Drawing.Color.Teal;
            this.splitterTXT.BorderRadius = 10;
            this.splitterTXT.BorderSize = 2;
            this.splitterTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.splitterTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitterTXT.Location = new System.Drawing.Point(220, 112);
            this.splitterTXT.Margin = new System.Windows.Forms.Padding(4);
            this.splitterTXT.Multiline = false;
            this.splitterTXT.Name = "splitterTXT";
            this.splitterTXT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.splitterTXT.PasswordChar = false;
            this.splitterTXT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.splitterTXT.PlaceholderText = "";
            this.splitterTXT.Size = new System.Drawing.Size(64, 31);
            this.splitterTXT.TabIndex = 9;
            this.splitterTXT.Texts = "";
            this.splitterTXT.UnderlinedStyle = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(6, 157);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(189, 21);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Degerlere Göre Sırala";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uzantiCMB);
            this.groupBox1.Controls.Add(this.dosyaIsımTXT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.gozat2BTN);
            this.groupBox1.Controls.Add(this.klasorIsımTXT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 106);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dışarı Aktar";
            // 
            // uzantiCMB
            // 
            this.uzantiCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uzantiCMB.Items.AddRange(new object[] {
            ".xlsx",
            ".csv"});
            this.uzantiCMB.Location = new System.Drawing.Point(445, 65);
            this.uzantiCMB.Margin = new System.Windows.Forms.Padding(23, 10, 15, 7);
            this.uzantiCMB.Name = "uzantiCMB";
            this.uzantiCMB.Size = new System.Drawing.Size(93, 23);
            this.uzantiCMB.TabIndex = 145;
            // 
            // dosyaIsımTXT
            // 
            this.dosyaIsımTXT.BackColor = System.Drawing.SystemColors.Window;
            this.dosyaIsımTXT.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.dosyaIsımTXT.BorderFocusColor = System.Drawing.Color.Teal;
            this.dosyaIsımTXT.BorderRadius = 10;
            this.dosyaIsımTXT.BorderSize = 2;
            this.dosyaIsımTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dosyaIsımTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dosyaIsımTXT.Location = new System.Drawing.Point(133, 57);
            this.dosyaIsımTXT.Margin = new System.Windows.Forms.Padding(4);
            this.dosyaIsımTXT.Multiline = false;
            this.dosyaIsımTXT.Name = "dosyaIsımTXT";
            this.dosyaIsımTXT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.dosyaIsımTXT.PasswordChar = false;
            this.dosyaIsımTXT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.dosyaIsımTXT.PlaceholderText = "";
            this.dosyaIsımTXT.Size = new System.Drawing.Size(304, 31);
            this.dosyaIsımTXT.TabIndex = 5;
            this.dosyaIsımTXT.Texts = "";
            this.dosyaIsımTXT.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dosya İsmi:";
            // 
            // gozat2BTN
            // 
            this.gozat2BTN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gozat2BTN.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.gozat2BTN.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.gozat2BTN.BorderRadius = 10;
            this.gozat2BTN.BorderSize = 0;
            this.gozat2BTN.FlatAppearance.BorderSize = 0;
            this.gozat2BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gozat2BTN.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gozat2BTN.ForeColor = System.Drawing.Color.White;
            this.gozat2BTN.Image = global::Excel_Wordcloud.Properties.Resources.icons8_browse_28__2_;
            this.gozat2BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gozat2BTN.Location = new System.Drawing.Point(445, 15);
            this.gozat2BTN.Name = "gozat2BTN";
            this.gozat2BTN.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.gozat2BTN.Size = new System.Drawing.Size(109, 36);
            this.gozat2BTN.TabIndex = 4;
            this.gozat2BTN.Text = "Gözat";
            this.gozat2BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gozat2BTN.TextColor = System.Drawing.Color.White;
            this.gozat2BTN.UseVisualStyleBackColor = false;
            this.gozat2BTN.Click += new System.EventHandler(this.gozat2BTN_Click);
            // 
            // klasorIsımTXT
            // 
            this.klasorIsımTXT.BackColor = System.Drawing.SystemColors.Window;
            this.klasorIsımTXT.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.klasorIsımTXT.BorderFocusColor = System.Drawing.Color.Teal;
            this.klasorIsımTXT.BorderRadius = 10;
            this.klasorIsımTXT.BorderSize = 2;
            this.klasorIsımTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.klasorIsımTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.klasorIsımTXT.Location = new System.Drawing.Point(133, 18);
            this.klasorIsımTXT.Margin = new System.Windows.Forms.Padding(4);
            this.klasorIsımTXT.Multiline = false;
            this.klasorIsımTXT.Name = "klasorIsımTXT";
            this.klasorIsımTXT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.klasorIsımTXT.PasswordChar = false;
            this.klasorIsımTXT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.klasorIsımTXT.PlaceholderText = "";
            this.klasorIsımTXT.Size = new System.Drawing.Size(304, 31);
            this.klasorIsımTXT.TabIndex = 2;
            this.klasorIsımTXT.Texts = "";
            this.klasorIsımTXT.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Klasör Seçiniz:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gozatBTN);
            this.groupBox2.Controls.Add(this.excelFilePathTXT);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.splitterTXT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.sutunlarCMB);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 193);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Girdi Ayarları";
            // 
            // excelWordcloud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.analizBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "excelWordcloud";
            this.Text = "Excel Wordcloud Oluşturma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJTextBox excelFilePathTXT;
        private Label label1;
        private CustomControls.RJControls.RJButton gozatBTN;
        private Label label3;
        private CustomControls.RJControls.RJComboBox sutunlarCMB;
        private CustomControls.RJControls.RJButton analizBTN;
        private CheckBox checkBox1;
        private CustomControls.RJControls.RJTextBox splitterTXT;
        private CheckBox checkBox2;
        private GroupBox groupBox1;
        private ComboBox uzantiCMB;
        private CustomControls.RJControls.RJTextBox dosyaIsımTXT;
        private Label label4;
        private CustomControls.RJControls.RJButton gozat2BTN;
        private CustomControls.RJControls.RJTextBox klasorIsımTXT;
        private Label label2;
        private GroupBox groupBox2;
    }
}