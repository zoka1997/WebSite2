var validationFaye;
var _handleFayeForm = function () {

    validationFaye = FormValidation.formValidation(
        document.getElementById('contact-form'),
        {
            fields: {
                Name: {
                    validators: {
                        notEmpty: {
                            message: ' '
                        }
                    }
                },
                Message: {
                    validators: {
                        notEmpty: {
                            message: ' '
                        }
                    }
                },
                Email: {
                    validators: {
                        notEmpty: {
                            message: ' '
                        },
                        emailAddress: {
                            message: 'The value is not a valid email address'
                        }
                    }
                },
            },
            rules: {
                Email: {
                    required: true,
                    email: true
                },
            },
            plugins: {
                trigger: new FormValidation.plugins.Trigger(),
                bootstrap: new FormValidation.plugins.Bootstrap()
            }
        });
};

$(document).ready(function () {
    _handleFayeForm();
});