(function () {
    $("#fifthbtnid").click(function () {
        var Name = $("#Name").val();
        var fatherName = $("#FatherName").val();

        var jsonObject = {
            "Name": Name,
            "FatherName": fatherName
        };

        $.ajax({
            url: "/Home/WithSendingAndReceivinJsonObject",
            method: "Post",
            data: jsonObject
        }).done(function (user) {
            $("#sendRecvJsonMsg").text("Welcome " + user.Name + " " + user.FatherName)
                .addClass("text-success text-center");
        }).error(function () {
            $("#sendRecvJsonMsg").text("Ajax Call Failed")
                .addClass("text-danger text-center");
        });
    });
})();