<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MangerProductCencelInfo.aspx.cs" Inherits="barbushop.MangerProductCencelInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet"/ >
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <title></title>
</head>
<body>
      <style>
        body {
background-image: url(image/mainPage/bbb.jpg);
    background-repeat: no-repeat;
    background-size: cover;
}        
        .note
{
    text-align: center;
    height: 80px;
    background: -webkit-linear-gradient(left, #0072ff, #8811c5);
    color: #fff;
    font-weight: bold;
    line-height: 80px;
}
.form-content
{
    padding: 5%;
    border: 1px solid #ced4da;
    margin-bottom: 2%;
}
.form-control{
    border-radius:1.5rem;
}
.btnSubmit
{
    border:none;
    border-radius:1.5rem;
    padding: 1%;
    width: 20%;
    cursor: pointer;
    background: #0062cc;
    color: #fff;
}
    </style>
    <form id="form1" runat="server">
        


<div class="container register-form" style="padding:50px;">
            <div class="form" style="background-color:aliceblue;">
                <div class="note">
                    <p>פרטי הזמנה</p>
                </div>

                <div class="form-content" style="direction:rtl;">
                    <div class="row">
                       <div class="panel panel-default">
                        <div class="panel-heading" style="text-align:right;">
                            <i class="fa fa-bar-chart-o fa-fw"></i> <asp:Label ID="LabStatus" runat="server" Text=""></asp:Label>
                            <div class="pull-left">
                                
                            </div>
                        </div>
                        <!-- /.panel-heading -->
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-lg-12">
                                    <div class="table-responsive">
                                        <table class="table table-bordered table-hover table-striped" style="direction:rtl;">
                                              <thead >
    <tr>
    <th scope="col">   קוד מוצר</th>
        <th scope="col">   שם מוצר</th>
        <th scope="col">   כמות</th>
        <th scope="col">  כמות במלאי</th>
        <th scope="col">   תאריך הזמנה</th>
         <th scope="col">   מחיר ליחידה </th>
         <th scope="col">   תמונה </th>
        <th scope="col">   סטטוס הזמנה </th>
    </tr>
  </thead>
  <tbody style="text-align:right;">
                                      <asp:Repeater ID="repOrderDetils" runat="server">
                                          <ItemTemplate>
                                              <tr>
                                              <td><%#Eval("productId") %></td>
                                                  <td><%#Eval("ProdName") %></td>
                                                  <td><%#Eval("amunt") %></td>
                                                   <td><%#Eval("ProdCapacity") %></td>
                                                 <td><%#Eval("OrderDate") %></td>
                                                 <td><%#Eval("ProdPriceType") %></td>
                                                   <td><img style="width:50px;" src="image/mainPage/products/<%#Eval("ProdPicname") %>"/></td>
                                                 
                                                  <td><%#Eval("orderStatus") %></td>
                                            </tr>
                                          </ItemTemplate>
                                      </asp:Repeater>
                                        <asp:Literal ID="Literal5" runat="server" />
      </tbody>
                                        </table> 
                                    </div>
                                    <!-- /.table-responsive -->
                                </div>
                                <!-- /.col-lg-4 (nested) -->
                                <div class="col-lg-8">
                                    <div id="morris-bar-chart"></div>
                                </div>
                                <!-- /.col-lg-8 (nested) -->
                            </div>
                            <!-- /.row -->
                        </div>

                        <!-- /.panel-body -->
                    </div>
                    </div>
                    <a type="button" class="btnSubmit" href="MangerCancel.aspx" style="float:right; text-align:center;">חזרה</a>
                </div>
            </div>
        </div>
        
    </form>
</body>
</html>
