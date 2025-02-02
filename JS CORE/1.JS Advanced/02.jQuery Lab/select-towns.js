function attachEvents() {
    $('#items').on('click', 'li', function () {
        let li = $(this);
        if (li.attr('data-selected')) {
            li.removeAttr('data-selected');
            li.css('background', '');
        } else {
            li.attr('data-selected', 'true');
            li.css('background', '#DDD');
        }
    });
    $('#showTownsButton').on('click',function () {
        let selected =  $('li[data-selected="true"]').toArray().map(x=>x.textContent).join(", ");
        $("#selectedTowns").text("Selected towns: " + selected);
    })
}
