 <%@ Page Title="" Language="C#" MasterPageFile="~/user.Master" AutoEventWireup="true" CodeBehind="UserShoppingCart.aspx.cs" Inherits="barbushop.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/ShoppingCart.css" rel="stylesheet" />
                    <script src="//cdn.jsdelivr.net/npm/sweetalert2@10"></script>



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
               text: '  נשלחה הודעה ללקוח    !',
           })
       }
   </script>
    <style>
       #persona:before {
    font-family: FontAwesome;
    content: "\f014";
}
        body {
    background: #eecda3;
    background: -webkit-linear-gradient(to right, #eecda3, #ef629f);
    background: linear-gradient(to right, #eecda3, #ef629f);
    min-height: 100vh;
    direction:rtl;
    
}
        div.container
        {
            text-align:center;
        }

    </style>
        
 <div class="px-4 px-lg-0">
  <!-- For demo purpose -->
  <div class="container text-white py-5 text-center">
    <h1 class="display-4">עגלת קניות</h1>
    <p class="lead mb-0">כאן תוכל ללראות את ההזמנות שביצעת ובמידת הצורך להסיר </p>
    <p class="lead">חזרה להמשך רכישה <a href="UserProducts.aspx" class="text-white font-italic">
            <u>מוצרים</u></a>
    </p>
  </div>
  <!-- End -->

  <div class="pb-5">
    <div class="container">

      
					
      <div class="row">
        <div class="col-lg-12 p-5 bg-white rounded shadow-sm mb-5">

          <!-- Shopping cart table -->
          <div class="table-responsive">
            <table class="table">
              <thead>
                <tr>
                  <th scope="col" class="border-0 bg-light">
                    <div class="p-2 px-3 text-uppercase">מוצר</div>
                  </th>
                  <th scope="col" class="border-0 bg-light">
                    <div class="py-2 text-uppercase">מחיר</div>
                  </th>
                  <th scope="col" class="border-0 bg-light">
                    <div class="py-2 text-uppercase">כמות</div>
                  </th>
                  <th scope="col" class="border-0 bg-light">
                    <div class="py-2 text-uppercase">הסרה</div>
                  </th>
                </tr>
              </thead>
                
              <tbody>
                     <asp:Repeater ID="shopCart" runat="server">
                                          <ItemTemplate>
                <tr>
                  <th scope="row" class="border-0">
                    <div class="p-2">
                      <img src="image/mainPage/products/<%#Eval("picName") %>"  alt="" width="70" class="img-fluid rounded shadow-sm">
                      <div class="ml-3 d-inline-block align-middle">
                        <h5 class="mb-0"> <a href="#" class="text-dark d-inline-block align-middle"><%#Eval("prodName") %></a></h5><span class="text-muted font-weight-normal font-italic d-block">קטגוריה: מסרקים</span>
                      </div>
                    </div>
                  </th>
                  <td class="border-0 align-middle"><strong><%#Eval("price") %>ש"ח</strong></td>
                  <td class="border-0 align-middle"><strong><%#Eval("Amuont") %></strong></td>

                   
                  <td class="border-0 align-middle">
                      <a href="UserShoppingCart.aspx?remov=<%#Eval("productid") %>" id="persona" style="  font-family: FontAwesome; content: "\f014";"><strong>מחק</strong></a>
                      </td>
                   <%--  <asp:LinkButton runat="server" ID="shop"
                             OnCommand="shopcencel"
                            CommandArgument="#">
                            <div class="someID"><li id="persona" style="  font-family: FontAwesome; content: "\f014";"><strong>מחק</strong></li></div>
                        </asp:LinkButton></td>--%>
                </tr>
                  </ItemTemplate></asp:Repeater>
                       <asp:Literal ID="proFinsh" runat="server" />
              </tbody>
                
            </table>
          </div>
          <!-- End -->
        </div>
      </div>

      <div class="row py-5 p-4 bg-white rounded shadow-sm">
        <div class="col-lg-6">
          <div class="bg-light rounded-pill px-4 py-3 text-uppercase font-weight-bold">קוד קופון</div>
          <div class="p-4">
            <p class="font-italic mb-4">במידה ויש לגם קוד קופון אנא הכנס את הקוד </p>
            <div class="input-group mb-4 border rounded-pill p-2">
              <input type="text" placeholder="הכנס קופון" aria-describedby="button-addon3" class="form-control border-0">
              <div class="input-group-append border-0">
                <button id="button-addon3" type="button" class="btn btn-dark px-4 rounded-pill"><i class="fa fa-gift mr-2"></i>אשר קופון</button>
              </div>
            </div>
          </div>
          <div class="bg-light rounded-pill px-4 py-3 text-uppercase font-weight-bold">פניה למוכר</div>
          <div class="p-4">
            <p class="font-italic mb-4">במידה ותרצה להשאיר הודעה למוכר השאר כאן</p>
            <textarea name="" cols="30" rows="2" class="form-control"></textarea>
          </div>
        </div>
          
   
        <div class="col-lg-6">
          <div class="bg-light rounded-pill px-4 py-3 text-uppercase font-weight-bold">סיכום הזמנות </div>
          <div class="p-4">
            <p class="font-italic mb-4">המוצר יחכה לך במספרה בתיאום מראש .</p>
            <ul class="list-unstyled mb-4">
              <li class="d-flex justify-content-between py-3 border-bottom">
                  <strong class="text-muted">סכום בניים <asp:TextBox ID="tottext" runat="server" ReadOnly="True"></asp:TextBox></strong>

              </li>
<%--              <li class="d-flex justify-content-between py-3 border-bottom"><strong class="text-muted">טיפול ומשלוח</strong><strong>10.00</strong></li>--%>
             <%-- <li class="d-flex justify-content-between py-3 border-bottom">
                  <strong class="text-muted">מע"מ</strong><strong><asp:TextBox ID="newTexs" runat="server" ReadOnly="True"></asp:TextBox></strong>

              </li>--%>
              <li class="d-flex justify-content-between py-3 border-bottom">
                  <strong class="text-muted">מחיר סופי ש"ח:<asp:TextBox ID="TotalPrice" runat="server" ReadOnly="True"></asp:TextBox></strong>

              </li>
            </ul><asp:Button ID="orderF" runat="server" class="btn btn-dark rounded-pill py-2 btn-block" Text="הזמן" OnClick="orderF_Click" />
          </div>
        </div>
      </div>

    </div>
  </div>
</div>

  
           
         
</asp:Content>
