using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firma
{
    public partial class Form1 : Form
    {
        public mContext db;
        public static List<Firma> Firmy = new List<Firma>() ;
        public Form1()
        {
            InitializeComponent();
            
            db = new mContext();
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            UpdateFirmy();
            LoadFirmy();
        }

        private void LoadFirmy()
        {
            Firmy = db.Firmy.ToList();

        }
        private void UpdateFirmy()
        {
            
            listBox_Firmy.Items.Clear();
            var firmy = db.Firmy.OrderBy(b => b.NazwaFirmy);
            foreach(var f in firmy)
            {
                listBox_Firmy.Items.Add(f);
               
            }
        }
        private void button_Zapisz_Click(object sender, EventArgs e)
        {

            //do wyrzucenia MessageBox.Show("Dzialam " + tbName.Text);
            //listBox_Firmy.Items.Add(textBox_NazwaFirmy.Text);
            db.Add(new Firma {NazwaFirmy = textBox_NazwaFirmy.Text ,Przerwa = " ", Dane = textBox_Dane.Text });
            db.SaveChanges();
            UpdateFirmy();
        }

        private void listBox_Firmy_SelectedIndexChanged(object sender, EventArgs e)
        {
            long id = (long)(listBox_Firmy.SelectedItem as Firma).FirmaId;
            MessageBox.Show("ID FIRMY: " + id + " Element listy: " + listBox_Firmy.SelectedItem   );
        }

        private void UpdatePracownika()
        {

            //listBox_Pracownicy.Items.Clear();
            var pracownicy = db.Pracownicy.Where(b => b.FirmaId == Firmy[comboBox_ListaFirm.SelectedIndex].FirmaId).ToList();
            listBox_Pracownicy.DataSource = pracownicy;

        }
        private void button_ZapiszPracownika_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox_ListaFirm.SelectedIndex.ToString());
             long id = Firmy[comboBox_ListaFirm.SelectedIndex].FirmaId;
             db.Add(new Pracownik {FirmaId = id, ImiePracownika = textBox_ImiePracownika.Text, Przerwa = " ", NazwiskoPracownika = textBox_NazwiskoPracownik.Text  });
             db.SaveChanges();
             UpdatePracownika();
            
        }

        private void Glowna_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(Glowna.SelectedIndex == 1)
            {
                LoadFirmy();
                comboBox_ListaFirm.DataSource = Firmy;

            }
        }

        private void button_FirmaDelete_Click(object sender, EventArgs e)
        {
            Firma f = listBox_Firmy.SelectedItem as Firma;
            f.NazwaFirmy = textBox_NazwaFirmy.Text;
            f.Dane = textBox_Dane.Text;
            db.SaveChanges();
            UpdateFirmy();
        }

        private void button_EdytujPracownika_Click(object sender, EventArgs e)
        {
            Pracownik p = listBox_Pracownicy.SelectedItem as Pracownik;
            p.ImiePracownika = textBox_ImiePracownika.Text;
            p.NazwiskoPracownika = textBox_NazwiskoPracownik.Text;
            p.FirmaId = Firmy[comboBox_ListaFirm.SelectedIndex].FirmaId; 
            db.SaveChanges();
            UpdatePracownika();
        }

        private void button_DelFirma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuwanie firmy  " , Convert.ToString(listBox_Firmy.SelectedItem) ) ;
            Firma f = listBox_Firmy.SelectedItem as Firma;
            db.Remove(f);
            db.SaveChanges();
            UpdateFirmy();
        }

        private void button_PracownikDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuwanie pracownika  ", Convert.ToString(listBox_Firmy.SelectedItem));
            Pracownik p = listBox_Pracownicy.SelectedItem as Pracownik;
            db.Remove(p);
            db.SaveChanges();
            UpdateFirmy();
            UpdatePracownika();
        }

        
        private void button_Search_Click(object sender, EventArgs e)
        {
            using (var ctx = new mContext())
            {
                string abc = textBox_ImiePracownika.Text;
                var listapracownikow = ctx.Pracownicy.Where(s => s.ImiePracownika == abc).ToList();
                listBox_Pracownicy.DataSource = listapracownikow;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new mContext())
            {
                string abc = textBox_NazwiskoPracownik.Text;
                var listapracownikow = ctx.Pracownicy.Where(s => s.NazwiskoPracownika == abc).ToList();
                listBox_Pracownicy.DataSource = listapracownikow;
            }
        }

        private void button_szukajfirma_Click(object sender, EventArgs e)
        {
            using (var ctx = new mContext())
            {
                long abc = Firmy[comboBox_ListaFirm.SelectedIndex].FirmaId;
                var listapracownikow = ctx.Pracownicy.Where(s => s.FirmaId == abc).ToList();
                listBox_Pracownicy.DataSource = listapracownikow;
            }
        }
    }
}
