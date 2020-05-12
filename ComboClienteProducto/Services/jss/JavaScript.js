$(function () {
    cargarS();
    $('#btnGuardar').click(function () {
        alert("HOLA!");
        guardarProducto();
    });
});

function cargarSelectCli(data) {
    var div = $('#selectCli');
    div.html("");
    var row = $('<select class="custom-select mr-sm-2" onChange="cargarOption()"></select >');
    var option = $('<option hidden selected>Seleccione un cliente</option>');
    row.append(option);
    for (d in data) {
        row.append($('<option value='+ data[d].IdClient + '>' + data[d].Nombre + ' </option>'));
    }
    div.append(row);
}

function cargarSelectPro(data) {
    var div = $('#selectPro');
    div.html("");

    var row = $('<select class="custom-select mr-sm-2" "></select >');
    var option = $('<option hidden selected>Seleccione un producto</option>');
    row.append(option);
    for (d in data) {
        row.append($('<option value=' + data[d].IdProduc + '>' + data[d].Nombre + ' </option > '));
    }
    div.append(row);
}

function cargarS() {
    var dataC = ajaxGetCli();
    var dataP = ajaxGetPro();
    cargarSelectCli(dataC);
    cargarSelectPro(dataP);
}

function ajaxGetCli() {
    var result;
    $.ajax({
        url: 'https://localhost:44399/api/cliente',
        type: 'GET',
        async: false
    }).done(function (data) {
        result = data;
    }).error(function (xhr, status, error) {
        alert(error);
        var s = status;
        var e = error;
    });
    return result;
}

function ajaxGetPro() {
    var result;
    $.ajax({
        url: 'https://localhost:44399/api/producto',
        type: 'GET',
        async: false
        
    }).done(function (data) {
        result = data;
    }).error(function (xhr, status, error) {
        alert(error);
        var s = status;
        var e = error;
    });
    return result;
}

function ajaxGetCombo() {
    var result;
    $.ajax({
        url: 'https://localhost:44399/api/combo',
        type: 'GET',
        async: false
    }).done(function (data) {
        result = data;
    }).error(function (xhr, status, error) {
        alert(error);
        alert("error");
        var s = status;
        var e = error;
    });
    return result;
}

function ajaxGetCP(id) {
    var result;
    $.ajax({
        url: 'https://localhost:44399/api/combocp/'+id,
        type: 'GET',
        async: false
    }).done(function (data) {
        result = data;
    }).error(function (xhr, status, error) {
        alert(error);
        var s = status;
        var e = error;
    });
    return result;
}

function cargarOption() {
    var id = $('#selectCli option:selected').val();
    var data = ajaxGetCP(id);
    sessionStorage.setItem("id", id);
    cargarGV(data);
}

function cargarGV(data) {
    var grd = $('#gvCombo');
    grd.html("");
    var tbl = $('<table border=1 class="table table-striped table-dark"></table>');

    var header = $('<tr></tr>');
    header.append('<td >Nombre</td>');
    header.append('<td >Apellido</td>');
    header.append('<td >Producto</td>');
    header.append('<td >Precio</td>');
    header.append('<td class="">Cantidad</td>');
    header.append('<td class="text-info">Total</td>');
    tbl.append(header);

    for (d in data) {
        var row = $('<tr></tr>');
        row.append('<td>' + data[d].NombreC + '</td>');
        row.append('<td>' + data[d].Apellido + '</td>');
        row.append('<td>' + data[d].NombreP + '</td>');
        row.append('<td>' + data[d].PrecioP + '</td>');
        row.append('<td>' + data[d].Cantidad + '</td>');
        row.append('<td>' + data[d].Total + '</td>');

        tbl.append(row);
    }
    grd.append(tbl);
}

function guardarProducto() {
    ajaxPostPedido();
    var id = sessionStorage.getItem("id");
    var data = ajaxGetCP(id);
    cargarGV(data);
}

function sacarDatos() {
    var data = {};
    data.Cantidad = $('#numberCantidad').val();
    data.IdCliente = $('#selectCli option:selected').val();
    data.IdProducto = $('#selectPro option:selected').val();

    return data;
}

function ajaxPostPedido() {
    var result;
    var obj = sacarDatos();
        $.ajax({
            url: 'https://localhost:44399/api/combo',
            
            type: 'POST',
            async: false,
            data: { "Cantidad": obj.Cantidad, "IdCliente": obj.IdCliente, "IdProducto": obj.IdProducto}
        }).done(function (data) {
            result = data;
        }).fail(function (xhr, status, error) {
            alert(error);
            var s = status;
            var e = error;
        });
        return result;
}

function calcularTotal() {
    var cant = $('#numberCantidad').val();
    alert(cant);
}


