using System.ComponentModel.DataAnnotations;

namespace PassportMvcCoreCRUD.Models
{
    public class Pass4
    {
        [Key]
        public string file_num { get; set; }
        public string street { get; set; }
        public string town { get; set; }
        public string district { get; set; }
        public string police_station { get; set; }
        public string state { get; set; }
        public string pin { get; set; }
        public string mobile_no { get; set; }
        public string telephone_number { get; set; }
        public string email { get; set; }
        public string same_add { get; set; }
    }
}
