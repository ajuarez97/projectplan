using System;
using System.Collections.Generic;
using ProjectPlan.Core.Enums;
using ProjectPlan.Entities;
using Project = ProjectPlan.Models.Project;
using User = ProjectPlan.Models.User;

namespace ProjectPlan.Core.Extensions
{
    public static class ProjectExtension
    {
        public static List<Project> ToModel(this List<UserProject> userProjectEntity)
        {
            var userModel = new User();

            foreach (var userProject in userProjectEntity)
            {
                var currentDate = DateTime.Now;
                var startDate = userProject.Project.StartDate;
                var endDate = userProject.Project.EndDate;
                var assignedDate = userProject.AssignedDate;

                var projectModel = new Project
                {
                    Id = userProject.ProjectId,
                    StartDate = startDate,
                    EndDate = endDate,
                    AssignedDate = userProject.AssignedDate,
                    Credits = userProject.Project.Credits,
                    IsActive = currentDate > endDate && currentDate < assignedDate ? StatusEnum.Active : StatusEnum.Inactive,
                    TimeToStart = (assignedDate - startDate).Days
                };

                userModel.Projects.Add(projectModel);
            }

            return userModel.Projects;
        }
    }
}