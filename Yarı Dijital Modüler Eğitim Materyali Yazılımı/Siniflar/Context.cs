using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Veri> Veris { get; set; }
    }
}
