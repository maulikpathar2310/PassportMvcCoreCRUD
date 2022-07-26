using System.ComponentModel.DataAnnotations;

namespace PassportMvcCoreCRUD.Models
{
    public class Pass6
    {
        [Key]
        public string file_num { get; set; }
        public string? certi_no { get; set; }
        public string? issue_date { get; set; }
        public string? expiry_date { get; set; }
        public string? issue_place { get; set; }
        public string? not_issued_pass { get; set; }
        public string? file_no { get; set; }
        public string? month_year { get; set; }
        public string? pass_office { get; set; }
    }
}
