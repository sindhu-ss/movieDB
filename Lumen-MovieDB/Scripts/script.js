function saveComment() {
    var username = $("#Username").val();
    var comment = $("#Comment").val();

    $.ajax({
        type: "post",
        url: "/Home/AddComment",
        data: JSON.stringify({ Username: username, Comment: comment }),
        contentType: "application/json",

        success: function (result) {
            console.log(result);

        }
    })
}