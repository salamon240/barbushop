<%@ Page Title="" Language="C#" MasterPageFile="~/managerMster.Master" AutoEventWireup="true" CodeBehind="managerMain.aspx.cs" Inherits="barbushop.managerMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/managerMain.css" rel="stylesheet" />
    <link href="css/mainStyle.css" rel="stylesheet" />
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
               text: '  השינויים נשמרו   !',
           })
       }
    </script>
    <div class="jumbotron">
        <style>
            **/

body {
  background: #F1F3FA;
}

/* Profile container */
.profile {
  margin: 20px 0;
}

/* Profile sidebar */
.profile-sidebar {
  padding: 20px 0 10px 0;
  background: #fff;
}

.profile-userpic img {
  float: none;
  margin: 0 auto;
  width: 50%;
  height: 50%;
  -webkit-border-radius: 50% !important;
  -moz-border-radius: 50% !important;
  border-radius: 50% !important;
}

.profile-usertitle {
  text-align: center;
  margin-top: 20px;
}

.profile-usertitle-name {
  color: #5a7391;
  font-size: 16px;
  font-weight: 600;
  margin-bottom: 7px;
}

.profile-usertitle-job {
  text-transform: uppercase;
  color: #5b9bd1;
  font-size: 12px;
  font-weight: 600;
  margin-bottom: 15px;
}

.profile-userbuttons {
  text-align: center;
  margin-top: 10px;
}

.profile-userbuttons .btn {
  text-transform: uppercase;
  font-size: 11px;
  font-weight: 600;
  padding: 6px 15px;
  margin-right: 5px;
}

.profile-userbuttons .btn:last-child {
  margin-right: 0px;
}
    
.profile-usermenu {
  margin-top: 30px;
}

.profile-usermenu ul li {
  border-bottom: 1px solid #f0f4f7;
}

.profile-usermenu ul li:last-child {
  border-bottom: none;
}

.profile-usermenu ul li a {
  color: #93a3b5;
  font-size: 14px;
  font-weight: 400;
}

.profile-usermenu ul li a i {
  margin-right: 8px;
  font-size: 14px;
}

.profile-usermenu ul li a:hover {
  background-color: #fafcfd;
  color: #5b9bd1;
}

.profile-usermenu ul li.active {
  border-bottom: none;
}

.profile-usermenu ul li.active a {
  color: #5b9bd1;
  background-color: #f6f9fb;
  border-left: 2px solid #5b9bd1;
  margin-left: -2px;
}

/* Profile Content */
.profile-content {
  padding: 20px;
  background: #fff;
  min-height: 460px;
}
        </style>
        <div class="container">
    <div class="row profile">
		<div class="col-md-3">
			<div class="profile-sidebar" style="      border-radius: 15px;  text-align: center;">
				<!-- SIDEBAR USERPIC -->
                <asp:Repeater ID="Repeater2" runat="server">
                                          <ItemTemplate>
				<div class="profile-userpic">
					<img src="image/mainPage/Profile/<%#Eval("BarbName")%>" class="img-responsive" alt="">
				</div>
                       
				<!-- END SIDEBAR USERPIC -->
				<!-- SIDEBAR USER TITLE -->
				<div class="profile-usertitle">
					<div class="profile-usertitle-name">
						<%#Eval("FirstName")%> 
					</div>
					<div class="profile-usertitle-job">
						<%#Eval("LastName")%>
					</div>
				</div>
                                                                     </ItemTemplate>
                    </asp:Repeater>
				<!-- END SIDEBAR USER TITLE -->
				<!-- SIDEBAR BUTTONS -->
				<div class="profile-userbuttons">
                   <asp:Button ID="btnUPPic" class="btn btn-success btn-sm" runat="server" Text=" בחר תמונות פרופיל" OnClick="btnUPPic_Click"   />

                   <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" Visible="False" />
                <asp:Button ID="btnUpload" class="btn btn-danger btn-sm" runat="server" Visible="False" Text=" אישור" OnClick="btnUpload_Click" />

				<%--	<button type="button" class="btn btn-success btn-sm">Follow</button>
					<button type="button" class="btn btn-danger btn-sm">Message</button>--%>
				</div>
				<!-- END SIDEBAR BUTTONS -->
				<!-- SIDEBAR MENU -->
				<div class="profile-usermenu">
					<%--<ul class="nav">
						<li class="active">
							<a href="#">
							<i class="glyphicon glyphicon-home"></i>
							Overview </a>
						</li>
						<li>
							<a href="#">
							<i class="glyphicon glyphicon-user"></i>
							Account Settings </a>
						</li>
						<li>
							<a href="#" target="_blank">
							<i class="glyphicon glyphicon-ok"></i>
							Tasks </a>
						</li>
						<li>
							<a href="#">
							<i class="glyphicon glyphicon-flag"></i>
							Help </a>
						</li>
					</ul>--%>
				</div>
				<!-- END MENU -->
			</div>
		</div>
        		<div class="col-md-6">
                    <h1 style="color:white;">ברוך הבא למספרה שלך</h1>
</div>
        </div>
            </div>
        
 <asp:Repeater ID="RepBarName" runat="server">
                                          <ItemTemplate>

<%--    <h1 style="color:white;">ברוך הבא<%#Eval("BarbName") %></h1>--%>
        </ItemTemplate>
     </asp:Repeater>

   </div>
    <div dir="rtl">
        <h2>מסתפר עכשיו</h2>
        <section>
            <div  class="container" style="text-align:center;">
            <div>
                <asp:Repeater ID="Repeater1" runat="server">
                                          <ItemTemplate>
               <div class="row">
                   <div class="col-12">
                                       <asp:Label ID="lblHiarCutNow" runat="server" Text=<%#Eval("FirstName") %>></asp:Label>

                   </div>
               </div>
                                              </ItemTemplate>
                    </asp:Repeater>
                <div class="container">
                    <div class="row">
                        <div class="col-12">
                    <img alt=""  style="height:300px;" src="image/backg/New Project.png" />
                </div>
                        <div style="padding-right: 45%;" class="row">
                            <div  class="col-12">
                                    <asp:Button ID="nextUser" runat="server" CssClass="btn btn-primary " Text="לקוח הבא" OnClick="nextUser_Click" />

                </div>
                        </div>
                
                    </div>
                </div>
                
                <br />
            </div>
                </div>
        </section>
        <h1>לוח זמנים יומי</h1>
          <div class="container" style="direction:ltr">
                             <div class="row">
                                 <div class="col-12">
                                 <table class="table" style="text-align:right;">
  <thead class="thead-dark">
    <tr>
      <th scope="col">שם פרטי</th>
        <th scope="col"> שם משפחה</th>
      <th scope="col"> דואר אלקטרוני </th>
      <th scope="col">פלאפון</th>
        <th scope="col">תספורת</th>
        <th scope="col">שעה</th>
    </tr>
  </thead>
  <tbody>
 
                                      <asp:Repeater ID="MeetingsDay" runat="server">
                                          <ItemTemplate>
                                              <tr>
                                                
                                                
                                                  <td><%#Eval("FirstName") %></td>
                                                  
                                                   <td><%#Eval("LastName") %></td>
                                                 <td><%#Eval("Email") %></td>
                                                <td><%#Eval("PhoneNumber") %></td>
                                                  <td><%#Eval("HairCut") %></td>
                                                  
                                                   <td><%#Eval("Time") %></td>
                                                 
                                            
                                                  
                                            </tr>
                                          </ItemTemplate>
                                      </asp:Repeater>
                                        <asp:Literal ID="Ltlmeeting" runat="server" />
  </tbody>
</table>


                                 </div>
                             </div>
                             <div class="row">
                                 <div class="col-12">

                                 </div>
                             </div>

                         </div>
                   

        </div>
    
</asp:Content>
