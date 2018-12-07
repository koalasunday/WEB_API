$(document).ready(function () {
    LoadIndexItem();
    $('#table').DataTable({
        "ajax" : LoadIndexItem()
    });
})

function LoadIndexItem() {
    $.ajax({
        type: "GET",
        url: "http://localhost:2188/api/Items",
        dateType: "json",
        async: false,
        success: function (data) {
            var html = '';
            $.each(data, function (index, val) {
                html += '<tr>';
                html += '<td>' + val.Name + '</td>';
                html += '<td>' + val.Price + '</td>';
                html += '<td>' + val.Stock + '</td>';
                html += '<td> <a href="#" onclick="return GetById(' + val.Id + ')">Edit</a>';
                html += '| <a href="#" onclick="return Delete(' + val.Id + ')">Delete</a> </td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        }
    });
}

function Save() {
    var item = new Object();
    item.name = $('#Name').val();
    item.price = $('#Price').val();
    item.stock = $('#Stock').val();
    $.ajax({
        url: 'http://localhost:2188/api/Items',
        type: 'POST',
        dataType: 'json',
        data: item,
        success: function (result) {
            LoadIndexItem();
            $('#myModal').modal('hide');
        }
    });
};

function Edit() {
    var item = new Object();
    item.id = $('#Id').val();
    item.name = $('#Name').val();
    item.price = $('#Price').val();
    item.stock = $('#Stock').val();
    $.ajax({
        url: "http://localhost:2188/api/Items/" + $('#Id').val(),
        data: item,
        type: "PUT",
        dataType: "json",
        success: function (result) {
            LoadIndexItem();
            $('#myModal').modal('hide');
            $('#Id').val('');
            $('#Name').val('');
            $('#Price').val('');
            $('#Stock').val('');
        }
    });
};

function GetById(Id) {
    $.ajax({
        url: "http://localhost:2188/api/Items/" + Id,
        type: "GET",
        dataType: "json",
        success: function (result) {
            $('#Id').val(result.Id);
            $('#Name').val(result.Name);
            $('#Price').val(result.Price);
            $('#Stock').val(result.Stock);

            $('#myModal').modal('show');
            $('#Update').show();
            $('#Save').hide();
        }
    })
}

function Delete(Id) {
    swal({
        title: "Are you sure?",
        text: "You will not be able to recover this imaginary file!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Yes, delete it!",
        closeOnConfirm: false
    }, function () {
        $.ajax({
            url: "http://localhost:2188/api/Items/" + Id,
            type: "DELETE",
            success: function (response) {
                swal({
                    title: "Deleted!",
                    text: "That data has been soft delete!",
                    type: "success"
                },
                function () {
                    window.location.href = '/Items/Index/';
                });
            },
            error: function (response) {
                swal("Oops", "We couldn't connect to the server!", "error");
            }
        });
    });
}
function Reset() {
    $('#myModal').modal('hide');
    $('#Id').val('');
    $('#Name').val('');
    $('#Price').val('');
    $('#Stock').val('');
    $('#Save').show();
    $('#Update').hide();
};