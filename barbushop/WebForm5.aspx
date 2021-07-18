<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="barbushop.WebForm5" %>

<!DOCTYPE html>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        .login-container{
    margin-top: 5%;
    margin-bottom: 5%;
}
.login-logo{
    position: relative;
    margin-left: -41.5%;
}
.login-logo img{
    position: absolute;
    width: 20%;
    margin-top: 19%;
    background: #282726;
    border-radius: 4.5rem;
    padding: 5%;
}
.login-form-1{
    padding: 9%;
    background:#282726;
    box-shadow: 0 5px 8px 0 rgba(0, 0, 0, 0.2), 0 9px 26px 0 rgba(0, 0, 0, 0.19);
}
.login-form-1 h3{
    text-align: center;
    margin-bottom:12%;
    color:#fff;
}
.login-form-2{
    padding: 9%;
    background: #f05837;
    box-shadow: 0 5px 8px 0 rgba(0, 0, 0, 0.2), 0 9px 26px 0 rgba(0, 0, 0, 0.19);
}
.login-form-2 h3{
    text-align: center;
    margin-bottom:12%;
    color: #fff;
}
.btnSubmit{
    font-weight: 600;
    width: 50%;
    color: #282726;
    background-color: #fff;
    border: none;
    border-radius: 1.5rem;
    padding:2%;
}
.btnForgetPwd{
    color: #fff;
    font-weight: 600;
    text-decoration: none;
}
.btnForgetPwd:hover{
    text-decoration:none;
    color:#fff;
}
    </style>
    
   <script>
       function alertme() {
           Swal.fire({
               icon: 'error',
               title: 'שגיאה...',
               text: '  ישנה תקלה אנא פנה למנהל האתר    !',
           })
       }
       function alertmes() {
           Swal.fire({
               icon: 'success',
               title: 'הצלחה...',
               text: '  תמונת הפרופיל נשמרה בהצלחה    !',
           })
       }
   </script>
    <title></title>
</head>
    
<body>
  
    <form id="form1" runat="server">
        <div class="container login-container">
            <div class="row">
                <div class="col-md-6 login-form-1">
                    <h3>תמונת פרופיל</h3>
                    
                        <div class="form-group">
                         <asp:Panel ID="Panel1" style="border-color: rgb(0 0 0 / 8%);
                                 border-style: Inset;
                                 border-radius: 50%;
" runat="server" BorderStyle="Inset"></asp:Panel>
                        </div>
                  
                    
                </div>
                <div class="col-md-6 login-form-2">
                    <div class="login-logo">
                        <img src="https://image.ibb.co/n7oTvU/logo_white.png" alt=""/>
                    </div>
                    <form><h3>העלה תמונה</h3>
                        <div class="form-group" style="direction: rtl;">
                          <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" />
                        </div>
                                                <div class="form-group">
                           <asp:Button ID="btnUPPic" class="form-control" runat="server" Text="העלה תמונה" OnClick="btnUPPic_Click"  />
                        </div>
                        <div class="form-group" style="direction: rtl;">
                           <asp:TextBox ID="txtnote" class="form-control" placeholder=" קצת על עצמך" runat="server"></asp:TextBox>
                        </div>
                                                <div class="form-group">
                           <asp:Button ID="btnUpload" class="form-control" runat="server" Text=" אישור" OnClick="btnUpload_Click"/>
                        </div>
                       </form>
             
                </div>
            </div>
        </div>

  
    </form>
</body>
</html>
