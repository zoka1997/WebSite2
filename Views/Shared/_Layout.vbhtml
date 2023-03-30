<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cloudreel</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    @Styles.Render("~/app-bundle/css")
    <link href="~/Assets/css/main.css" rel="stylesheet" />
    <link href="~/Assets/css/responsive.css" rel="stylesheet" />
    <link href='https://fonts.googleapis.com/css?family=Poppins' rel='stylesheet' />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css" integrity="sha512-1ycn6IcaQQ40/MKBW2W4Rhis/DbILU74C1vSrLJxCq57o941Ym01SwNsOMqvEBFlcgUa6xLiPY/NS5R+E6ztJQ==" crossorigin="anonymous" referrerpolicy="no-referrer" />
</head>
<body>
    <nav class="navbar-menu">
        <div class="navbar navbar-expand-lg fixed-top navbar-dark container-fluid">
            <a class="logo-faye" href="/Home">
                <img class="header-logo" src="~/Assets/images/Cloudreel LOGO 2.svg" />
            </a>
            <button class="navbar-toggler navbar-toggler-white" type="button" data-toggle="collapse" data-target="#navbarCollapse" aria-controls="navbarCollapse" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarCollapse">
                <ul class="navbar-nav d-flex justify-content-around">
                    <li class="nav-item">
                        <a class="nav-link menu-items-link text-nowrap" onclick="closeNav()" href="#how-it-works">How it works <span class="sr-only">(current)</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link menu-items-link text-nowrap" onclick="closeNav()" href="#what-we-do">What we do</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link menu-items-link text-nowrap" onclick="closeNav()" href="#products">Products</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link menu-items-link text-nowrap" onclick="closeNav()" href="#faye">Faye</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link menu-items-link text-nowrap" onclick="closeNav()" href="#education">Education</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link menu-items-link text-nowrap" onclick="closeNav()" href="#retainer-production">Retainer Production</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link menu-items-link text-nowrap" onclick="closeNav()" href="#full-scale-production">Full scale Production</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link menu-items-link text-nowrap" onclick="closeNav()" href="#about-us">About us</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link menu-items-link text-nowrap" onclick="closeNav()" href="#contact">Contact</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <div class="container-fluid body-content pl-0 pr-0">
        @RenderBody()
    </div>
    <footer>
        <div class="col-lg-12 col-md-12 col-sm-12 logo-links-part">
            <div class="row">
                <div class="col-lg-9 col-md-9 col-sm-12">
                    <img class="footer-logo" src="~/Assets/images/Cloudreel LOGO 2.svg" width="248" height="69" /> <br />
                    <div class="privacy-policy-box">
                        <a href="/Home/TermsOfUse" class="footer-links">Terms of Use</a> <br />
                        <a href="/Home/PrivacyPolicy" class="footer-links">Privacy Policy</a> <br />
                        <a href="/Home/PrivacyPolicy" class="footer-links">GDPR</a> <br />
                    </div>
                    <div class="footer-location">
                        <p class="footer-location-name"><i class="fas fa-map-marker-alt icon-location"></i>Stockholm, Sweden/Zug, Switzerland</p>
                    </div>
                </div>
                <div class="col-lg-3 col-md-3 col-sm-12 footer-cloudreel">
                    <p class="footer-location-name"> @*<i class="far fa-copyright text-white"></i>*@ © Cloudreel AB</p>
                </div>
            </div>
        </div>
    </footer>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/app-bundle/js")

    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
    @*<script src="~/Scripts/app/Main.js"></script>*@
    <script>
        const navbarToggler = document.querySelector('.navbar-toggler');
        // Add an event listener to the button that toggles a CSS class
        navbarToggler.addEventListener('click', function () {
            this.classList.toggle('active');
        });
        function closeNav() {
            $('.navbar-collapse').collapse('hide');
            navbarToggler.classList.remove('active');
        }

    </script>
</body>
</html>
