using System.ComponentModel.DataAnnotations;

namespace PassportMvcCoreCRUD.Models
{
    public class Pass5
    {
        [Key]
        public string file_num { get; set; }
        public string? em_name { get; set; }
        public string? em_address { get; set; }
        public string? em_email { get; set; }
    }
}
