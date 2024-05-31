using System.Text.Json.Serialization;

namespace Job_App_Rest.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }

        //one to many
        [JsonIgnore]
        public ICollection<Job> Jobs { get; set; }
    }
}
