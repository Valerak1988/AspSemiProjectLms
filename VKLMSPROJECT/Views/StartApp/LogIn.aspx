<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="VKLMSPROJECT.Views.StartApp.LogIn" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Meta -->
    <meta name="description" content="Responsive Bootstrap Admin Dashboards">
    <meta name="author" content="Bootstrap Gallery" />
    <link rel="canonical" href="https://www.bootstrap.gallery/">
    <meta property="og:url" content="https://www.bootstrap.gallery">
    <meta property="og:title" content="Admin Templates - Dashboard Templates | Bootstrap Gallery">
    <meta property="og:description" content="Marketplace for Bootstrap Admin Dashboards">
    <meta property="og:type" content="Website">
    <meta property="og:site_name" content="Bootstrap Gallery">
    <link rel="shortcut icon" href="../AdminManegmant/assets/images/icons8-c-sharp-logo-128.svg">

    <!-- Title -->
    <title>LMS LogIn Form</title>

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
            <div class="row gx-3">
                <div class="col-sm-12 col-12">
                    <div class="login-container">
                        <!-- Login box start -->
                        <div class="login-box">
                            <div class="login-form">
                                <a href="#" class="login-logo">
                                    <img src="../AdminManegmant/assets/images/icons8-outplayed.svg" alt="Admin Templates" />
                                </a>
                                <div class="login-welcome">
                                    Welcome,
                                    <br />
                                    Please login to your LMS account.
                                </div>
                                <div class="mb-3">
                                    <label class="form-label" for="TxtEmail">Username</label>
                                    <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control" Placeholder="Enter Email" />
                                </div>
                                <div class="mb-3">
                                    <div class="d-flex justify-content-between">
                                        <label class="form-label" for="TxtPassword">Password</label>
                                        <a href="ForgotPass.aspx" id="pwd" class="btn-link ml-auto">Forgot password?</a>
                                    </div>
                                    <asp:TextBox ID="TxtPassword" runat="server" CssClass="form-control" TextMode="Password" Placeholder="Enter Password" />
                                </div>
                                <div class="login-form-actions">
                                    <asp:LinkButton ID="BtnLogIn" runat="server" CssClass="btn" OnClick="BtnLogIn_Click">
                                        <span class="icon"><i class="bi bi-arrow-right-circle"></i></span>Login
                                    </asp:LinkButton>
                                </div>
                                <asp:Literal ID="LtlMsg" runat="server" />
                                <div class="login-form-footer">
                                    <div class="additional-link">
                                        Don't have an account? <a href="Register.aspx">Register</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- Login box end -->
                    </div>
                </div>
            </div>
        </div>
    </form>

    <!-- JavaScript files -->
    <script src="../AdminManegmant/assets/js/jquery.min.js"></script>
    <script src="../AdminManegmant/assets/js/bootstrap.bundle.min.js"></script>
    <script src="../AdminManegmant/assets/js/modernizr.js"></script>
    <script src="../AdminManegmant/assets/js/moment.js"></script>
    <script src="../AdminManegmant/assets/js/main.js"></script>
</body>
</html>
