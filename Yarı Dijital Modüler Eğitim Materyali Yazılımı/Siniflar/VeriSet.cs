﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı.Siniflar
{
     public class VeriSet
    {
        [Key]
        public int Id { get; set; }
        public string SetAdı{ get; set; }

        public bool Aktiflik { get; set; }
    }
}
