 <%@ Page Title="" Language="C#" MasterPageFile="~/user.Master" AutoEventWireup="true" CodeBehind="UserPreson.aspx.cs" Inherits="barbushop.UserPreson" %>
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
        
#page-wrapper 
{
    position: inherit;
    margin: 0 50px 0 0;
    padding: 0;
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
           
                   <h1 class="prsonl"> איזור האישי</h1>
<br />
    <div>
           <p class="prson">ברוך הבא לאיזור האישי שלך   </p>
    <p class="prson">כאן תוכל לראות את לוח הזמנים העדכני שלך</p>
    <p class="prson">והזמנות שביצעת</p>

    </div>
       
   </div>
        </div>

    </div>
     </div>



    <div id="wrapper">

        <!-- Navigation -->
        

        <div id="page-wrapper">
            <%--<div class="row">
                
                <!-- /.col-lg-12 -->
            </div>--%>
            <!-- /.row -->
            <div class="row">
                <%--<div class="col-lg-3 col-md-6">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="col-xs-4">
                                    <i class="fa fa-comments fa-5x"></i>
                                </div>
                                <div class="col-xs-8 text-right">
                                    <div class="huge">26</div>
                                    <div>תורים!</div>
                                </div>
                            </div>
                        </div>
                        <a href="#">
                            <div class="panel-footer">
                                <span class="pull-left">View Details</span>
                                <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                                <div class="clearfix"></div>
                            </div>
                        </a>
                    </div>
                </div>--%>
                <div class="col-lg-3 col-md-6">
                    <div class="panel panel-green">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="col-xs-4">
                                    <i class="fa fa-tasks fa-5x"></i>
                                </div>
                                <div class="col-xs-8 text-right">
                                    <div  class="huge">
                                        <asp:Label ID="lblMettings" runat="server" Text=""></asp:Label></div>
                                    <div>תורים שהזמנת   !</div>
                                </div>
                            </div>
                        </div>
                        <a href="#">
                            <div class="panel-footer">
                                <div class="clearfix"></div>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6">
                    <div class="panel panel-yellow">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="col-xs-4">
                                    <i class="fa fa-shopping-cart fa-5x"></i>
                                </div>
                                <div class="col-xs-8 text-right">
                                    <div class="huge">
                                        <asp:Label ID="LblOrders" runat="server" Text=""></asp:Label>

                                    </div> 
                                    <div> הזמנות שביצעת!</div>
                                   
                                </div>
                            </div>
                        </div>
                        <a href="#">
                            <div class="panel-footer">
                                <div class="clearfix"></div>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6">
                    <div class="panel panel-red">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="col-xs-4">
                                    <i class="fa fa-support fa-5x"></i>
                                </div>
                             <%--   <asp:Label ID="timedate" runat="server" Text=""></asp:Label>
                                <p id="demo"></p>--%>

                                <div class="col-xs-8 text-right">
                                    <div class="huge"> </div>
                                    <div>ביטול הזמנות/תורים!</div>
                                </div>
                            </div>
                        </div>
                        <a href="UserProdCancel.aspx">
                            <div class="panel-footer">
                                <span class="pull-left">ראה פרטים</span>
                                <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                                <div class="clearfix"></div>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="col-xs-4">
                                    <i class="fa fa-support fa-5x"></i>
                                </div>
                             <%--   <asp:Label ID="timedate" runat="server" Text=""></asp:Label>
                                <p id="demo"></p>--%>

                                <div class="col-xs-8 text-right">
                                    <div class="huge">שינוי פרטים </div>
                                    <div> !</div>
                                </div>
                            </div>
                        </div>
                        <a href="ChangProUser.aspx">
                            <div class="panel-footer">
                                <span class="pull-left">בחירה </span>
                                <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                                <div class="clearfix"></div>
                            </div>
                        </a>
                    </div>
                </div>
            </div>
            <!-- /.row -->
            <div class="row">
                <div class="col-lg-8" style="    padding: 0 100px 0 0;">
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
        <th scope="col">פרטי הזמנה  </th>
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
                    <!-- /.panel -->
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
                    <!-- /.panel -->
              </div>      
                    <!-- /.panel -->
                </div>
                <!-- /.col-lg-8 -->
                
            <!-- /.row -->
        </div>
        <!-- /#page-wrapper -->

    </div>
    

    
    <!-- jQuery Version 1.11.0 -->
    <script src="js/jquery-1.11.0.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="js/bootstrap.min.js"></script>

    <!-- Metis Menu Plugin JavaScript -->
    <script src="js/metisMenu/metisMenu.min.js"></script>

    <!-- Morris Charts JavaScript -->
    <script src="js/raphael/raphael.min.js"></script>
    <script src="js/morris/morris.min.js"></script>

    <!-- Custom Theme JavaScript -->
    <script src="js/sb-admin-2.js"></script>
<%--     <h3>התור שלך</h3>
    <div class="container">
        <div class="row">
            <div class="col-12" >
                <asp:Calendar runat="server" ID="myCalendar" class="calender"
  SelectedDate="2011-01-17" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="500px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="">
    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="12pt" ForeColor="#333333" Height="10pt" />
    <DayStyle Width="14%" />
    <NextPrevStyle Font-Size="13pt" ForeColor="White" />
    <OtherMonthDayStyle ForeColor="#999999" />
    <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
    <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
    <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="18pt" ForeColor="White" Height="14pt" />
    <TodayDayStyle BackColor="#CCCC99" />
    </asp:Calendar>
            </div>
        </div>
    </div>
 
   
    
  <h3> מוצרים שהזמנת</h3>
    <section>
   <div class="container" style="direction:ltr; text-align:center">
       <div class="row">
           <div class="col-12">
               <table class="table">
  <thead class="thead-dark">
    <tr>
      <th scope="col">תאריך הזמנה</th>
      <th scope="col">מחיר</th>
      <th scope="col">מק'ט</th>
      <th scope="col">שם מוצר</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th >12/10/2020</th>
      <td>100 ש"ח</td>
      <td>15468</td>
      <td>מכונת תספורת</td>
    </tr>
    <tr>
      <th >13/10/2020</th>
      <td>20 ש"ח</td>
      <td>6464</td>
      <td>מסרק</td>
    </tr>
    <tr>
      <th >13/10/2020</th>
      <td>30 ש"ח</td>
      <td> 12323</td>
      <td>קרם לשיער</td>
    </tr>
  </tbody>
</table>
           </div>
       </div>
                   


        </div>
    </section>--%>
    <script>
        // Set the date we're counting down to
        var countDownDate = document.getElementById("#timedate").Date; /*new Date("#timedate");*/

// Update the count down every 1 second
var x = setInterval(function() {

  // Get today's date and time
  var now = new Date().getTime();
    
  // Find the distance between now and the count down date
  var distance = countDownDate - now;
    
  // Time calculations for days, hours, minutes and seconds
  var days = Math.floor(distance / (1000 * 60 * 60 * 24));
  var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
  var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
  var seconds = Math.floor((distance % (1000 * 60)) / 1000);
    
  // Output the result in an element with id="demo"
  document.getElementById("demo").innerHTML = days + "d " + hours + "h "
  + minutes + "m " + seconds + "s ";
    
  // If the count down is over, write some text 
  if (distance < 0) {
    clearInterval(x);
    document.getElementById("demo").innerHTML = "EXPIRED";
  }
}, 1000);
    </script>  


</asp:Content>
