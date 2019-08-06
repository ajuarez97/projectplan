ProjectPlan = function () {
    this.routes.getUserInformation = "HomeController/GetUserInformation";

    this.bindEvents();
}

ProjectPlan.prototype.bindEvents = function () {
    var self = this;

    $("#btn_findUser").click(self.getUserInformation);
}

ProjectPlan.prototype.getUserInformation = function () {
    var self = this;

    $.ajax({
        url: self.routes.getUserInformation,
        data: "{ userId : '" + id + "' }",
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
    var htmlContent = "<tbody>" + "<tr>";

    for (var i = 0; i < dataLength; i++) {
        var project = projects[i];

        htmlContent += "<th scope='row'>" + project.Id + "</th>";
        htmlContent += "<th>" + project.StartDate + "</th>";
        htmlContent += "<th>" + project.TimeToStart + "</th>";
        htmlContent += "<th>" + project.EndDate + "</th>";
        htmlContent += "<th>" + project.Credits + "</th>";
        htmlContent += "<th>" + project.Status + "</th>";
    }

    htmlContent += " </tr >" + "</tbody>";

    $("#table_userInformation").append(htmlContent);
}
