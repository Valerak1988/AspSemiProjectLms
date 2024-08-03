<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="VKLMSPROJECT.Views.StartApp.Register" %>

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
    <title>Registration</title>

    <!-- Animated css -->
    <link rel="stylesheet" href="../AdminManegmant/assets/css/animate.css">

    <!-- Bootstrap font icons css -->
    <link rel="stylesheet" href="../AdminManegmant/assets/fonts/bootstrap/bootstrap-icons.css">

    <!-- Main css -->
    <link rel="stylesheet" href="../AdminManegmant/assets/css/main.min.css">
</head>
<body>
    <div class="container">
        <div class="row gx-3">
            <div class="col-sm-12 col-12">
                <div class="login-container">
                    <!-- Login box start -->
                    <form id="form1" runat="server">
                        <div class="login-box">
                            <div class="login-form">
                                <a href="#" class="login-logo">
                                    <img src="../AdminManegmant/assets/images/icons8-outplayed.svg" alt="Admin Templates" />
                                </a>
                                <div class="login-welcome">
                                    Welcome,
                                    <br />
                                    Please create your account.
                                </div>
                                <div class="row gx-3">
                                    <div class="col-xl-6 col-sm-6 col-12 mb-3">
                                        <label class="form-label" for="TxtAdminName">Name</label>
                                        <asp:TextBox ID="TxtAdminName" runat="server" class="form-control" placeholder="Enter Name" />
                                    </div>
                                    <div class="col-xl-6 col-sm-6 col-12 mb-3">
                                        <label class="form-label" for="TxtAdminLastName">Last Name</label>
                                        <asp:TextBox ID="TxtAdminLastName" runat="server" class="form-control" placeholder="Enter Last Name" />
                                    </div>
                                    <div class="col-xl-6 col-sm-6 col-12 mb-3">
                                        <label class="form-label" for="TxtEmail">Email</label>
                                        <asp:TextBox ID="TxtEmail" runat="server" class="form-control" placeholder="Enter Email" />
                                    </div>
                                    <div class="col-xl-6 col-sm-6 col-12 mb-3">
                                        <label class="form-label" for="TxtPassword">Password</label>
                                        <asp:TextBox ID="TxtPassword" runat="server" class="form-control" TextMode="Password" placeholder="Enter Password" />
                                    </div>
                                    <div class="col-xl-6 col-sm-6 col-12 mb-3">
                                        <label class="form-label" for="TxtRole">Role</label>
                                        <asp:TextBox ID="TxtRole" runat="server" class="form-control" placeholder="Enter Role" />
                                    </div>
                                    <div class="col-xl-12 col-sm-6 col-12 mb-3">
                                        <label class="form-label">Profile Photo</label>
                                        <asp:FileUpload ID="UploadPic" class="form-control" runat="server" />
                                    </div>
                                </div>
                                <div class="login-form-actions">
                                    <asp:LinkButton ID="BtnReg" runat="server" CssClass="btn" OnClick="BtnReg_Click">
    <span class="icon"><i class="bi bi-arrow-right-circle"></i>
            </span>Login</asp:LinkButton>
                                </div>
                                <asp:Literal ID="LtlMsg" runat="server" />
                                <div class="login-form-footer">
                                    <div class="additional-link">
                                        Already have an account? <a href="LogIn.aspx">Login</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </form>
                    <!-- Login box end -->
                </div>
            </div>
        </div>
    </div>

    <script src="../AdminManegmant/assets/js/jquery.min.js"></script>
    <script src="../AdminManegmant/assets/js/bootstrap.bundle.min.js"></script>
    <script src="../AdminManegmant/assets/js/modernizr.js"></script>
    <script src="../AdminManegmant/assets/js/moment.js"></script>
    <script src="../AdminManegmant/assets/js/main.js"></script>
</body>
</html>
