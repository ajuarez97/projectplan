ProjectPlan = function () {
    this.getUserInformationUrl = "Home/GetUserInformation";
}

ProjectPlan.prototype.bindEvents = function () {
    var self = this;

    $("#btn_findUser").on("click", self.getUserInformation);
}

ProjectPlan.prototype.getUserInformation = function () {
    var self = projectPlanInstance;
    var id = $("#select_Users").children(":selected").attr("id");

    $("#userTableBody").empty();

    if (id === "none") {
        return;
    }

    $.ajax({
        url: self.getUserInformationUrl,
        data: "userId=" + id,
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            if (result) {
                self.fillUserTable(result);
            }
        }
    });
}

ProjectPlan.prototype.fillUserTable = function (projects) {
    var self = projectPlanInstance;
    var dataLength = projects.length;
    var htmlContent = "";

    for (var i = 0; i < dataLength; i++) {
        var project = projects[i];

        htmlContent += "<tr>";
        htmlContent += "<th scope='row'>" + project.Id + "</th>";
        htmlContent += "<th>" + self.toDate(project.StartDate) + "</th>";
        htmlContent += "<th>" + project.TimeToStart < 0 ? "Started" : project.TimeToStart + "</th>";
        htmlContent += "<th>" + self.toDate(project.EndDate) + "</th>";
        htmlContent += "<th>" + project.Credits + "</th>";
        htmlContent += "<th>" + project.IsActive + "</th>";
        htmlContent += "</tr>";
    }

    $("#table_userInformation").append(htmlContent);
}

ProjectPlan.prototype.toDate = function (completeDate) {
    var completedDate = new Date(parseInt(completeDate.replace("/Date(", "").replace(")/")));
    return completedDate.toDateString();
}

$(function () {
    projectPlanInstance = new ProjectPlan;
    projectPlanInstance.bindEvents();
});
