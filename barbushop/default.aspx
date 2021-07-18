 <%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="barbushop._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css"/>
    <link rel="stylesheet" type="text/css" href="css/page1.css"/>
    <link href="css/mainStyle.css" rel="stylesheet" />
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

    <style>
     

   .textr {
           
            position: absolute;
            top: 50%;
            
         
            color: white;
            padding: 10rem 5rem;
            top: 50%;
            color: white;
            padding: 10rem 5rem;
            z-index: 2;
            font-size: 70px;
         
            font-weight: bold;
            text-shadow: 0 0 20px black;
        }
      @media(max-width: 769px) {
            .textr{
                font-size:50px;
            }
        }
           @media(max-width: 535px) {
            .textr{
                font-size:20px;
            }
        }
    </style>
    <div class="container">
        <div class="row pt-1 pb-1">
            <div class="col-12 ">
                <h4 class="textr">ברוכים הבאים למספרה שלכם</h4>
               
            </div>
        </div>
        
        
    </div>

<section>
   
    <div id="carouselExampleFade" class="carousel slide carousel-fade" data-ride="carousel" style="background-color:black;">
        <div class="carousel-inner">
            <div class="carousel-item active">
               
                <img src="image/mainPage/Barber-shop-in-Hong-Kong.jpg"  class="d-block w-100" alt="..."/>
                
            </div>
            <div class="carousel-item">
                <img src="image/mainPage/levels-barbershop-new-york-ny.jpg"  class="d-block w-100" alt="..."/>
            </div>
            <div class="carousel-item">
                <img src="image/mainPage/bar1.jpg" class="d-block w-100" alt="..."/>
            </div>
        </div>
        <a class="carousel-control-prev" href="#carouselExampleFade" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleFade" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
</section>

    
    <div class="container">
    <section class="our-webcoderskull padding-lg">
   
    
 
    <div class="row align-content-center">
      <div class="col-6">
          <div class="cnt-block equal-hight" style="height: 349px;">
            <figure><img src="http://www.webcoderskull.com/img/team4.png" class="img-responsive" alt=""/></figure>
              <p>לקוח</p>
          
           
              <a href="Userlogin1.aspx" class="btn btn-warning btn-lg btn-block" >הרשמה </a>
            
          
          </div>
       </div>
      <div class="col-6">
          <div class="cnt-block equal-hight" style="height: 349px;">
            <figure><img src="http://www.webcoderskull.com/img/team2.png" class="img-responsive" alt=""/></figure>
              <p>ספר</p>

            
            <a href="managerLogin.aspx" class="btn btn-warning btn-lg btn-block" >הרשמה </a>
            
       
          </div>
      </div>
    </div>
        </section>
  </div>



<div class="modal" id="modalClient" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header" style='background: #f1f9ff'>
        <h5 class="modal-title" id="userInter">כניסת לקוח</h5>
        <button type='button' class='close m-0 p-0'' style='outline: none' data-dismiss='modal' aria-label='Close'>
            <span aria-hidden='true'>&times;</span>
        </button>
      </div>
      <div class="modal-body text-right">
        <div class="form-group">
            <label for="userInputEmail1">דואר אלקטרוני</label>
            <asp:TextBox ID="TexUserLOgEmail" runat="server" class="form-control" aria-describedby="emailHelp" placeholder="israel@example.com"></asp:TextBox>

          </div>
          <div class="form-group">
            <label for="userInputPassword1">סיסמה</label>
              <asp:TextBox ID="TexUserLogPass" runat="server" placeholder="**********" class="form-control" TextMode="Password"></asp:TextBox>
            <small id="passemailHelp" class="form-text text-muted">הסיסמה חייבת להכיל אותיות גדולות, קטנות ומספרים.</small>

          </div>
                      <asp:Button ID="Button1" runat="server" class="btn btn-primary btn-lg btn-block mb-3" Text="כניסה" OnClick="UserLogin" />

      </div>
      <div class="modal-footer" style='background: #f5f5f5'>
        <button type="button" class="btn btn-secondary" style="margin-left: auto;" data-dismiss="modal">סגור</button>
      </div>

        </div>
  </div>
</div>

<div class="modal" id="modalBarber" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header" style='background: #f1f9ff'>
        <h5 class="modal-title" id="exampleModalLabel">כניסה </h5>
        <button type="button" class='close m-0 p-0'' style='outline: none' data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body text-right">
        <div class="form-group">
            <label for="exampleInputEmail1">דואר אלקטרוני</label>
            <asp:TextBox ID="TexEmailM" runat="server" class="form-control" aria-describedby="emailHelp" placeholder="israel@example.com"></asp:TextBox>
<%--            <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="israel@example.com">--%>
          </div>
          <div class="form-group">
            <label for="exampleInputPassword1">סיסמה</label>
              <asp:TextBox ID="TexPasslogM" runat="server" class="form-control"  placeholder="**********" TextMode="Password"></asp:TextBox>
<%--            <input type="password" class="form-control" id="exampleInputPassword1" placeholder="**********">--%>
<%--            <small id="emailHelp" class="form-text text-muted">הסיסמה חייבת להכיל אותיות גדולות, קטנות ומספרים.</small>--%>

          </div>
           <asp:Button ID="Button2" runat="server" class="btn btn-primary btn-lg btn-block mb-3" Text="כניסה" OnClick="MUserLogin"/>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" style="margin-left: auto;"  data-dismiss="modal">סגור</button>
      </div>
    </div>
  </div>
</div>





<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>



</asp:Content>
