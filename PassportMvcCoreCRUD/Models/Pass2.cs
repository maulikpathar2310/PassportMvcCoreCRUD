using System.ComponentModel.DataAnnotations;

namespace PassportMvcCoreCRUD.Models
{
    public class Pass2
    {
        [Key]
        public string file_num { get; set; }
        public string? name { get; set; }
        public string? middle_name { get; set; }
        public string? surname { get; set; }
        public string? other_name { get; set; }
        public string? changes_name { get; set; }

        public string? birth_date { get; set; }
        public string? birth_place { get; set; }
        public string? birth_district { get; set; }
        public string? birth_state { get; set; }
        public string? country { get; set; }
        public string? country_select { get; set; }
        public string? gender { get; set; }
        public string? marital_status { get; set; }
        public string? citizenship { get; set; }
        public string? pan_id { get; set; }
        public string? voter_id { get; set; }
        public string? emp_type { get; set; }
        public string? emp_org_name { get; set; }
        public string? gov_servant { get; set; }
        public string? edu_qualification { get; set; }
        public string? non_ecr { get; set; }
        public string? mark_select { get; set; }
        public string? aadhar { get; set; }
    }
}
