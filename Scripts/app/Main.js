 $(document).on("click", "#send-btn", function (e) {
        e.preventDefault();
        //grecaptcha.ready(function () {
        //    grecaptcha.execute('6LcGoYQfAAAAAKBACSX1MZHQ-PxvbgM7w3sfokgc', { action: 'submit' }).then(function (token) {

        validationFaye.validate().then(function (status) {
            if (status == "Invalid") {
                swal.fire({
                    text: "Some fields are required!",
                    icon: "error",
                    buttonsStyling: false,
                    confirmButtonText: "Ok!",
                    customClass: {
                        confirmButton: "btn font-weight-bold btn-light-primary"
                    }
                });
                return;
            }
            var model = {
                Name: $("#Name").val(),
                Email: $("#Email").val(),
                Message: $("#Message").val(),
            };

            $.ajax({
                url: "/Home/SendForm/",
                type: "POST",
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify({ model: model }),
                dataType: "json",
            }).done(function (data) {
                if (data === "success") {
                    Swal.fire({
                        position: 'center',
                        icon: 'success',
                        text: 'Your application has been sent',
                        showConfirmButton: false,
                        timer: 4000
                    })
                    setTimeout(function () {
                        location.reload(true);
                    }, 4000);
                }
                else {

                }
            });

            validationFaye.resetForm();

        });

        //    });

        //});
    });