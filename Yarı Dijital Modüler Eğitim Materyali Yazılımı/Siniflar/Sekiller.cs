using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı.Siniflar
{
    public class Sekiller
    {
        [Key]
        public int SekilId { get; set; }
        public string SekilUrl{ get; set; }
    }
}
