<%@ Page Title="" Language="C#" MasterPageFile="~/user.Master" AutoEventWireup="true" CodeBehind="UserProducts.aspx.cs" Inherits="barbushop.UserProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css"/>

     <link href="css/mainStyle.css" rel="stylesheet" />    <link href="css/mangerProduct.css" rel="stylesheet" />
    <link href="css/mangerHiarCut.css" rel="stylesheet" />
    <style>
        .add-to-cart {
    background: #ff9f1a;
    padding: 1.2em 1.5em;
    border: none;
    text-transform: UPPERCASE;
    font-weight: bold;
    color: #fff;
    -webkit-transition: background .3s ease;
    transition: background .3s ease;
        color: darkcyan;
    float: right;
    /* size: legal; */
    width: 100%;
    text-align: center;
}

    </style>
    <%--<div class="jumbotron">
         
       <section>
            <div class="image-container"   >
           
       </div>
      
       </section>
      

                                     </div>--%>
    <br />
    <section>
        <footer class="page-footer font-small blue">
          <div class="footer-copyright text-center py-3">
              <asp:Label ID="lblprodCat" runat="server" Text="" style="font-size: x-large; font-weight: bold;"></asp:Label></div>
                     <asp:DropDownList class="form-control" style="width:15%;" ID="DropDownCat" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownCat_SelectedIndexChanged" OnTextChanged="DropDownCat_TextChanged"></asp:DropDownList>
        </footer>
  </section>
    <br />
 
    <div class="container">
       
               
<div class="container">
 <div class="row">
      <asp:Repeater ID="RptprodPic" runat="server">
                                          <ItemTemplate>
        <div class="col-md-3 col-sm-6">
            <div class="product-grid9">

                <div class="product-grid9">
                <div class="product-image9">
                    <a href="#">
                        <img class="pic-1" src="image/mainPage/products/<%#Eval("ProdPicname") %>">
                         <img class="pic-2" src="image/mainPage/products/<%#Eval("ProdPicname") %>">
                    </a>
                    &nbsp;<a href="#" class="fa fa-search product-full-view"></a></div>
                <div class="product-content">
                    <ul class="rating">
                        <li class="fa fa-star"></li>
                        <li class="fa fa-star"></li>
                        <li class="fa fa-star"></li>
                        <li class="fa fa-star"></li>
                        <li class="fa fa-star"></li>
                    </ul>
                    <h3 class="title"><a href="#"><%#Eval("ProdName")%></a></h3>
                    <div class="price" style="float:right;"><%#Eval("ProdPriceType")%>ש"ח</div>
<%--                 <button type="button" class="btn btn-primary btn-lg btn-block mb-3" />nlknslfnads</button>--%>
                  
                    <a class="add-to-cart" style="color:darkcyan; float:right;"  href="ProductD.aspx?prodid=<%#Eval("productId")%>"> פרטים</a>

                 
                </div>

            </div>

</div>
            </div>
                                                      </ItemTemplate>
                                      </asp:Repeater>

                                        <asp:Literal ID="pic" runat="server" />
     </div>
    </div>

   
                                     
            
    
                   
    
</div>

  
    
    

</asp:Content>
