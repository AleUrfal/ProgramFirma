
namespace Firma
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Glowna = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.button_DelFirma = new System.Windows.Forms.Button();
            this.button_FirmaDelete = new System.Windows.Forms.Button();
            this.textBox_Dane = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Firmy = new System.Windows.Forms.ListBox();
            this.button_Zapisz = new System.Windows.Forms.Button();
            this.textBox_NazwaFirmy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.button_szukajfirma = new System.Windows.Forms.Button();
            this.button_nazw = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_PracownikDelete = new System.Windows.Forms.Button();
            this.button_EdytujPracownika = new System.Windows.Forms.Button();
            this.button_ZapiszPracownika = new System.Windows.Forms.Button();
            this.comboBox_ListaFirm = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_NazwiskoPracownik = new System.Windows.Forms.TextBox();
            this.textBox_ImiePracownika = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox_Pracownicy = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Button();
            this.Glowna.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Glowna
            // 
            this.Glowna.Controls.Add(this.tabPage1);
            this.Glowna.Controls.Add(this.tabPage2);
            this.Glowna.Location = new System.Drawing.Point(12, 12);
            this.Glowna.Name = "Glowna";
            this.Glowna.SelectedIndex = 0;
            this.Glowna.Size = new System.Drawing.Size(776, 426);
            this.Glowna.TabIndex = 0;
            this.Glowna.SelectedIndexChanged += new System.EventHandler(this.Glowna_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Chartreuse;
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.button_DelFirma);
            this.tabPage1.Controls.Add(this.button_FirmaDelete);
            this.tabPage1.Controls.Add(this.textBox_Dane);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listBox_Firmy);
            this.tabPage1.Controls.Add(this.button_Zapisz);
            this.tabPage1.Controls.Add(this.textBox_NazwaFirmy);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Firmy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(379, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Nazwa Firmy | Dane";
            // 
            // button_DelFirma
            // 
            this.button_DelFirma.Location = new System.Drawing.Point(60, 240);
            this.button_DelFirma.Name = "button_DelFirma";
            this.button_DelFirma.Size = new System.Drawing.Size(200, 23);
            this.button_DelFirma.TabIndex = 9;
            this.button_DelFirma.Text = "Usuń";
            this.button_DelFirma.UseVisualStyleBackColor = true;
            this.button_DelFirma.Click += new System.EventHandler(this.button_DelFirma_Click);
            // 
            // button_FirmaDelete
            // 
            this.button_FirmaDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_FirmaDelete.Location = new System.Drawing.Point(174, 191);
            this.button_FirmaDelete.Name = "button_FirmaDelete";
            this.button_FirmaDelete.Size = new System.Drawing.Size(87, 43);
            this.button_FirmaDelete.TabIndex = 8;
            this.button_FirmaDelete.Text = "Edytuj";
            this.button_FirmaDelete.UseVisualStyleBackColor = true;
            this.button_FirmaDelete.Click += new System.EventHandler(this.button_FirmaDelete_Click);
            // 
            // textBox_Dane
            // 
            this.textBox_Dane.Location = new System.Drawing.Point(60, 119);
            this.textBox_Dane.Name = "textBox_Dane";
            this.textBox_Dane.Size = new System.Drawing.Size(200, 23);
            this.textBox_Dane.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dane firmy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(379, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Firmy w bazie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-2242, -563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwa Firmy";
            // 
            // listBox_Firmy
            // 
            this.listBox_Firmy.FormattingEnabled = true;
            this.listBox_Firmy.ItemHeight = 15;
            this.listBox_Firmy.Items.AddRange(new object[] {
            "abc",
            "cba"});
            this.listBox_Firmy.Location = new System.Drawing.Point(379, 79);
            this.listBox_Firmy.Name = "listBox_Firmy";
            this.listBox_Firmy.Size = new System.Drawing.Size(367, 274);
            this.listBox_Firmy.TabIndex = 3;
            this.listBox_Firmy.SelectedIndexChanged += new System.EventHandler(this.listBox_Firmy_SelectedIndexChanged);
            // 
            // button_Zapisz
            // 
            this.button_Zapisz.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Zapisz.Location = new System.Drawing.Point(60, 191);
            this.button_Zapisz.Name = "button_Zapisz";
            this.button_Zapisz.Size = new System.Drawing.Size(98, 43);
            this.button_Zapisz.TabIndex = 2;
            this.button_Zapisz.Text = "Zapisz";
            this.button_Zapisz.UseVisualStyleBackColor = true;
            this.button_Zapisz.Click += new System.EventHandler(this.button_Zapisz_Click);
            // 
            // textBox_NazwaFirmy
            // 
            this.textBox_NazwaFirmy.Location = new System.Drawing.Point(60, 64);
            this.textBox_NazwaFirmy.Name = "textBox_NazwaFirmy";
            this.textBox_NazwaFirmy.Size = new System.Drawing.Size(200, 23);
            this.textBox_NazwaFirmy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa Firmy";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Firebrick;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button_szukajfirma);
            this.tabPage2.Controls.Add(this.button_nazw);
            this.tabPage2.Controls.Add(this.button_Search);
            this.tabPage2.Controls.Add(this.button_PracownikDelete);
            this.tabPage2.Controls.Add(this.button_EdytujPracownika);
            this.tabPage2.Controls.Add(this.button_ZapiszPracownika);
            this.tabPage2.Controls.Add(this.comboBox_ListaFirm);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox_NazwiskoPracownik);
            this.tabPage2.Controls.Add(this.textBox_ImiePracownika);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.listBox_Pracownicy);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pracownicy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(433, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Id | Imie i nazwisko";
            // 
            // button_szukajfirma
            // 
            this.button_szukajfirma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_szukajfirma.Location = new System.Drawing.Point(202, 150);
            this.button_szukajfirma.Name = "button_szukajfirma";
            this.button_szukajfirma.Size = new System.Drawing.Size(106, 23);
            this.button_szukajfirma.TabIndex = 13;
            this.button_szukajfirma.Text = "Szukaj";
            this.button_szukajfirma.UseVisualStyleBackColor = true;
            this.button_szukajfirma.Click += new System.EventHandler(this.button_szukajfirma_Click);
            // 
            // button_nazw
            // 
            this.button_nazw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_nazw.Location = new System.Drawing.Point(202, 106);
            this.button_nazw.Name = "button_nazw";
            this.button_nazw.Size = new System.Drawing.Size(106, 23);
            this.button_nazw.TabIndex = 12;
            this.button_nazw.Text = "Szukaj";
            this.button_nazw.UseVisualStyleBackColor = true;
            this.button_nazw.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Search.Location = new System.Drawing.Point(202, 60);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(106, 23);
            this.button_Search.TabIndex = 11;
            this.button_Search.Text = "Szukaj";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_PracownikDelete
            // 
            this.button_PracownikDelete.Location = new System.Drawing.Point(36, 271);
            this.button_PracownikDelete.Name = "button_PracownikDelete";
            this.button_PracownikDelete.Size = new System.Drawing.Size(169, 23);
            this.button_PracownikDelete.TabIndex = 10;
            this.button_PracownikDelete.Text = "Usuń";
            this.button_PracownikDelete.UseVisualStyleBackColor = true;
            this.button_PracownikDelete.Click += new System.EventHandler(this.button_PracownikDelete_Click);
            // 
            // button_EdytujPracownika
            // 
            this.button_EdytujPracownika.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_EdytujPracownika.Location = new System.Drawing.Point(128, 229);
            this.button_EdytujPracownika.Name = "button_EdytujPracownika";
            this.button_EdytujPracownika.Size = new System.Drawing.Size(77, 36);
            this.button_EdytujPracownika.TabIndex = 9;
            this.button_EdytujPracownika.Text = "Edytuj";
            this.button_EdytujPracownika.UseVisualStyleBackColor = true;
            this.button_EdytujPracownika.Click += new System.EventHandler(this.button_EdytujPracownika_Click);
            // 
            // button_ZapiszPracownika
            // 
            this.button_ZapiszPracownika.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_ZapiszPracownika.Location = new System.Drawing.Point(36, 229);
            this.button_ZapiszPracownika.Name = "button_ZapiszPracownika";
            this.button_ZapiszPracownika.Size = new System.Drawing.Size(86, 36);
            this.button_ZapiszPracownika.TabIndex = 8;
            this.button_ZapiszPracownika.Text = "Zapisz";
            this.button_ZapiszPracownika.UseVisualStyleBackColor = true;
            this.button_ZapiszPracownika.Click += new System.EventHandler(this.button_ZapiszPracownika_Click);
            // 
            // comboBox_ListaFirm
            // 
            this.comboBox_ListaFirm.FormattingEnabled = true;
            this.comboBox_ListaFirm.Location = new System.Drawing.Point(36, 150);
            this.comboBox_ListaFirm.Name = "comboBox_ListaFirm";
            this.comboBox_ListaFirm.Size = new System.Drawing.Size(160, 23);
            this.comboBox_ListaFirm.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(36, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Firma";
            // 
            // textBox_NazwiskoPracownik
            // 
            this.textBox_NazwiskoPracownik.Location = new System.Drawing.Point(36, 106);
            this.textBox_NazwiskoPracownik.Name = "textBox_NazwiskoPracownik";
            this.textBox_NazwiskoPracownik.Size = new System.Drawing.Size(160, 23);
            this.textBox_NazwiskoPracownik.TabIndex = 5;
            // 
            // textBox_ImiePracownika
            // 
            this.textBox_ImiePracownika.Location = new System.Drawing.Point(36, 61);
            this.textBox_ImiePracownika.Name = "textBox_ImiePracownika";
            this.textBox_ImiePracownika.Size = new System.Drawing.Size(160, 23);
            this.textBox_ImiePracownika.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(36, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nazwisko";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(36, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Imie";
            // 
            // listBox_Pracownicy
            // 
            this.listBox_Pracownicy.FormattingEnabled = true;
            this.listBox_Pracownicy.ItemHeight = 15;
            this.listBox_Pracownicy.Location = new System.Drawing.Point(433, 60);
            this.listBox_Pracownicy.Name = "listBox_Pracownicy";
            this.listBox_Pracownicy.Size = new System.Drawing.Size(276, 289);
            this.listBox_Pracownicy.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(482, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "PRACOWNICY";
            // 
            // a
            // 
            this.a.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a.Location = new System.Drawing.Point(202, 150);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(106, 23);
            this.a.TabIndex = 13;
            this.a.Text = "Szukaj";
            this.a.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Glowna);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Firma";
            this.Glowna.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Glowna;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Firmy;
        private System.Windows.Forms.Button button_Zapisz;
        private System.Windows.Forms.TextBox textBox_NazwaFirmy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Dane;
        private System.Windows.Forms.Label label4;     
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox_ListaFirm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_NazwiskoPracownik;
        private System.Windows.Forms.TextBox textBox_ImiePracownika;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox_Pracownicy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_ZapiszPracownika;
        private System.Windows.Forms.Button button_FirmaDelete;
        private System.Windows.Forms.Button button_EdytujPracownika;
        private System.Windows.Forms.Button button_DelFirma;
        private System.Windows.Forms.Button button_PracownikDelete;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_nazw;
        private System.Windows.Forms.Button button_szukajfirma;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

