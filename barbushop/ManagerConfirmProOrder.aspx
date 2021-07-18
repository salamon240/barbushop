<%@ Page Title="" Language="C#" MasterPageFile="~/managerMster.Master" AutoEventWireup="true" CodeBehind="ManagerConfirmProOrder.aspx.cs" Inherits="barbushop.ManagerConfirmProOrder" %>
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

     <div id="wrapper" style="background: -webkit-linear-gradient(riget, #fafbfb, #fd92cd) !important;">

        <!-- Navigation --> <!-- /.panel-heading -->
                        
                        <!-- /.panel-body -->
     

        <div id="page-wrapper" style="background: -webkit-linear-gradient(top, #fafbfb, #fd92cd) !important;">

              <div class="row">
                <div class="col-lg-8">
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
      <th scope="col"> שם פרטי</th>
      <th scope="col">שם משפחה  </th>
      <th scope="col"> פלאפון </th>
        <th scope="col">עיר  </th>
      <th scope="col">   דואר אלקטורני</th>
        <th scope="col">   שם מוצר</th>
        <th scope="col">   כמות</th>
        <th scope="col">  כמות במלאי</th>
        <th scope="col">   תאריך הזמנה</th>
         <th scope="col">   מספר הזמנה</th>
         <th scope="col">   תמונה </th>
         <th scope="col">   אישור </th>
    </tr>
  </thead>
  <tbody style="text-align:right;">
                                      <asp:Repeater ID="prodOrder" runat="server">
                                          <ItemTemplate>
                                              <tr>
                                                  <td><%#Eval("FirstName") %></td>
                                                
                                                  <td><%#Eval("LastName") %></td>
                                                  <td><%#Eval("PhonNumber") %></td>
                                                   <td><%#Eval("Address") %></td>
                                                  <td><%#Eval("Email") %></td>
                                                
                                                  <td><%#Eval("ProdName") %></td>
                                                  <td><%#Eval("amunt") %></td>
                                                   <td><%#Eval("ProdCapacity") %></td>
                                                 <td><%#Eval("OrderDate") %></td>
                                                
                                                 <td><%#Eval("OrderID") %></td>
                                                   <td><img style="width:50px;" src="image/mainPage/products/<%#Eval("ProdPicname") %>"/></td>
                                                     <td>
                        <%--<asp:LinkButton runat="server" ID="<%# Eval("MeetingID") %>" OnClick="test" </asp:LinkButton>--%>
                        <asp:LinkButton runat="server" ID="confirm"
                            OnCommand="confirmlOrder"
                            CommandArgument='<%# Eval("OrderID") %>'>
                            <div class="someID">אישור</div>
                        </asp:LinkButton>

                    </td>
                                            </tr>
                                          </ItemTemplate>
                                      </asp:Repeater>
                                        <asp:Literal ID="Literal3" runat="server" />
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



            </div>
         </div>
</asp:Content>
