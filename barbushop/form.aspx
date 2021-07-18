 <%@ Page Title="" Language="C#" MasterPageFile="~/Entery.Master" AutoEventWireup="true" CodeBehind="form.aspx.cs" Inherits="barbushop.form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/ENtery1.css" rel="stylesheet" />
     <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <style>
        
@-webkit-keyframes mover {
    0% {
        transform: translateY(0);
    }

    100% {
        transform: translateY(-20px);
    }
}

@keyframes mover {
    0% {
        transform: translateY(0);
    }

    100% {
        transform: translateY(-20px);
    }
}
/*        img {
    margin-top: 15%;
    margin-bottom: 5%;
    
    -webkit-animation: mover 2s infinite alternate;
    animation: mover 1s infinite alternate;
}*/
        .register-left img {
    margin-top: 15%;
    margin-bottom: 5%;
    width: 50%;
    -webkit-animation: mover 2s infinite alternate;
    animation: mover 1s infinite alternate;

}
        .register-left {
    text-align: center;
    color: #fff;
    margin-top: 4%;
   
}
        
.offset-5 {
    margin-left: 0px;
}
            .register-left input {
        border: none;
        border-radius: 1.5rem;
        padding: 2%;
        width: 60%;
        background: #f8f9fa;
        font-weight: bold;
        color: #383d41;
        margin-top: 30%;
        margin-bottom: 3%;
        cursor: pointer;
    }
@media (min-width: 768px){
.col-md-3 {
    -ms-flex: 0 0 25%;
    flex: 0 0 25%;
    max-width:50%;
     margin-right:350px;
    
} 
}
 h2{
    text-align:center;
}
 h3{
     text-align:center;
 }
    </style>
  <h2>ברוכים הבאים   </h2>
    <h3> לחץ על התמונה כדי להתחיל</h3>
    <div class="col-md-3 register-left">
     
                        
        <asp:HyperLink ID="HyperLink2" runat="server" ImageUrl="~/image/backg/ppppProject.jpg" NavigateUrl="~/default.aspx" CssClass="offset-5">כניסה</asp:HyperLink>
                        
                       
                    </div>
   <%-- <h2 style="font-family: 'Ink Free'; font-weight: bolder; font-style: normal">BARBER-SHOP</h2>--%>
    <br />
    <%--<div class="row">
        <div class="col-4">
            
        </div>
        <div class="col-4"--%>>
               <%-- <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/image/backg/ppppProject.jpg" NavigateUrl="~/default.aspx" CssClass="offset-5">כניסה</asp:HyperLink>
  --%>
<%--        </div>
        <div class="col-4">

        </div>
    </div>--%>
    <br />
      <br />
      <br />
      <br />
      <br />
      <br />
       
</asp:Content>
