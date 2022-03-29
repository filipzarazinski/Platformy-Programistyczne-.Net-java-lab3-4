using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4
{
    public class info_walut
    {
        public string DataDb { get; set; }
        public string WartoscDb { get; set; }

    }

    public class kantor : DbContext
    { 
        public virtual DbSet<info_walut> Baza_Danych { get; set; }
    }

    
}
