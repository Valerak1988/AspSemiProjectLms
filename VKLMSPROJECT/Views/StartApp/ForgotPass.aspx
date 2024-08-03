<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPass.aspx.cs" Inherits="VKLMSPROJECT.Views.StartApp.ForgotPass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <meta name="description" content="Responsive Bootstrap Admin Dashboards">
    <meta name="author" content="Bootstrap Gallery" />
    <link rel="canonical" href="https://www.bootstrap.gallery/">
    <meta property="og:url" content="https://www.bootstrap.gallery">
    <meta property="og:title" content="Admin Templates - Dashboard Templates | Bootstrap Gallery">
    <meta property="og:description" content="Marketplace for Bootstrap Admin Dashboards">
    <meta property="og:type" content="Website">
    <meta property="og:site_name" content="Bootstrap Gallery">
    <link rel="shortcut icon" href="../AdminManegmant/assets/images/icons8-c-sharp-logo-128.svg">

    <title>Password Restor</title>


    <!-- Animated css -->
    <link rel="stylesheet" href="../AdminManegmant/assets/css/animate.css">

    <!-- Bootstrap font icons css -->
    <link rel="stylesheet" href="../AdminManegmant/assets/fonts/bootstrap/bootstrap-icons.css">

    <!-- Main css -->
    <link rel="stylesheet" href="../AdminManegmant/assets/css/main.min.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">

                    <div class="login-container">
                        <!-- Login box start -->
                        <form action="index.html">
                            <div class="login-box">
                                <div class="login-form">
                                    <a href="index.html" class="login-logo">
                                        <img src="../AdminManegmant/assets/images/icons8-outplayed.svg" alt="Admin Templates" />
                                    </a>
                                    <div class="login-welcome">
                                        In order to access your Lms account,<br />
                                        please enter the email id you provided during the
                    registration process.
                                    </div>
                                    <div class="mb-3">
                                        <label class="form-label" for="TxtEmail">Email</label>
                                        <asp:TextBox ID="TxtEmail" runat="server" class="form-control" placeholder="Enter Email" />
                                    </div>
                                    <div class="login-form-actions">
                                        <asp:LinkButton ID="BtnSend" runat="server" CssClass="btn" OnClick="BtnSend_Click">
                        <span class="icon"><i class="bi bi-arrow-right-circle"></i>
                                </span>Send</asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </form>
                        <!-- Login box end -->
                    </div>

                </div>
            </div>
        </div>
    </form>
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/js/bootstrap.bundle.min.js"></script>
    <script src="assets/js/modernizr.js"></script>
    <script src="assets/js/moment.js"></script>

    <script src="assets/js/main.js"></script>
</body>
</html>
