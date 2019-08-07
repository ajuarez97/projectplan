using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProjectPlan.Models;
using UserEntities = ProjectPlan.Entities.User;

namespace ProjectPlan.Core.Extensions
{
    public static class UserExtension
    {
        public static List<User> ToModel(this DbSet<UserEntities> userEntities)
        {
            return userEntities.Select(userEntity => new User
            {
                FirstName = userEntity.FirstName,
                LastName = userEntity.LastName,
                Id = userEntity.Id
            }).ToList();
        }
    }
}