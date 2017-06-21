(function() {

    $("#secondbtnid").click(function() {

        var selectedValue = $("#routParameterList").select("option:selected").val();
        $.ajax({
            url: "/Home/WithRouteParameters/" + selectedValue,
            method:"Get"
        }).done(function () {
            $("#routParametersCallResponseMsg").text("Ajax Call Success")
                                               .addClass("text-success text-center");
            
        }).error(function() {
            $("#routParametersCallResponseMsg").text("Ajax Call Failed")
                                               .addClass("text-danger text-center");
        });
    });
})();