<%@ Page Title="" Language="C#" MasterPageFile="~/managerMster.Master" AutoEventWireup="true" CodeBehind="managerPerson.aspx.cs" Inherits="barbushop.managerPerson" %>
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



    <div id="wrapper" style="background: -webkit-linear-gradient(riget, #fafbfb, #fd92cd) !important;">

        <!-- Navigation --> <!-- /.panel-heading -->
                        
                        <!-- /.panel-body -->
     

        <div id="page-wrapper" style="background: -webkit-linear-gradient(top, #fafbfb, #fd92cd) !important;">
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
                                  <i class="fa fa-user fa-5x" aria-hidden="true"></i>
                                </div>
                                <div class="col-xs-8 text-right">
                                    <div class="huge"> +</div>
                                    <div> מלא בחנות</div>
                                </div>
                            </div>
                        </div>
                        <a href="managerAddPic.aspx">
                            <div class="panel-footer">
                                <span class="pull-left">בחירה</span>
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
                                    <div> סך תורים   !</div>
                                </div>
                            </div>
                        </div>
                        <a href="#">
                            <div class="panel-footer">
                                <span class="pull-left">  </span>
                                
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6">
                    <div class="panel panel-yellow">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="col-xs-4">
                                    <i class="fa fa-file fa-5x"></i>
                                </div>
                                <div class="col-xs-8 text-right">
                                    <div class="huge">
                                        <asp:Label ID="LblOrders" runat="server" Text="" ForeColor="Red"></asp:Label>

                                    </div> 
                                    <div>   הזמנות המחכות לאישור!</div>
                                   
                                </div>
                            </div>
                        </div>
                        <a href="MangerCancel.aspx">
                            <div class="panel-footer">
                                <span class="pull-left">כניסה</span>
                                <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
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
                                    <div class="huge">        
                                        <asp:Label ID="Labemp" runat="server" Text=""></asp:Label>
                                      </div>
                                    <div>כמות עובדים !</div>
                                </div>
                            </div>
                        </div>
                        <a href="prodCancel.aspx">
                            <div class="panel-footer">
                                <span class="pull-left">ראה פרטים</span>
                               
                            </div>
                        </a>
                    </div>
                </div>
            </div>
            <!-- /.row -->
            
                <!-- /.col-lg-8 -->
                <div class="row">
                <div class="col-lg-8">
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
      <th scope="col"> שם פרטי</th>
      <th scope="col">שם משפחה  </th>
      <th scope="col">פלאפון </th>
        <th scope="col">דואר אלקטרוני </th>
      <th scope="col">שעה </th>
      <th scope="col">  תאריך פגישה </th>
        <th scope="col">  סוג תספורת  </th>
        <th scope="col">  ספר  </th>
                <th scope="col"> סטטוס פגישה  </th>

    </tr>
  </thead> 
  <tbody style="text-align:right;">
                                      <asp:Repeater ID="MetingsList" runat="server">
                                          <ItemTemplate>
                                              <tr>
                                                  <td><%#Eval("FirstName") %></td>
                                                
                                                  <td><%#Eval("LastName") %></td>
                                                  <td><%#Eval("PhoneNumber") %></td>
                                                   <td><%#Eval("Email") %></td>
                                                 <td><%#Eval("Time") %></td>
                                                 <td><%#Eval("MeetingDate") %></td>
                                                  <td><%#Eval("HairCut") %></td>
                                                  <td><%#Eval("BarberName") %></td>
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
                    <div class="panel panel-default">
                        <div class="panel-heading" style="text-align:right;">
                            <i class="fa fa-bar-chart-o fa-fw"></i>  חופשות עובדים
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
      <th scope="col">פלאפון </th>
        <th scope="col">דואר אלקטרוני </th>
      <th scope="col">תאריך חופש </th>
    </tr>
  </thead> 
  <tbody style="text-align:right;">
                                      <asp:Repeater ID="RepDayOff" runat="server">
                                          <ItemTemplate>
                                              <tr>
                                                  <td><%#Eval("FirstName") %></td>
                                                
                                                  <td><%#Eval("LastName") %></td>
                                                  <td><%#Eval("PhoneNumber") %></td>
                                                   <td><%#Eval("Email") %></td>
                                                 <td><%#Eval("DateDayOff") %></td>
                                                  
                                            </tr>
                                          </ItemTemplate>
                                      </asp:Repeater>
                                        <asp:Literal ID="Literal4" runat="server" />
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
                    <div class="panel panel-default">
                        <div class="panel-heading" style="text-align:right;">
                            <i class="fa fa-bar-chart-o fa-fw"></i>  עובדים
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
      <th scope="col">תפקיד </th>
      <th scope="col">   דואר אלקטורני</th>
    </tr>
  </thead>
  <tbody style="text-align:right;">
                                      <asp:Repeater ID="repEmplo" runat="server">
                                          <ItemTemplate>
                                              <tr>
                                                  <td><%#Eval("FirstName") %></td>
                                                
                                                  <td><%#Eval("LastName") %></td>
                                                  <td><%#Eval("PhoneNumber") %></td>
                                                   <td><%#Eval("Address") %></td>
                                                 <td>ספר</td>
                                                
                                                 <td><%#Eval("Email") %></td>
                                                  
                                            </tr>
                                          </ItemTemplate>
                                      </asp:Repeater>
                                        <asp:Literal ID="Literal2" runat="server" />
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
                    <div class="panel panel-default">
                        <div class="panel-heading" style="text-align:right;">
                            <i class="fa fa-bar-chart-o fa-fw"></i>  הזמנות מחכות לאישור
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
                                      <asp:Repeater ID="prodOrder" runat="server">
                                          <ItemTemplate>
                                              <tr>
                                                   <td><a class="add-to-cart" style="color:darkcyan; float:right;"  href="WebForm10.aspx?OrderID=<%#Eval("OrderID")%>"> פרטים</a></td>
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
                    <div class="panel panel-default">
                        <div class="panel-heading" style="text-align:right;">
                            <i class="fa fa-bar-chart-o fa-fw"></i>  הזמנות שאושרו
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
                                      <asp:Repeater ID="repOrderConfirm" runat="server">
                                          <ItemTemplate>
                                              <tr>
                                                    <td><a class="add-to-cart" style="color:darkcyan; float:right;"  href="WebForm10.aspx?OrderID=<%#Eval("OrderID")%>"> פרטים</a></td>
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
                                        <asp:Literal ID="Literal5" runat="server" />
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
                    <div class="panel panel-default">
                        <div class="panel-heading" style="text-align:right;">
                            <i class="fa fa-bar-chart-o fa-fw"></i>  הזמנות שנאספו
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
                                      <asp:Repeater ID="RepPaid" runat="server">
                                          <ItemTemplate>
                                              <tr>
                                                   <td><a class="add-to-cart" style="color:darkcyan; float:right;"  href="WebForm10.aspx?OrderID=<%#Eval("OrderID")%>"> פרטים</a></td>
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
                                        <asp:Literal ID="Literal6" runat="server" />
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
                    <div class="panel panel-default">
                        <div class="panel-heading" style="text-align:right;">
                            <i class="fa fa-bar-chart-o fa-fw"></i>  הזמנות שבוטלו
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
                                                     <td><a class="add-to-cart" style="color:darkcyan; float:right;"  href="WebForm10.aspx?OrderID=<%#Eval("OrderID")%>"> פרטים</a></td>
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
                    <!-- /.panel -->
                    <div class="row" style="padding-bottom:12px;">
                        <div style="padding-right:20px;" class="col-12">
                            <h4 style="text-align:center; font-size:x-large">בחירת יום חופש</h4>
                        </div>
                        <asp:ScriptManager ID="ScriptManager1" runat="server" ></asp:ScriptManager>

                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server"
               UpdateMode="Conditional">
               <ContentTemplate>
                        <div style="padding-right:200px;" class="col-12">
                            <asp:TextBox ID="TxtDayOff" runat="server" style="visibility: hidden;" Visible="True"></asp:TextBox>
                            <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" AutoPostBack="false" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="240px" NextPrevFormat="FullMonth"  Width="400px" Visible="True" FirstDayOfWeek="Sunday" OnSelectionChanged="Calendar2_SelectionChanged" OnDayRender="Calendar2_DayRender" >
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                        <TodayDayStyle BackColor="#CCCCCC" />
                    </asp:Calendar>
                                            <div style="padding:20px; " class="col-12">
                            <asp:Button ID="Button1" CssClass="btn btn-primary" style="float:right"  runat="server" Text="בחירה" OnClick="Button1_Click" />
                        </div>    
                                   </ContentTemplate></asp:UpdatePanel>                
                           
                        

                        </div>

                    </div>
                    <!-- /.panel -->
                </div>
                <!-- /.col-lg-8 -->
                <div class="col-lg-4">
                    <div class="panel panel-default" style="text-align: right;">
                        <div class="panel-heading">
                            <i class="fa fa-bell fa-fw"></i> משימות
                        </div>
                        <!-- /.panel-heading -->
                        <div class="panel-body">
                            <div class="list-group">
                                <a href="AddEmployees.aspx" class="list-group-item">
                                    <i class="fa fa-comment fa-fw"></i>  הוספת עובד חדש
                                    
                                </a>
                                <a href="managerAddPic.aspx" class="list-group-item">
                                    <i class="fa fa-twitter fa-fw"></i> הכנסת מוצר חדש
                                </a>
                                <a href="ManagerPIc.aspx" class="list-group-item">
                                    <i class="fa fa-envelope fa-fw"></i> שינויי פרטי מוצר
                                </a>
                                <a href="ChangeProManager.aspx" class="list-group-item">
                                    <i class="fa fa-tasks fa-fw"></i> שינויי פרטים אישיים
                                </a>
                                <a href="MangerCancel.aspx" class="list-group-item">
                                    <i class="fa fa-upload fa-fw"></i> ביטול /אישור  
                                </a>
                                <a href="ManagerSerchOrder.aspx" class="list-group-item">
                                    <i class="fa fa-bolt fa-fw"></i> חיפוש הזמנות!
                                </a>
                             
                            </div>
                            <!-- /.list-group -->
<%--                            <a href="#" class="btn btn-default btn-block">View All Alerts</a>--%>
                        </div>
                        <!-- /.panel-body -->
                    </div>
                    <!-- /.panel -->
                    <%--<div class="panel panel-default">
                        <div class="panel-heading">
                            <i class="fa fa-bar-chart-o fa-fw"></i> Donut Chart Example
                        </div>
                        <div class="panel-body">
                            <div id="morris-donut-chart"></div>
                            <a href="#" class="btn btn-default btn-block">View Details</a>
                        </div>
                        <!-- /.panel-body -->
                    </div>--%>
                    <!-- /.panel -->
                    
                    <!-- /.panel .chat-panel -->
                </div>
                <!-- /.col-lg-4 -->
            </div>
            <!-- /.row -->
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


               
</asp:Content>
