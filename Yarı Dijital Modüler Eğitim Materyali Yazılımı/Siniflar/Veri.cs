using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı.Siniflar
{
    public class Veri
    {
        [Key]
        public int Id { get; set; }
        public int VeriSetId { get; set; }
        public string SekilVerisi { get; set; }
        public string  BaglantıVerisi { get; set; }
        public string  FotografVerisi { get; set; }
        public string  SesVerisi { get; set; }
        public string  YaziVerisi { get; set; }
        public string  VideoVerisi { get; set; }
      
    }
}
