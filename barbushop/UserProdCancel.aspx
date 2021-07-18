<%@ Page Title="" Language="C#" MasterPageFile="~/user.Master" AutoEventWireup="true" CodeBehind="UserProdCancel.aspx.cs" Inherits="barbushop.WebForm4" %>
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
               text: '  נשלחה הודעה למספרה    !',
           })
       }
   </script>

    <style>
        .styled-table {
    border-collapse: collapse;
   margin: 52px 280px 66px 38px;
    font-size: 0.9em;
    font-family: sans-serif;
    min-width: 400px;
    box-shadow: 0 0 20px rgba(0, 0, 0, 0.15);
}

.styled-table thead tr {
    background-color: #009879;
    color: #ffffff;
    text-align: left;
}
.styled-table th,
.styled-table td {
    padding: 12px 15px;
}
.styled-table tbody tr {
    border-bottom: 1px solid #dddddd;
}

.styled-table tbody tr:nth-of-type(even) {
    background-color: #f3f3f3;
}

.styled-table tbody tr:last-of-type {
    border-bottom: 2px solid #009879;
}
.styled-table tbody tr.active-row {
    font-weight: bold;
    color: #009879;
}
    </style>

    <div class="jumbotron">
         <div class="container">

        
    <div class="row">
        <div class="col-12">
           
                   <h1 class="prsonl" style="color:white;"> ביטול תורים</h1>
<br />
    <div>
      

    </div>
            
       
   </div>
        </div>

    </div>
     </div>
    <div class="container">
        <div class="row">
            <div class="col-12">
                <div class="panel panel-default">
                        <div class="panel-heading" style="text-align:right;">
                            <i class="fa fa-bar-chart-o fa-fw"></i>  תורים
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
         <th scope="col"> בטל </th>
      <th scope="col"> שם המספרה</th>
        <th scope="col"> שם הספר </th>
      <th scope="col">טלפון מספרה  </th>
      <th scope="col">עיר </th>
        <th scope="col">תאריך בפגישה</th>
      <th scope="col">שעה </th>
      <th scope="col"> סוג תספורת </th>
        <th scope="col"> סטטוס פגישה  </th>

    </tr>
  </thead>
  <tbody style="text-align:right;">
                                      <asp:Repeater ID="MetingsList" runat="server">
                                          <ItemTemplate>
                                              <tr>
                                                  <td>
                        <%--<asp:LinkButton runat="server" ID="<%# Eval("MeetingID") %>" OnClick="test" </asp:LinkButton>--%>
                        <asp:LinkButton runat="server" ID="sasd"
                            OnCommand="test"
                            CommandArgument='<%# Eval("MeetingID") %>'>
                            <div class="someID">בטל</div>
                        </asp:LinkButton>

                    </td>
                                                  <td><%#Eval("BarbName") %></td>
                                                <td><%#Eval("BarberName") %></td>
                                                  <td><%#Eval("phonNumber") %></td>
                                                  <td><%#Eval("Address") %></td>
                                                   <td><%#Eval("MeetingDate") %></td>
                                                 <td><%#Eval("Time") %></td>
                                                
                                                 <td><%#Eval("HairCut") %></td>
                                                  <td><%#Eval("StatusName") %></td>
                                            </tr>
                                          </ItemTemplate>
                                      </asp:Repeater>
                                        <asp:Literal ID="Literal1" runat="server" />
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
               <div class="col-12">
                   <div class="panel panel-default">
                        <div class="panel-heading" style="text-align:right;">
                            <i class="fa fa-bar-chart-o fa-fw"></i> מוצרים שהזמנת
                            <div class="pull-right">
                                
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
                 <th scope="col"> פרטים </th>

         <th scope="col"> הסר </th>
         <th scope="col">מספר הזמנה  </th>
        <th scope="col">תאריך הזמנה </th>
      <th scope="col">טלפון מספרה</th>
        
      <th scope="col"> שם מספרה</th>
        <th scope="col"> כתובת</th>
              <th scope="col">סטטוס הזמנה </th>

    </tr>
  </thead>
   <tbody style="text-align:right;">
                                      <asp:Repeater ID="RptOrder" runat="server">
                                          <ItemTemplate>
                                              <tr>
                                                  
                                                                                                 <td><a class="add-to-cart" style="color:darkcyan; float:right;"  href="UserOrderInfo.aspx?OrderID=<%#Eval("OrderID")%>"> פרטים</a></td>

                                                 <td>
                        <%--<asp:LinkButton runat="server" ID="<%# Eval("MeetingID") %>" OnClick="test" </asp:LinkButton>--%>
                        <asp:LinkButton runat="server" ID="order"
                            OnCommand="orderCencel"
                            CommandArgument='<%# Eval("OrderID") %>'>
                            <div class="someID">הסר</div>
                        </asp:LinkButton>

                    </td>

                                                  <td><%#Eval("OrderID") %></td>
                                                      
                                                   <td><%#Eval("OrderDate") %></td>
                                                 <td><%#Eval("phonNumber") %></td>
                                                   <td><%#Eval("BarbName") %></td>
                                                   <td><%#Eval("Address") %></td>
                                                 
                                                  <td><%#Eval("orderStatus") %></td>
                                               
                                                
                                              
                                              
                                                  
                                            </tr>
                                          </ItemTemplate>
                                      </asp:Repeater>
                                        <asp:Literal ID="LtlUsers" runat="server" />
                                        </table>
                                    </div>
                                    <!-- /.table-responsive -->
                                </div>
                                <!-- /.col-lg-4 (nested) -->
                                <div class="col-lg-8">
                                    <div id="morris-bar-charts"></div>
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




</asp:Content>
