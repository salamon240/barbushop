<%@ Page Title="" Language="C#" MasterPageFile="~/managerMster.Master" AutoEventWireup="true" CodeBehind="ManagerSerchOrder.aspx.cs" Inherits="barbushop.ManagerSerchOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

          <link href="css/rtl/bootstrap.min.css" rel="stylesheet">
    <link href="css/rtl/sb-admin-2.css" rel="stylesheet" />
    <link href="css/rtl/bootstrap.min.css" rel="stylesheet" />
    <link href="css/rtl/bootstrap.rtl.css" rel="stylesheet" />
<%--    <link href="css/rtl/sb-admin-2.css" rel="stylesheet" />--%>
    <link href="css/mainStyle.css" rel="stylesheet" />
    <link href="css/person.css" rel="stylesheet" />
    <style>
          
      #ButSerch
      {
         border-radius: 10px;
           width: 10%;

      }             

#page-wrapper 
{
    position: inherit;
/*    margin: 0 50px 0 0;
*/    padding: 0;
    border-right: 0;
}
        .link-person {
            text-align: right;
            padding-right: 25px;
            font-size: 25px;
            
        }
h1.prsonl{
    color:white;
    color:aliceblue;
    font-size:80px;
}
p.prson{
    color:white;
}
.calender{
    width:inherit;
}
    </style>
    
     <div class="jumbotron">
         <div class="container">

        
    <div class="row">
        <div class="col-12">
           
                   <h1 class="prsonl">  חיפוש הזמנות</h1>
<br />
    <div>
    <p class="prson">כאן תוכל לחפש הזמנות  של הלקוחות  שלך</p>
    <p class="prson"> </p>

    </div>
       
   </div>
        </div>

    </div>
     </div>

     <div id="wrapper" style="background: -webkit-linear-gradient(riget, #fafbfb, #fd92cd) !important;">

        <!-- Navigation --> <!-- /.panel-heading -->
                        
                        <!-- /.panel-body -->
     

        <div id="page-wrapper" style="background: -webkit-linear-gradient(top, #fafbfb, #fd92cd) !important;">
<div class="row" style="text-align:right;">
    <div class="col-12" style="    padding-right: 25px;">
            <asp:TextBox ID="TexEmail" class="form-control" style="width: 20%;" placeholder="הכנס דואר אלקטרוני" runat="server"></asp:TextBox>

    </div>
</div>
            <div class="row" style="text-align:right;">
    <div class="col-12">
        <asp:Button ID="ButSerch" runat="server" style="border-radius:10px; width:10%;" class="btn-outline-primary" Text="חיפוש" OnClick="serch1" />

    </div>
</div>

    <div class="panel panel-default">
                        <div class="panel-heading" style="text-align:right;">
                            <i class="fa fa-bar-chart-o fa-fw"></i>  הזמנות 
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
     <th scope="col">  הצג פרטים</th>
      <th scope="col"> שם פרטי</th>
      <th scope="col">שם משפחה  </th>
      <th scope="col"> פלאפון </th>
        <th scope="col">עיר  </th>
      <th scope="col">   דואר אלקטורני</th>
        <th scope="col">   תאריך הזמנה</th>
         <th scope="col">   מספר הזמנה</th>
        <th scope="col">   סטטוס הזמנה </th>
    </tr>
  </thead>
  <tbody style="text-align:right;">
                                      <asp:Repeater ID="RepCancel" runat="server">
                                          <ItemTemplate>
                                              <tr>
                                                     <td><a class="add-to-cart" style="color:darkcyan; float:right;"  href="ManagerSerchOrderInfo.aspx?OrderID=<%#Eval("OrderID")%>"> פרטים</a></td>
                                                  <td><%#Eval("FirstName") %></td>
                                                  <td><%#Eval("LastName") %></td>

                                                  <td><%#Eval("PhoneNumber") %></td>


                                                   <td><%#Eval("Address") %></td>
                                                  <td><%#Eval("Email") %></td>
                                                 
                                                 <td><%#Eval("OrderDate") %></td>
                                                 <td><%#Eval("OrderID") %></td>
                                                 
                                                  <td><%#Eval("orderStatus") %></td>
                                            </tr>
                                          </ItemTemplate>
                                      </asp:Repeater>
                                        <asp:Literal ID="Literal7" runat="server" />
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
         </div>


</asp:Content>
