<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SitioWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     
    <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Reparación | Log in</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
  <!-- Bootstrap 3.3.7 -->
  <link rel="stylesheet" href="BoostrapTheme/AdminLTE-2.4.2/bower_components/bootstrap/dist/css/bootstrap.min.css">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="BoostrapTheme/AdminLTE-2.4.2/bower_components/font-awesome/css/font-awesome.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="BoostrapTheme/AdminLTE-2.4.2/bower_components/Ionicons/css/ionicons.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="BoostrapTheme/AdminLTE-2.4.2/dist/css/AdminLTE.min.css">
  <!-- iCheck -->
  <link rel="stylesheet" href="BoostrapTheme/AdminLTE-2.4.2/plugins/iCheck/square/blue.css">

  <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
  <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
  <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->

  <!-- Google Font -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">

</head>
<body class="hold-transition login-page" style="background-color:white!important;  background-image:url('img/fondologin.jpg'); background-position:center; background-repeat:no-repeat;">
<div class="login-box" style="background-color:white; opacity:0.9;">
  <div class="login-logo">
  <img src="img/logo.jpg" width="300px" height="200px"/>
  </div>
  <!-- /.login-logo -->
  <div class="login-box-body">
    <p class="login-box-msg"></p>


    <form id="form1" runat="server">
 <div class="form-group has-feedback">
      <asp:TextBox runat="server" ID="txtUsuario" CssClass="form-control"  placeholder="usuario">
      </asp:TextBox>
       <%-- <input type="email" class="form-control" placeholder="Email">--%>
        <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
      </div>
      <div class="form-group has-feedback">
      <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" TextMode="Password" placeholder="contraseña">
      </asp:TextBox>

       <%-- <input type="password" class="form-control" placeholder="Password">--%>
        <span class="glyphicon glyphicon-lock form-control-feedback"></span>
      </div>
      <div class="row">
        <div class="col-xs-8">
          <div class="checkbox icheck">
            <label>
              <input type="checkbox"> Recordar
            </label>
          </div>
        </div>
        <!-- /.col -->
        <div class="col-xs-4">
             <asp:Button  runat="server" ID="btnLogin" CssClass="btn btn-primary btn-block btn-flat" Text="Entrar"  OnClick="btnLogin_Click"/>
        <%--  <button type="submit" class="btn btn-primary btn-block btn-flat">Sign In</button>--%>
        </div>
        <!-- /.col -->
      </div>
   

    </form>
   
      
   <%-- <div class="social-auth-links text-center">
      <p>- OR -</p>
      <a href="#" class="btn btn-block btn-social btn-facebook btn-flat"><i class="fa fa-facebook"></i> Sign in using
        Facebook</a>
      <a href="#" class="btn btn-block btn-social btn-google btn-flat"><i class="fa fa-google-plus"></i> Sign in using
        Google+</a>
    </div>--%>
    <!-- /.social-auth-links -->

  <%--  <a href="#">I forgot my password</a><br>
    <a href="register.html" class="text-center">Register a new membership</a>--%>

  </div>
  <!-- /.login-box-body -->
</div>
<!-- /.login-box -->

<!-- jQuery 3 -->
<script src="BoostrapTheme/AdminLTE-2.4.2/bower_components/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap 3.3.7 -->
<script src="BoostrapTheme/AdminLTE-2.4.2/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
<!-- iCheck -->
<script src="BoostrapTheme/AdminLTE-2.4.2/plugins/iCheck/icheck.min.js"></script>
<script>
  $(function () {
    $('input').iCheck({
      checkboxClass: 'icheckbox_square-blue',
      radioClass: 'iradio_square-blue',
      increaseArea: '20%' // optional
    });
  });
</script>
    </body>
</html>
