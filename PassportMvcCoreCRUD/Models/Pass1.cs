using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassportMvcCoreCRUD.Models
{
    public class Pass1
    {
        [Key]
        public string file_num { get; set; }
        public string? applying { get; set; }
        public string? re_reason { get; set; }
        public string? ex_reason { get; set; }
        public string? other_reason1 { get; set; }
        public string? app_type { get; set; }
        public string? booklet_type { get; set; }
        public string? validity { get; set; }
        public string? photo { get; set; }

        [NotMapped]
        public IFormFile photoDeatils { get; set; }

        public string? Sign { get; set; }

        [NotMapped]
        public IFormFile SignDeatils { get; set; }
    }
}
