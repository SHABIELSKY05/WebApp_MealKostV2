using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_MealKostV2.Models
{

    public class tbl_menu
    {
        [Key]
        public string pid { get; set; }
        public string jenis { get; set; }
        public string judul { get; set; }
        public string nama_file_gambar { get; set; }
        public int total_kalori { get; set; }
        public int karbohidrat { get; set; }
        public int lemak { get; set; }
        public int protein { get; set; }
        public string bahan { get; set; }
        public string cara_membuat { get; set; }
    }

}
