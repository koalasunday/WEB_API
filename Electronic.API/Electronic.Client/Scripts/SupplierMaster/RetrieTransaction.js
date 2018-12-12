$(document).ready(function () {
    LoadIndexTransaction();
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

function Save() {
    var item = new Object();
    item.transactionCode = $('#TransactionCode').val();
    //item.transactionDate = $('#TransactionDate').val();
    $.ajax({
        url: 'http://localhost:1082/api/Transactions',
        type: 'POST',
        dataType: 'json',
        data: item,
        success: function (result) {
            LoadIndexTransaction();
            $('#Id').val('');
            $('#TransactionCode').val('');
            $('#myModal').modal('hide');
        }
    });
};

function Save1() {
    var item = new Object();
    item.transactionCode = $('#Transaction.TransactionCode').val();
    $.ajax({
        url: 'http://localhost:1082/api/Transactions',
        type: 'POST',
        data: item,
        dataType: 'json',
        success: function (result) {
            var item = new Object();
            item.transactionCode = $('#Transaction.TransactionCode').val();
            $.ajax({
                url: 'http://localhost:1082/api/Transactions',
                type: 'POST',
                dataType: 'json',
                data: item,
                success: function (result) {

                }
            });
        }
    });
};


