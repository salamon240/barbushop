<%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="Userlogin1.aspx.cs" Inherits="barbushop.login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/registration.css" rel="stylesheet" />
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->
    <style>
        .control-label{
            float:right;
        }
    </style>

    <div class="container register">
                <div class="row">
                    <div class="col-md-3 register-left">
                        <img src="image/mainPage/FINAL.png" width="30px"  alt=""/>
                        <h3>Welcome</h3>
                        <p>אתה במרחק לחיצת כפתור מחווית גלישה נהדרת</p>
                    </div>
                    <div class="col-md-9 register-right">
                        
                        <div class="tab-content" id="myTabContent">
                            <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
                                <h3 class="register-heading">הרשמה כלקוח</h3>
                                <div class="row register-form">
                                    <div class="col-md-6">
                                        <div class="form-group">
                                                   <asp:TextBox ID="TextFname" runat="server" class="form-control" aria-describedby="emailHelp" placeholder="שם פרטי"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="מלא שם פרטי.." ControlToValidate="TextFname" ForeColor="Red"></asp:RequiredFieldValidator>
                                            <%--<input type="text" class="form-control" placeholder="First Name *" value="" />--%>
                                        </div>
                                        <div class="form-group">
                                              <asp:TextBox ID="TextLname" runat="server" class="form-control" aria-describedby="emailHelp" placeholder="שם משפחה"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="מלא שם משפחה.." ControlToValidate="TextLname" ForeColor="Red"></asp:RequiredFieldValidator>

<%--                                            <input type="text" class="form-control" placeholder="Last Name *" value="" />--%>
                                        </div>
                                        <div class="form-group">
                                                           <asp:TextBox ID="TextPassword" runat="server" class="form-control" aria-describedby="emailHelp" placeholder="סיסמא" TextMode="Password">הכנס סיסמא</asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="מלא סיסמא.." ControlToValidate="TextPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                          
                                          <%--  <input type="password" class="form-control" placeholder="Password *" value="" />--%>
                                        </div>
                                        <div class="form-group">
                                                  <asp:TextBox ID="TextBox1" runat="server" class="form-control" aria-describedby="emailHelp" placeholder="אישור סיסמא" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="אשר סיסמא.." ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="סיסמא לא תואמת.." ControlToCompare="TextBox1" ControlToValidate="TextPassword" ForeColor="Red"></asp:CompareValidator>
                            
                                            <%--<input type="password" class="form-control"  placeholder="Confirm Password *" value="" />--%>
                                        </div>
                                        <div class="form-group">
                                            <div class="maxl" style="float:right;>
                                                <label class="radio inline" >
                                                    <input type="radio" name="gender" id="genderMale" runat="server" value="male" >
                                                    <span> גבר </span> 
                                                </label>
                                                <label class="radio inline"> 
                                                    <input type="radio" name="gender" id="genderFemale" runat="server" value="female">
                                                    <span>אישה </span> 
                                                </label>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                             <asp:TextBox ID="TextEmail" runat="server" class="form-control" aria-describedby="emailHelp" placeholder="הכנס אימייל"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="מלא Email.." ControlToValidate="TextEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                           <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="email לא תקין.." ControlToValidate="TextEmail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                            
<%--                                            <input type="email" class="form-control" placeholder="Your Email *" value="" />--%>
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox ID="Textphon" runat="server" class="form-control" aria-describedby="emailHelp" placeholder="פלאפון"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ForeColor="Red" ErrorMessage="מספר לא תקין" ValidationExpression="\b0\d\d{8}\b|\b0\d\d{7}\b" ControlToValidate="Textphon"></asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="מלא מספר פלאפון.." ControlToValidate="Textphon" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                        <div class="form-group">
                                           
                    <asp:DropDownList ID="DropDownListCity" class="form-control" placeholder="עיר " runat="server"></asp:DropDownList>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="בחר עיר.." ControlToValidate="DropDownListCity" ForeColor="Red"></asp:RequiredFieldValidator>

                </div>
                                       
                                        <div class="form-group">
                                           <%-- <input type="text" class="form-control" placeholder="Enter Your Answer *" value="" />--%>
                                             <input type="checkbox"  id="checklog" runat="server" class="form-check-input" required/>
            <label class="form-check-label" for="exampleCheck1" style="margin-right 15px">אני מאשר שכל הפרטים נכונים ואני מאשר אתר <a href="termsOfUse.aspx" target="_blank">תנאי השימוש</a></label>
       
                                        </div>
                                        <asp:Button ID="btnUserS" runat="server" class="btnRegister" Text="הרשמה" OnClick="btnUserS_Click" />
<%--                                        <input type="submit" id="" runat="server" class="btnRegister" onclick="return confirm('האם אתה מאשר את שפרטיך נכונים')" value="הרשמה" />--%>
                                    </div>
                                </div>
                            </div>
                            
                        </div>
                    </div>
                </div>

            </div>







  </asp:Content>
