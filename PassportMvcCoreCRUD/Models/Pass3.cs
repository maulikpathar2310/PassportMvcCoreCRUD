using System.ComponentModel.DataAnnotations;

namespace PassportMvcCoreCRUD.Models
{
    public class Pass3
    {
        [Key]
        public string file_num { get; set; }
        public string father_name { get; set; }
        public string father_middle_name { get; set; }
        public string father_surname { get; set; }
        public string mother_name { get; set; }
        public string mother_middle_name { get; set; }
        public string mother_surname { get; set; }
        public string guardian_name { get; set; }
        public string guardian_middle_name { get; set; }
        public string guardian_surname { get; set; }
        public string spouse_name { get; set; }
        public string spouse_middle_name { get; set; }
        public string spouse_surname { get; set; }
        public string pass_file { get; set; }
        public string father_passport_no { get; set; }
        public string father_nationality { get; set; }
        public string mother_passport_no { get; set; }
        public string mother_nationality { get; set; }
    }
}
