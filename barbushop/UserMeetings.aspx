<%@ Page Title="" Language="C#" MasterPageFile="~/user.Master" AutoEventWireup="true" CodeBehind="UserMeetings.aspx.cs" Inherits="barbushop.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
body {font-family: Arial, Helvetica, sans-serif;}
* {box-sizing: border-box;}

/* Button used to open the contact form - fixed at the bottom of the page */
.open-button {
  background-color: #0062cc;
  color: white;
  padding: 16px 20px;
  border: none;
  cursor: pointer;
  opacity: 0.8;
/*  position: fixed;
*/  bottom: 23px;
  right: 28px;
  width: 280px;
}

/* The popup form - hidden by default */
.form-popup {
  display: none;
  position: fixed;
    bottom: 122px;
    right: 186px;
  border: 3px solid #f1f1f1;
  z-index: 9;
      background-color: beige;
          text-align: right;
}

/* Add styles to the form container */
.form-container {
  max-width: 300px;
  padding: 10px;
  background-color: white;
}

/* Full-width input fields */
.form-container input[type=text], .form-container input[type=password] {
  width: 100%;
  padding: 15px;
  margin: 5px 0 22px 0;
  border: none;
  background: #f1f1f1;
}

/* When the inputs get focus, do something */
.form-container input[type=text]:focus, .form-container input[type=password]:focus {
  background-color: #ddd;
  outline: none;
}

/* Set a style for the submit/login button */
.form-container .btn {
  background-color: #4CAF50;
  color: white;
  padding: 16px 20px;
  border: none;
  cursor: pointer;
  width: 100%;
  margin-bottom:10px;
  opacity: 0.8;
}

/* Add a red background color to the cancel button */
.form-container .cancel {
  background-color: red;
}

/* Add some hover effects to buttons */
.form-container .btn:hover, .open-button:hover {
  opacity: 1;
}
</style>



    <div class="container">
        <div class="row">
            <div class="col-12" style="text-align:right;     padding-bottom: 20px;">
                
<h2>התורים שקבעת</h2>
<p>לחץ על הפתור כדי לראות את התור הבא שלך </p>
<%--<p>Note that the button and the form is fixed - they will always be positioned to the bottom of the browser window.</p>--%>

<button class="open-button" onclick="openForm()"> התור הבא</button>
            </div>
            <div class="col-12">
                <div class="panel panel-default">
                        <div class="panel-heading" style="text-align:right;">
                            <i class="fa fa-bar-chart-o fa-fw"></i>  היסטורית תורים
                            <div class="pull-left">
                                
                            </div>
                        </div>
                        <!-- /.panel-heading -->
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-lg-12">
                                    <div class="table-responsive">
                                        <table class="table table-bordered table-hover table-striped" style="direction:rtl; text-align: right;">
                                              <thead >
    <tr>
      <th scope="col">שם המספרה  </th>
      <th scope="col">פלאפון </th>
        <th scope="col">כתובת  </th>
      <th scope="col">שעה </th>
      <th scope="col">  תאריך פגישה </th>
        <th scope="col">  סוג תספורת  </th>
        <th scope="col">  שם הספר  </th>
    </tr>
  </thead> 
  <tbody style="text-align:right;">
                                      <asp:Repeater ID="MetingsList" runat="server">
                                          <ItemTemplate>
                                              <tr>
                                                
                                                  <td><%#Eval("BarbName") %></td>
                                                  <td><%#Eval("pHonNumber") %></td>
                                                   <td><%#Eval("Address") %></td>
                                                 <td><%#Eval("Time") %></td>
                                                 <td><%#Eval("MeetingDate") %></td>
                                                  <td><%#Eval("HairCut") %></td>
                                                  <td><%#Eval("BarberName") %></td>
                                                  
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
        </div>
    </div>

<div class="form-popup" id="myForm">
  <form action="/action_page.php" class="form-container">
    <h1 style="color:black;">התור הבא </h1>
      <div class="col-12">
    <p>שם הספר :<asp:Label ID="lblbarberName" runat="server" Text=""></asp:Label></p>
              <p>שם המספרה: <asp:Label ID="LabarNAME" runat="server" Text=""></asp:Label></p>
                        <p>סוג התספורת: <asp:Label ID="LaHiarStyle" runat="server" Text=""></asp:Label></p>
                        <p> כמה ימים לתור: <asp:Label ID="lblHiarCutNow" runat="server" Text=""></asp:Label></p>
          <p>  <asp:Label ID="LabTody" runat="server" Text=""></asp:Label></p>
    <input type="text" placeholder="Enter Email"  name="email" required hidden="hidden">

                           <img alt=""  style="height:300px;" src="image/backg/New Project.png" />
          </div>
<div class="col-12">
   <%-- <button type="submit" class="btn">Login</button>--%>
    <button type="button" class="btn cancel" onclick="closeForm()">סגור</button>
    </div>
  </form>
</div>

<script>
function openForm() {
  document.getElementById("myForm").style.display = "block";
}

function closeForm() {
  document.getElementById("myForm").style.display = "none";
}
</script>
</asp:Content>
