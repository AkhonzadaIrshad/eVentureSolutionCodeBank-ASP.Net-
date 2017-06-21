(function() {
    $("#firstbtnid").click(function() {

        $.ajax({
            url: "/Home/SimpleCall",
            method: "Get"
        }).done(function () {
            $("#simpleCallResponseMsg").text("Ajax Call Success")
                                       .addClass("text-success text-center");
        }).error(function () {
            $("#simpleCallResponseMsg").text("Ajax Call Failed")
                                       .addClass("text-danger text-center");
        });

    });
})();
