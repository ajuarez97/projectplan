using System.Collections.Generic;
using System.Linq;
using ProjectPlan.Core.Extensions;
using ProjectPlan.Entities;
using Project = ProjectPlan.Models.Project;
using User = ProjectPlan.Models.User;

namespace ProjectPlan.Core
{
    public static class Mapper
    {
        public static List<User> GetUsers()
        {
            using (var context = new ProjectPlanEntities())
            {
                return context.Users.ToModel();
            }
        }

        public static IEnumerable<Project> GetProjectsByUserId(int userId)
        {
            using (var context = new ProjectPlanEntities())
            {
                return context.UserProjects.Where(x => x.UserId == userId).ToList().ToModel();
            }
        }
    }
}
