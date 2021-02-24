using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firma
{
    public class mContext : DbContext
    {
        
        public DbSet<Firma> Firmy { get; set; }
        public DbSet<Pracownik> Pracownicy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=BazaPracownikow.db");
    }
    public class Firma
    {
        
        public long FirmaId { get; set; }
        public string NazwaFirmy { get; set; }
        public string Dane { get; set; }
        public string Przerwa { get; set; }
        //public List<Pracownik> Pracownik { get; set; } = new List<Pracownik>();
        public override string ToString()
        {
            return NazwaFirmy + " " +Dane;
        }
    }

    public class Pracownik
    {
        
        public long PracownikId { get; set; }
        public string ImiePracownika { get; set; }
        public string NazwiskoPracownika { get; set; }

        public long FirmaId { get; set; }
        public Firma NazwaFirmy { get; set; }

        public string Przerwa { get; set; }
       
        public override string ToString()
        {
            return PracownikId + " " + ImiePracownika + " " + NazwiskoPracownika ;
        }
    }
}
