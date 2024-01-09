$(function () {
    //For all paging
    $('mainContent').on('click', '.pager a', function () {
        var url = $(this).attr('href');

        $('mainContent').load(url);

        return false;
    })

})