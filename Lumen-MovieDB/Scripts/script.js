function saveComments() {
    var username = $("#Username").val();
    var comment = $("#Comment").val();

    $.ajax({
        type: "post",
        url: "/Home/AddComment",
        data: JSON.stringify({ Username: username, Comment: comment }),
        contentType: "application/json; charset=utf-8",
        

        success: function (result) {
            $('#comment-container').append("<p>" + result.Username + "<br />" + result.Comment + "</p>");

            $("#Username").val("");
            $("#Comment").val("");

        }
    });

}