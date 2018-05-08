function searchFailed() {
    $("#searchresults").html("Search failed.Please try again.");
}

$(function () {
    $(".RemoveLink").click(function () {
        var id = $(this).attr("data-id");
        $.post("/Order/Cancel", { "id": id }, function (data){
            $("#update-message").text(data.Message);
            $("item-count-" + data.DeleteId).text(data.ItemCount);

            if (data.ItemCount < 1)
                $("#record-" + data.DeleteId).fadeOut();
        });
    });
});

