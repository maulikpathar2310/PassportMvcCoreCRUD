using System.ComponentModel.DataAnnotations;

namespace PassportMvcCoreCRUD.Models
{
    public class Pass8
    {
        [Key]
        public string file_num { get; set; }
        public string fee { get; set; }
        public string dd_num { get; set; }
        public string dd_issue_date { get; set; }
        public string dd_exp_date { get; set; }
        public string bank_name { get; set; }
        public string branch { get; set; }
    }
}
