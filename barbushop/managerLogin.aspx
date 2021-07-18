 <%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="managerLogin.aspx.cs" Inherits="barbushop.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <link href="css/registration.css" rel="stylesheet" />
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script> 
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->

    <style>
        body{
            background: url(/image/mainPage/regi/barber-shop-realistic.jpg);
    background-repeat: no-repeat;
    background-position: center;
    background-attachment: fixed;
}
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
                                                <ul class="nav nav-tabs nav-justified" id="myTab" role="tablist">
                            <li class="nav-item">
                                <a class="nav-link active" id="home-tab" data-toggle="tab" href="#home" role="tab" aria-controls="home" aria-selected="true"> שלב 1</a>
                            </li>
                           
                                                     <li class="nav-item">
                                <a class="nav-link" id="profile-tab" data-toggle="tab" href="#profile" role="tab" aria-controls="profile" aria-selected="false"> שלב 2</a>
                            </li>
                        </ul>

                        <%--<ul class="nav nav-tabs nav-justified" id="myTab" role="tablist">
                          
                            <li class="nav-item">
                                <a class="nav-link" id="profile-tab" data-toggle="tab" href="#profile" role="tab" aria-controls="profile" aria-selected="false">ספר</a>
                            </li>
                        </ul>--%>
                        <div class="tab-content" id="myTabContent">
                            <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
                                <h3 class="register-heading">הרשמה כספר</h3>
                                <div class="row register-form">
                                    <div class="col-md-6">
                                        <div class="form-group">
                                                   <asp:TextBox ID="TextFname" runat="server" class="form-control" aria-describedby="emailHelp" placeholder="שם פרטי"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="מלא שם פרטי.." ControlToValidate="TextFname" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                        <div class="form-group">
                                              <asp:TextBox ID="TextLname" runat="server" class="form-control" aria-describedby="emailHelp" placeholder="שם משפחה"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="מלא שם משפחה.." ControlToValidate="TextLname" ForeColor="Red"></asp:RequiredFieldValidator>

                                        </div>
                                        <div class="form-group">
                                                           <asp:TextBox ID="TextPassword" runat="server" class="form-control" aria-describedby="emailHelp" placeholder="סיסמא" TextMode="Password">הכנס סיסמא</asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="מלא סיסמא.." ControlToValidate="TextPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                          
                                        </div>
                                        <div class="form-group">
                                                  <asp:TextBox ID="TextBox1" runat="server" class="form-control" aria-describedby="emailHelp" placeholder="אישור סיסמא" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="אשר סיסמא.." ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="סיסמא לא תואמת .." ControlToCompare="TextBox1" ControlToValidate="TextPassword" ForeColor="Red"></asp:CompareValidator>
                            
                                        </div>
                                        <%--<div class="form-group">
                                            <div class="maxl" style="float:right;>
                                                <label class="radio inline"> 
                                                    <input type="radio" name="gender" value="male" checked>
                                                    <span> גבר </span> 
                                                </label>
                                                <label class="radio inline"> 
                                                    <input type="radio" name="gender" value="female">
                                                    <span>אישה </span> 
                                                </label>
                                            </div>
                                        </div>--%>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                             <asp:TextBox ID="TextEmail" runat="server" class="form-control" aria-describedby="emailHelp" placeholder="הכנס מייל "></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="מלא Email.." ControlToValidate="TextEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                           <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="email לא תקין.." ControlToValidate="TextEmail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                            
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox ID="Textphon" runat="server" class="form-control" aria-describedby="emailHelp" placeholder="פלאפון"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ForeColor="Red" ErrorMessage="מספר טלפון לא תקין" ValidationExpression="\b0\d\d{8}\b|\b0\d\d{7}\b" ControlToValidate="Textphon"></asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="מלא מספר פלאפון.." ControlToValidate="Textphon" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                       <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" class="form-control"></asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage=" בחר עיר.." ControlToValidate="DropDownList1" ForeColor="Red"></asp:RequiredFieldValidator>

                            <div class="form-group">
                       
    
             <%--<div class="form-group">
                     <asp:Button ID="btnUPPic" class="form-control" runat="server" Text="העלה מוצר"  />

            
        </div>--%>
                                
                            <asp:Literal ID="LtlUsers" runat="server"  />
                                        <%-- <asp:Literal ID="Loptions" runat="server" />
                                            <select id="barberCity" runat="server" name="barberCity" class="form-control">
                                              
                                                <%--<option value="10">1</option>
                                                <option value="20">2</option>
                                                <option value="30">3</option>
                                                <option value="40">4</option>
                                                <option value="50">5</option>--%>
                                           <%-- </select>--%> 

                            </div>

<%--                                        <input type="submit" class="btnRegister" id="MangerSignUp" runat="server" onclick="return confirm('האם אתה מאשר את שפרטיך נכונים')" value="הרשמה" />--%>
                                    </div>
                                </div>
                            </div>

                          
                              <div class="tab-pane fade show" id="profile" role="tabpanel" aria-labelledby="profile-tab">
                                <h3  class="register-heading">פרטי מספרה</h3>
                                <div class="row register-form">
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <asp:TextBox ID="TexbarberName" class="form-control" runat="server" placeholder="שם המספרה *"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="בחר שם למספרה..."  ControlToValidate="TexbarberName" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox ID="TexbarberAdrres" class="form-control" runat="server" placeholder="כתובת*"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="בחר כתובת..."  ControlToValidate="TexbarberAdrres" ForeColor="Red"></asp:RequiredFieldValidator>

                                        </div>
                                        <div class="form-group">
                                             <asp:TextBox ID="TexBarberPhon" class="form-control" runat="server" placeholder="מספר טלפון מספרה *"></asp:TextBox>
                                           <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ForeColor="Red" ErrorMessage="מספר טלפון לא תקין" ValidationExpression="\b0\d\d{8}\b|\b0\d\d{7}\b" ControlToValidate="TexBarberPhon"></asp:RegularExpressionValidator>

                                              <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="בחר מספר טלפון מספרה ..."  ControlToValidate="TexBarberPhon" ForeColor="Red"></asp:RequiredFieldValidator>

                                        </div>
                               
                                            
            
                                        <div class="form-group">
                                             <input type="checkbox"  id="checklog" runat="server" class="form-check-input" required/>
            <label class="form-check-label" for="exampleCheck1" style="margin-right: 15px">אני מאשר שכל הפרטים נכונים ואני מאשר אתר <a href="termsOfUse.aspx" target="_blank">תנאי השימוש</a></label>
       
                                        </div>
                                        <asp:Button ID="MangerSignUp" runat="server"  class="btnRegister" Text="הרשמה" OnClick="MangerSignUp_Click"  />


                                    </div>
                                    
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

    
    

                              
           
       
   
</asp:Content>
