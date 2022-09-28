$(document).ready(function () {
    $('.ActiveCheck').change(function () {
        var self = $(this);
        var value = self.prop('checked');
        var id = self.attr('id')

        $.ajax({
            url: '/ToDoes/AJAXEdit',
            data: {
                id: id,
                value: value
            },
            type: 'POST',
            success: function (result) {
                $('#tableDiv').html(result);
            }
        })
    });
})