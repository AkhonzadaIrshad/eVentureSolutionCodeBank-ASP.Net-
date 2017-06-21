(function() {
    $("#fourthbtnid").click(function() {
        var firstName = $("#fn").val();
        var lastName = $("#ln").val();

        var jsonObject = {
            "First Name": firstName,
            "Last Name":lastName
        };


        $.ajax({
            url: "/Home/WithJsonObject",
            method: "Post",
            data:jsonObject
        }).done(function () {
            $("#sendJsonResponseMsg").text("Ajax Call Success")
                .addClass("text-success text-center");

        }).error(function () {
            $("#sendJsonResponseMsg").text("Ajax Call Failed")
                .addClass("text-danger text-center");
        });
    });
})();