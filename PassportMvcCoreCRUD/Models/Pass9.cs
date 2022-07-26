using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassportMvcCoreCRUD.Models
{
    public class Pass9
    {
        [Key]
        public string file_num { get; set; }
        public string? en_file { get; set; }
        public string? sd_place { get; set; }
        public string? sd_date { get; set; }
        public string? sd_sign { get; set; }

        [NotMapped]
        public IFormFile sd_signDeatils { get; set; }
    }
}
