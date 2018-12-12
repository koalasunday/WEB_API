var Items = []

$(document).ready(function () {
    LoadIndexTransaction();
    loadItem($('#ProductItem'));
})

function LoadIndexTransaction() {
    $.ajax({
        type: "GET",
        url: "http://localhost:2188/api/Transactions",
        dateType: "json",
        success: function (data) {
            var html = '';
            $.each(data, function (index, val) {
                html += '<tr>';
                html += '<td>' + val.Id + '</td>';
                html += '<td>' + val.TransactionCode + '</td>';
                html += '<td>' + val.TransactionDate + '</td>';
                html += '<td> <a href="#" onclick="return GetById(' + val.Id + ')">Detail</a>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        }
    });
}

function loadItem(element) {
    if (Items.length == 0) {
        $.ajax({
            type: 'GET',
            url: 'http://localhost:2188/api/Items',
            success: function (data) {
                Items = data;
                renderItem(element);
            }
        })
    }
    else {
        renderItem(element);
    }
}

function renderItem(element) {
    var $ele = $(element);
    $ele.empty();
    $ele.append($('<option/>').val('0').text('Select Item'));
    $.each(Items, function (i, val) {
        $ele.append($('<option/>').val(val.Id).text(val.Name));
    })
}

loadItem($('#ProductItem'));