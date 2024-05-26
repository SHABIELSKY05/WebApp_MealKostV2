using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_MealKostV2.Models
{
    public class tbl_paket_menu
    {
        [Key]
        public string pid { get; set; }
        public int nomor_paket { get; set; }
        public int total_porsi { get; set; }
        public string sarapan { get; set; }
        public int kalori_sarapan { get; set; }
        public string? gambar_sarapan { get; set; }
        public string makan_siang { get; set; }
        public int kalori_makan_siang { get; set; }
        public string? gambar_makan_siang { get; set; }
        public string makan_malam { get; set; }
        public int kalori_makan_malam { get; set; }
        public string? gambar_makan_malam { get; set; }
        public string? snack1 { get; set; }
        public int? kalori_snack1 { get; set; }
        public string? gambar_snack1 { get; set; }
        public string? snack2 { get; set; }
        public int? kalori_snack2 { get; set; }
        public string? gambar_snack2 { get; set; }
        public int total_kalori { get; set; }
    }
}


      