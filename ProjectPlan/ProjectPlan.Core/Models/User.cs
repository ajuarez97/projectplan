using System.Collections.Generic;

namespace ProjectPlan.Models
{
    public class User
    {
        public User()
        {
            Projects = new List<Project>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Project> Projects { get; set; }
    }
}