function saveComment() {
    var username = $("#Username").val();
    var comment = $("#Comment").val();

    $.ajax({
        type: "post",
        url: "/Home/AddComment",
        data: JSON.stringify({ Username: username, Comment: comment }),
        contentType: "application/json",

        success: function (result) {
            $("#container").append("<b>" + result.Username + " : " +"</b><span>" + result.Comment + "</span><br />");

            //clean up the form for next input
            $("#Username").val("");
            $("#Comment").val("");
        }
    })
}