using System.Text.Json.Serialization;

namespace Job_App_Rest.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string EmploymentType { get; set; }
        public string Location { get; set; }
        public string MinimumExperience { get; set; }
        public decimal Compensation { get; set; }
        public string Department { get; set; }
        //many to one
        
        //[JsonIgnore]
        public Company Company { get; set; }


        

    }
}
