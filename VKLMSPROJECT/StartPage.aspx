<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="VKLMSPROJECT.StartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
  <title>Asp.Net LMS PROJECT</title>
  <link rel="stylesheet" href="Views/StartApp/css/StartPage.css">
    <link rel="shortcut icon" href="Views/AdminManegmant/assets/images/icons8-c-sharp-logo-128.svg">
</head>
<body>
    <div class="container">
      <div class="card">
        <h1 class="title">Asp.Net Lms Project</h1>
        <p class="subtitle">A book management and book borrowing system built using
            Asp.Net, Html, Css, Scss, Js and Sql.
            <br><br>
            Click The "Get Started" and Welcome
        </p>
        <button class="btn" onclick="window.location.href='/Views/StartApp/RegLog.aspx';">Get Started</button>
      </div>
      <div class="blob"></div>
    </div>
</body>
</html>
