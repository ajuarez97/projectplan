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

    if (id === "none")
        return;

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
    var dataLength = projects.length;
    var htmlContent = "<tbody>";

    for (var i = 0; i < dataLength; i++) {
        var project = projects[i];

        htmlContent += " <tr >";
        htmlContent += "<th scope='row'>" + project.Id + "</th>";
        htmlContent += "<th>" + project.StartDate + "</th>";
        htmlContent += "<th>" + project.TimeToStart + "</th>";
        htmlContent += "<th>" + project.EndDate + "</th>";
        htmlContent += "<th>" + project.Credits + "</th>";
        htmlContent += "<th>" + project.IsActive + "</th>";
        htmlContent += " </tr >";
    }

    htmlContent +=  "</tbody>";

    $("#table_userInformation").append(htmlContent);
}

$(function () {
    projectPlanInstance = new ProjectPlan;
    projectPlanInstance.bindEvents();
});
