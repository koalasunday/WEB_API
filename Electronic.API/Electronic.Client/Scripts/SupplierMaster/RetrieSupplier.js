$(document).ready(function () {
    LoadIndexSupplier();
    $('#table').DataTable({
        "ajax": LoadIndexSupplier()
    });
})

function LoadIndexSupplier() {
    $.ajax({
        type: "GET",
        url: "http://localhost:2188/api/Suppliers",
        dateType: "json",
        async: false,
        success: function (data) {
            var html = '';
            $.each(data, function (index, val) {
                html += '<tr>';
                html += '<td>' + val.Name + '</td>';
                html += '<td> <a href="#" onclick="return GetById(' + val.Id + ')">Edit</a>';
                html += '| <a href="#" onclick="return Delete(' + val.Id + ')">Delete</a> </td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        }
    });
}

function Save() {
    var supplier = new Object();
    supplier.name = $('#Name').val();
    $.ajax({
        url: 'http://localhost:2188/api/Suppliers',
        type: 'POST',
        dataType: 'json',
        data: supplier,
        success: function (result) {
            LoadIndexSupplier();
            $('#myModal').modal('hide');
            $('#Name').val('');
            $('#Id').val('');
        }
    });
};

function Edit() {
    var supplier = new Object();
    supplier.id = $('#Id').val();
    supplier.name = $('#Name').val();
    $.ajax({
        url: "http://localhost:2188/api/Suppliers/" + $('#Id').val(),
        data: supplier,
        type: "PUT",
        dataType: "json",
        success: function (result) {
            LoadIndexSupplier();
            $('#myModal').modal('hide');
            $('#Update').hide();
            $('#Save').show();
            $('#Name').val('');
            $('#Id').val('');
        }
    });
};

function GetById(Id) {
    $.ajax({
        url: "http://localhost:2188/api/Suppliers/" + Id,
        type: "GET",
        dataType: "json",
        success: function (result) {
            $('#Id').val(result.Id);
            $('#Name').val(result.Name);

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
            url: "http://localhost:2188/api/Suppliers/" + Id,
            type: "DELETE",
            success: function (response) {
                swal({
                    title: "Deleted!",
                    text: "That data has been soft delete!",
                    type: "success"
                },
                function () {
                    window.location.href = '/Suppliers/Index/';
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
