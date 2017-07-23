(function () {
    $("#thirdbtnid").click(function () {
        var firstName = $("#firstName").val();
        var lastName = $("#lastName").val();
        $.ajax({
            url: "/Home/WithQueryString?stringOne=" + firstName + "&stringTwo=" + lastName,
            method: "Post"
        }).done(function () {
            $("#queryStringResponseMsg").text("Ajax Call Success")
                .addClass("text-success text-center");
        }).error(function () {
            $("#queryStringResponseMsg").text("Ajax Call Failed")
                .addClass("text-danger text-center");
        });
    });
})();