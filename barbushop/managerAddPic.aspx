<%@ Page Title="" Language="C#" MasterPageFile="~/managerMster.Master" AutoEventWireup="true" CodeBehind="managerAddPic.aspx.cs" Inherits="barbushop.masterAddPic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <link href="css/mainStyle.css" rel="stylesheet" />    <link href="css/mangerProduct.css" rel="stylesheet" />
    <link href="css/mangerHiarCut.css" rel="stylesheet" />
      <link href="css/product.css" rel="stylesheet" />

                      <script src="//cdn.jsdelivr.net/npm/sweetalert2@10"></script>



   <script>
       function alertme() {
           Swal.fire({
               icon: 'success',
               title: 'הצלחה...',
               text: '  הכנסת מוצר חדש לחנות   !',
           })       }
   </script>

    <style>

        body{
             background: -webkit-linear-gradient(top, #117a8b, rgba(0,123,255,.25)) !important;
        }
           .product-grid9,.product-grid9 .product-image9        {
    position: relative
}

.product-grid9 {
    font-family: Poppins,sans-serif;
    z-index: 1
}

    .product-grid9 .product-image9 a {
        display: block
    }

    .product-grid9 .product-image9 img {
        width: 100%;
        height: auto
    }

    .product-grid9 .pic-1 {
        opacity: 1;
        transition: all .5s ease-out 0s
    }

    .product-grid9:hover .pic-1 {
        opacity: 0
    }

    .product-grid9 .pic-2 {
        position: absolute;
        top: 0;
        left: 0;
        opacity: 0;
        transition: all .5s ease-out 0s
    }

    .product-grid9:hover .pic-2 {
        opacity: 1
    }

    .product-grid9 .product-full-view {
        color: #505050;
        background-color: #fff;
        font-size: 16px;
        height: 45px;
        width: 45px;
        padding: 18px;
        border-radius: 100px 0 0;
        display: block;
        opacity: 0;
        position: absolute;
        right: 0;
        bottom: 0;
        transition: all .3s ease 0s
    }

        .product-grid9 .product-full-view:hover {
            color: #c0392b
        }

    .product-grid9:hover .product-full-view {
        opacity: 1
    }

    .product-grid9 .product-content {
        padding: 12px 12px 0;
        overflow: hidden;
        position: relative
    }

.product-content .rating {
    padding: 0;
    margin: 0 0 7px;
    list-style: none
}

.product-grid9 .rating li {
    font-size: 12px;
    color: #ffd200;
    transition: all .3s ease 0s
}

    .product-grid9 .rating li.disable {
        color: rgba(0,0,0,.2)
    }

.product-grid9 .title {
    font-size: 16px;
    font-weight: 400;
    text-transform: capitalize;
    margin: 0 0 3px;
    transition: all .3s ease 0s
}

    .product-grid9 .title a {
        color: rgba(0,0,0,.5)
    }

        .product-grid9 .title a:hover {
            color: #c0392b
        }

.product-grid9 .price {
    color: #000;
    font-size: 17px;
    margin: 0;
    display: block;
    transition: all .5s ease 0s
}

.product-grid9:hover .price {
    opacity: 0
}

.product-grid9 .add-to-cart {
    display: block;
    color: #c0392b;
    font-weight: 600;
    font-size: 14px;
    opacity: 0;
    position: absolute;
    left: 10px;
    bottom: -20px;
    transition: all .5s ease 0s
}

.product-grid9:hover .add-to-cart {
    opacity: 1;
    bottom: 0
}

@media only screen and (max-width:990px) {
    .product-grid9 {
        margin-bottom: 30px
    }
}
        @media (min-width: 1200px) {
            .container, .container-lg, .container-md, .container-sm, .container-xl {
                max-width: 900px;
            }
        }
    </style>
    <section>

      
             
                                <div>
                                    <p style="font-size: 30px; font-family: Verdana, Geneva, Tahoma, sans-serif;">כאן תוכל להעלות תמונות לאבלום התמונות שלך במספרה </p>
                                  
                                </div>

        
    </section>
    <div class="container" style="padding:5%;">
    
          <div class="form-group">
              <asp:DropDownList ID="CutDropDown" class="form-control"  runat="server" OnSelectedIndexChanged="CutDropDown_SelectedIndexChanged" >
                  <asp:ListItem Text="בחר קטגורייה" Value="0"></asp:ListItem>
                  <asp:ListItem Text="מכונת תספורת" Value="1"></asp:ListItem>
                  <asp:ListItem Text="מסרק" Value="2"></asp:ListItem>
                  <asp:ListItem Text="סכין" Value="3"></asp:ListItem>
                  <asp:ListItem Text="ערכת תספורת" Value="4"></asp:ListItem>
                  <asp:ListItem Text="מספריים" Value="5"></asp:ListItem>
                  <asp:ListItem Text="קרמים" Value="6"></asp:ListItem>
                  <asp:ListItem Text="סינרים" Value="7"></asp:ListItem>
              </asp:DropDownList>
              
            </div>
            <div class="form-group">
                   <asp:TextBox ID="txtproductName" class="form-control" placeholder="שם המוצר"  runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                   <asp:TextBox ID="txtPric" class="form-control" placeholder="מחיר"  runat="server" TextMode="Number"></asp:TextBox>
            </div>
            <div class="form-group">
               <asp:TextBox ID="txtCapacity" class="form-control" placeholder="כמות" runat="server" TextMode="Number"></asp:TextBox>

            </div>
            <div class="form-group">
               <asp:TextBox ID="txtnote" class="form-control" placeholder=" תיאור המוצר בקצרה" runat="server"></asp:TextBox>

            </div>
        
            <div class="form-group">
                    <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" />

            </div>
             <div class="form-group">
                     <asp:Button ID="btnUPPic" class="form-control" runat="server" Text="העלה מוצר" OnClick="btnUPPic_Click" />

            
        </div>
         <div class="form-group">
    <asp:Button ID="BtnUpload" runat="server" class="btn btn-warning btn-lg btn-block" Text="רענן רשימת מוצרים" OnClick="BtnUpload_Click" />

            
        </div>
    </div>
    <asp:Panel ID="Panel1" runat="server" BorderColor="Fuchsia" BorderStyle="Inset"></asp:Panel>


</asp:Content>
 