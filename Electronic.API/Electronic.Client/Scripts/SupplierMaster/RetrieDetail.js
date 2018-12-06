var Items = []
function LoadItem(element) {
    if (Items.length == 0) {
        $.ajax({
            type: 'GET',
            url: "http://localhost:1082/api/Items",
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

//Add Multiple Order.
$("#AddList").click(function (e) {
    e.preventDefault();
    debugger;
    if ($.trim($("#ProductItem").val()) == "" || $.trim($("#Price").val()) == "" || $.trim($("#Quantity").val()) == "") return;

    var productItem = $("#ProductItem").val(),
        quantity = $("#Quantity").val(),
        price = $("#Price").val(),
        detailsTableBody = $("#detailsTable tbody");

    var productDetail = '<tr><td>' + productItem + '</td><td>' + price + '</td><td>' + quantity + '</td><td>' + (parseFloat(price) * parseInt(quantity)) + '</td><td><a data-itemId="0" href="#" class="deleteItem">Remove</a></td></tr>';
    detailsTableBody.append(productDetail);
    ResetItem();
});


$(document).ready(function () {
    LoadIndexDetail();
    LoadItem($('#ProductItem'));
})

function LoadIndexDetail() {
    $.ajax({
        type: "GET",
        url: "http://localhost:1082/api/Details",
        dateType: "json",
        success: function (data) {
            var html = '';
            $.each(data, function (index, val) {
                html += '<tr>';
                html += '<td>' + val.Transaction.TransactionCode + '</td>';
                html += '<td>' + val.Item.Name + '</td>';
                html += '<td>' + val.Quantity + '</td>';
                html += '<td>' + val.Price + '</td>';
                html += '<td>' + (val.Quantity*val.Price) + '</td>';
                html += '<td> <a href="#" onclick="return GetById(' + val.Id + ')">Detail</a>';
                html += '</tr>';
            });
            $('.tbody1').html(html);
        }
    });
}

function Save() {
    var item = new Object();
    item.Transactions_Id = $('#ProductItem').val();
    item.Quantity = $('#Quantity').val();
    item.Price = $('#Price').val();
    $.ajax({
        url: 'http://localhost:1082/api/Details',
        type: 'POST',
        dataType: 'json',
        data: item,
        success: function (result) {
            LoadIndexTransaction();
            $('#Id').val('');
            ResetItem();
            $('#myModal').modal('hide');
        }
    });
};

function ResetItem() {
    $('#productItem').val('0');
    $('#price').val('');
    $('#quantity').val('');
};

$(document).on('click', 'a.deleteItem', function (e) {
    e.preventDefault();
    var $self = $(this);
    if ($(this).attr('data-itemId') == "0") {
        $(this).parents('tr').css("background-color", "#ff6347").fadeOut(800, function () {
            $(this).remove();
        });
    }
});

