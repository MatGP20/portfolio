$('.carousel').carousel({
    interval: 1500
})

// Example starter JavaScript for disabling form submissions if there are invalid fields.
// Ejemplo de Javascript para desabilitar el envio de los datos del Form si hay datos invalidos
(function () {
    'use strict';
    window.addEventListener('load', function () {
        // Fetch all the forms we want to apply custom Bootstrap validation styles to and Loop over them and prevent submission. 
        // Para obtener todos los campos que deben ser validados. y evitar que se envien.
        var forms = document.getElementsByClassName('needs-validation');
        var validation = Array.prototype.filter.call(forms, function (form) {
            form.addEventListener('submit', function (event) {
                if (form.checkValidity() === false) {
                    event.preventDefault();
                    event.stopPropagation();
                }
                form.classList.add('was-validated');
            }, false);
        });
    }, false);
})();