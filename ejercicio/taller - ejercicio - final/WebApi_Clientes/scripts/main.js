$(function () {
    $('#btnLogin').click(function () { loginUsuario(); });
});

function ajax(strUsuario,strClave,strFecha) {
    var result;
    var usuario = {};
    usuario.User = strUsuario;
    usuario.Clave = strClave;
    usuario.FechaLogin = strFecha;
    $.ajax({
        
        url: 'http://localhost:6030/api/login',
        type: 'POST',
        data: usuario,
        async: false
    }).done(function (data) {
        alert("Llego a aca");
        result = data;
    }).error(function (xhr, status, error) {
        alert(error);
        var s = status;
        var e = error;
    });

    return result;
}

function loginUsuario() {
    var usuario = $("#txtUsuario").val();
    if (usuario == "") {
        alert("Debe escribir un usuario");
        
    } else {
        var clave = $("#txtClave").val();
        if (clave == "") {
            alert("Debe escribir una contraseña");
        } else {
            var hora = new Date;
            año = hora.getFullYear();
            mes = hora.getMonth() + 1;
            dia = hora.getDate();
            var fechaActual = "" + dia + "/" + mes + "/" + año;

            var result = ajax(usuario, clave, fechaActual);
            alert(result);
        }
    }
    
   
    
}

