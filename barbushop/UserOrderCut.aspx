<%@ Page Title="" Language="C#" MasterPageFile="~/user.Master" AutoEventWireup="true" CodeBehind="UserOrderCut.aspx.cs" Inherits="barbushop.orderCut" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       

     <link rel="stylesheet" type="text/css" href="css/userMain.css"/>
<%--    <link href="//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">--%>
<script src="//netdna.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js"></script>
    
      <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <link rel="stylesheet" href="/resources/demos/style.css">
     <link href="css/userOrderHairCut.css" rel="stylesheet" />
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
              <script src="//cdn.jsdelivr.net/npm/sweetalert2@10"></script>
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
               text: '   ההזמנה שלך נשמרה    !',
           })
       }
   </script>




   <style>
        * {
    margin: 0;
    padding: 0
}

html {
    height: 100%
}

p {
    color: grey
}

#heading {
    text-transform: uppercase;
    color: #673AB7;
    font-weight: normal;
}

#msform {
    text-align: center;
    position: relative;
    margin-top: 20px
}

#msform fieldset {
    background: white;
    border: 0 none;
    border-radius: 0.5rem;
    box-sizing: border-box;
    width: 100%;
    margin: 0;
    padding-bottom: 20px;
    position:relative;
}

.form-card {
    text-align: left;
}

#msform fieldset:not(:first-of-type) {
    display:none;
}

#msform input,
#msform textarea {
    padding: 8px 15px 8px 15px;
    border: 1px solid #ccc;
    border-radius: 0px;
    margin-bottom: 25px;
    margin-top: 2px;
    width: 100%;
    box-sizing: border-box;
    font-family: montserrat;
    color: #2C3E50;
    background-color: #ECEFF1;
    font-size: 16px;
    letter-spacing: 1px;
}

#msform input:focus,
#msform textarea:focus {
    -moz-box-shadow: none !important;
    -webkit-box-shadow: none !important;
    box-shadow: none !important;
    border: 1px solid #673AB7;
    outline-width: 0;
}

#msform .action-button {
    width: 100px;
    background: #17a2b8;
    font-weight: bold;
    color: white;
    border: 0 none;
    border-radius: 0px;
    cursor: pointer;
    padding: 10px 5px;
    margin: 10px 0px 10px 5px;
    float: right;
}

#msform .action-button:hover,
#msform .action-button:focus {
    background-color: #311B92;
}

#msform .action-button-previous {
    width: 100px;
    background: #616161;
    font-weight: bold;
    color: white;
    border: 0 none;
    border-radius: 0px;
    cursor: pointer;
    padding: 10px 5px;
    margin: 10px 5px 10px 0px;
    float: right;
}

#msform .action-button-previous:hover,
#msform .action-button-previous:focus {
    background-color: #000000;
}

.card {
    z-index: 0;
    border: none;
    position: relative;
}

.fs-title {
    font-size: 25px;
    color: #17a2b8;
    margin-bottom: 15px;
    font-weight: normal;
    text-align: left;
}

.purple-text {
    color: #673AB7;
    font-weight: normal;
}

.steps {
    font-size: 25px;
    color: gray;
    margin-bottom: 10px;
    font-weight: normal;
    text-align: right;
}

.fieldlabels {
    color: gray;
    text-align: left;
}

#progressbar {
    margin-bottom: 30px;
    overflow: hidden;
    color: lightgrey;
}

#progressbar .active {
    color: #17a2b8;
}

#progressbar li {
    list-style-type: none;
    font-size: 15px;
    width: 20%;
    float:right;
    position: relative;
    font-weight: 400;
}

#progressbar #account:before {
    font-family: FontAwesome;
    content: "\f007";
}
#progressbar #personal:before {
    font-family: FontAwesome;
    content: "\f073";
}
#progressbar #finsh:before {
    font-family: FontAwesome;
    content: "\f022";
}

#progressbar #payment:before {
    font-family: FontAwesome;
    content: "\f0c4";
}

#progressbar #confirm:before {
    font-family: FontAwesome;
    content: "\f00c";
}

#progressbar li:before {
    width: 50px;
    height: 50px;
    line-height: 45px;
    display: block;
    font-size: 20px;
    color: #ffffff;
    background: lightgray;
    border-radius: 50%;
    margin: 0 auto 10px auto;
    padding: 2px;
}

#progressbar li:after {
    content: '';
    width: 100%;
    height: 2px;
    background: lightgray;
    position: absolute;
    left: 0;
    top: 25px;
    z-index: -1;
}

#progressbar li.active:before,
#progressbar li.active:after {
    background: #17a2b8;
}

.progress {
    height: 20px;
}

.progress-bar {
    background-color: #17a2b8;
}

.fit-image {
    width: 100%;
    object-fit: cover;
}
.fieldlabelss{
    display: block;
    padding: 8px 15px 8px 15px;
    border: 1px solid #ccc;
    border-radius: 0px;
    margin-bottom: 25px;
    margin-top: 2px;
    width: 100%;
    box-sizing: border-box;
    font-family: montserrat;
    color: #2C3E50;
    background-color: #ECEFF1;
    font-size: 16px;
    letter-spacing: 1px;
}

   


                                      

    </style>

     <script>
         function alertme() {
             Swal.fire({
                 icon: 'success',
                 title: 'הצלחה...',
                 text: '  ההזמנה שלך בוצעה !',
             })
         }
     </script>
    <div class="container-fluid">
    <div class="row justify-content-center">
        <div class="col-11 col-sm-10 col-md-10 col-lg-6 col-xl-5 text-center p-0 mt-3 mb-2">
            <div class="card px-0 pt-4 pb-0 mt-3 mb-3">
                <h2 id="heading">קביעת תור למספרה</h2>
                <p> מלא את כל הפרטים שלב אחר שלב</p>
                <div class="md" id="msform">
                    <!-- progressbar -->
                    <ul id="progressbar">
                        <li class="active" id="account"><strong>שם הספר</strong></li>
                        <li id="personal"><strong>תאריך</strong></li>
                        <li id="payment"><strong>סוג תספורת</strong></li>
                        <li id="finsh"><strong>סיכום</strong></li>
                        <li id="confirm"><strong>Finish</strong></li>
                    </ul>
                    <div class="progress">
                        <div class="progress-bar progress-bar-striped progress-bar-animated" role="progressbar" aria-valuemin="0" aria-valuemax="100"></div>
                    </div> <br> <!-- fieldsets -->
                    <fieldset>
                        <div class="form-card">
                            <div class="row">
                                <div class="col-7">
                                    <h2 class="fs-title">שם הספר</h2>
                                </div>
                                <div class="col-5">
                                    <h2 class="steps">שלב 1 - 5</h2>
                                </div>

                          <asp:DropDownList ID="barbarName" class="fieldlabelss" placeholder="בחר ספר" runat="server"  name="email" OnSelectedIndexChanged="barbarName_SelectedIndexChanged" OnTextChanged="barbarName_TextChanged"></asp:DropDownList>

                            </div> 
                        </div> <input type="button" name="next" class="next action-button" value="הבא" />
                    </fieldset>
                    <fieldset>
                        <div class="form-card">
                            <div class="row">
                                <div class="col-7">
                                    <h2 class="fs-title">תאריך:</h2>
                                </div>
                                <div class="col-5">
                                    <h2 class="steps">שלב 2 - 5</h2>
                                </div>
                            </div> 
                                           <asp:ScriptManager ID="ScriptManager1" runat="server" ></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
        <asp:TextBox ID="txtDate" runat="server"  OnTextChanged="txtDate_TextChanged" ></asp:TextBox>
                   <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" AutoPostBack="false" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="240px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged" Width="400px" Visible="True" FirstDayOfWeek="Sunday" OnDayRender="Calendar1_DayRender">
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                        <TodayDayStyle BackColor="#CCCCCC" />
                    </asp:Calendar>
                    <asp:DropDownList class="fieldlabelss" ID="timepick" runat="server" OnSelectedIndexChanged="timepick_SelectedIndexChanged" Visible="False">
                        <asp:ListItem Text="08:00" Value="0"></asp:ListItem>
                        <asp:ListItem Text="08:30" Value="1"></asp:ListItem>
                        <asp:ListItem Text="09:00" Value="2"></asp:ListItem>
                        <asp:ListItem Text="09:30" Value="3"></asp:ListItem>
                        <asp:ListItem Text="10:00" Value="4"></asp:ListItem>
                        <asp:ListItem Text="10:30" Value="5"></asp:ListItem>
                        <asp:ListItem Text="11:00" Value="6"></asp:ListItem>
                        <asp:ListItem Text="11:30" Value="7"></asp:ListItem>
                        <asp:ListItem Text="12:00" Value="8"></asp:ListItem>
                        <asp:ListItem Text="12:30" Value="9"></asp:ListItem>
                        <asp:ListItem Text="13:00" Value="10"></asp:ListItem>
                        <asp:ListItem Text="13:30" Value="11"></asp:ListItem>
                        <asp:ListItem Text="14:00" Value="12"></asp:ListItem>
                        <asp:ListItem Text="14:30" Value="13"></asp:ListItem>
                        <asp:ListItem Text="15:00" Value="14"></asp:ListItem>
                        <asp:ListItem Text="15:30" Value="15"></asp:ListItem>
                        <asp:ListItem Text="16:00" Value="16"></asp:ListItem>
                        <asp:ListItem Text="16:30" Value="17"></asp:ListItem>
                        <asp:ListItem Text="17:00" Value="18"></asp:ListItem>
                        <asp:ListItem Text="17:30" Value="19"></asp:ListItem>
                        <asp:ListItem Text="18:00" Value="20"></asp:ListItem>
                    </asp:DropDownList>

                                       </ContentTemplate></asp:UpdatePanel>

                        </div> 
                        <input type="button" name="next" class="next action-button"  value="הבא" /> <input type="button" name="previous" class="previous action-button-previous" value="חזור" />
                    </fieldset>
                    <fieldset>
                        <div class="form-card">
                            <div class="row">
                                <div class="col-7">
                                    <h2 class="fs-title">סוג תספורת:</h2>
                                </div>
                                <div class="col-5">
                                    <h2 class="steps">שלב 3 - 5</h2>
                                </div>
                            </div>
                        
                               
                               
                                    <div class="row">
                                        <div class="col-6">
                                            <asp:RadioButton ID="longHair" runat="server" Text="" Checked="True" GroupName="hiarSTyle" TextAlign="Left"  ></asp:RadioButton>

                                            </div>
                                        <div class="col-6">  
                                                    <a class="hiarStyle">שיער ארוך</a>

                                        </div>
                                    </div>
                                    <div class="row">
                                         <div class="col-6">
                                           <asp:RadioButton id="long1" runat="server" Text="" GroupName="hiarSTyle"></asp:RadioButton>                           

                                          
                                            </div>
                                        <div class="col-6">
                                              <a class="hiarStyle">שיער ארוך + זקן</a>
                                        </div>
                                    </div>
                                    <div class="row">
                                         <div class="col-6">
                                             <asp:RadioButton ID="shortHair" runat="server" Text="" GroupName="hiarSTyle"></asp:RadioButton>
                                            
                                            </div>
                                        <div class="col-6">
                                            <a class="hiarStyle">שיער קצר</a>
                                                   

                                        </div>
                                    </div>
                                    <div class="row">
                                         <div class="col-6">
                                            <asp:RadioButton ID="short1" runat="server" Text="" GroupName="hiarSTyle"></asp:RadioButton>
                                            </div>
                                        <div class="col-6">
                                            <a class="hiarStyle">שיער קצר + זקן</a>
                                               

                                            </div>
                                        </div>
                                    <div class="row">
                                         <div class="col-6">
                                            <asp:RadioButton ID="color" runat="server" Text="" GroupName="hiarSTyle"></asp:RadioButton>
                                            </div>
                                        <div class="col-6">
                                            <a class="hiarStyle"> צבע לשיער</a>
                                               

                                            </div>
                                        </div>
                                    <div class="row">
                                         <div class="col-6">
                                            <asp:RadioButton ID="stayling" runat="server" Text="" GroupName="hiarSTyle"></asp:RadioButton>
                                            </div>
                                        <div class="col-6">
                                            <a class="hiarStyle">  עיצוב שיער</a>
                                               

                                            </div>
                                        </div>

                                </div>
                           <%-- <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                                <asp:ListItem Text=" שיער קצר + זקן" Value="1">שיער קצר + זקן</asp:ListItem>
                                <asp:ListItem Text="שיער קצר" Value="2"></asp:ListItem>
                                <asp:ListItem Text="שיער ארוך + זקן" Value="3"></asp:ListItem>
                                <asp:RadioButton runat="server"></asp:RadioButton>
                                <asp:ListItem Text="שיער ארוך" Value="4"></asp:ListItem>
                            </asp:RadioButtonList>--%>
                             <%--   </fieldset>--%>
            
                           
                 
                        
                        <input type="button" name="next" class="next action-button"  value="הבא" /> <input type="button" name="previous" class="previous action-button-previous" value="חזור" />
                    </fieldset>
                       <fieldset>
                        <div class="form-card">
                            <div class="row">
                                <div class="col-7">
                                    <h2 class="fs-title">סיכום :</h2>
                                </div>
                                <div class="col-5">
                                    <h2 class="steps">שלב 4 - 5</h2>
                                </div>
                            </div>
                                 

                             <asp:UpdatePanel ID="UpdatePanel2" runat="server"
               UpdateMode="Conditional">
               <ContentTemplate>
                           <asp:Button ID="Button2" runat="server" Text="סיכום הזמנה "  OnClick="Finish_order" />
                                
                         <div class="container">
                             <div class="row">
                                 <div class="col-12">
                                 <table class="table">
  <thead id="hh" runat="server" class="thead-dark">
    <tr>
      <th scope="col"> שם הספר</th>
      <th scope="col"> תאריך </th>
      <th scope="col">שעה </th>
        <th scope="col">סוג תספורת </th>
    </tr>
  </thead>
  <tbody>
                                     
                                              <tr>
                                                  <td><asp:Label ID="bname" runat="server" Text="" ></asp:Label></td>
                                                  <td><asp:Label ID="date" runat="server" Text=""></asp:Label></td>
                                                  <td><asp:Label ID="time" runat="server" Text=""></asp:Label></td>
                                                  <td><asp:Label ID="styleHair" runat="server" Text=""></asp:Label></td>
                                                
                                                  
                                            </tr>
                                        

  </tbody>
</table>
                                     </div>
                                 </div>
                             </div>
                            <asp:Button ID="confermOreder" runat="server" Text="אישור הזמנה" OnClick="confermOreder_Click"  />
                             </ContentTemplate></asp:UpdatePanel>
                            
                        </div> <input type="button" name="next" class="next action-button" value="הבא" /> <input type="button" name="previous" class="previous action-button-previous" value="חזור" />
                    </fieldset>
                    <fieldset>
                        <div class="form-card">
                            <div class="row">
                                <div class="col-7">
                                    <h2 class="fs-title">סיום:</h2>
                                </div>
                                <div class="col-5">
                                    <h2 class="steps">שלב 4 - 5</h2>
                                </div>
                            </div> <br><br>
                            <h2 class="purple-text text-center"><strong>הצלחה !</strong></h2> <br>
                            <div class="row justify-content-center">
                                <div class="col-3"> <img src="https://i.imgur.com/GwStPmg.png" class="fit-image"> </div>
                            </div> <br><br>
                            <div class="row justify-content-center">
                                <div class="col-7 text-center">
                                    <h5 class="purple-text text-center">ביצעת הזמנת תור בהצלחה</h5>
                                    <asp:Button ID="finshed" runat="server" Text="סיום הזמנה" OnClick="finshed_Click"  />
                                </div>
                            </div>
                        </div>
                    </fieldset>
                </div>
            </div>
        </div>
    </div>
</div>
    
    
    




        





   
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
   
    <script src="js/OrderCut.js"></script>
    <script>
        $(document).ready(function () {

            var current_fs, next_fs, previous_fs; //fieldsets
            var opacity;
            var current = 1;
            var steps = $("fieldset").length;

            setProgressBar(current);
            $(".next").click(function () {

                current_fs = $(this).parent();
                next_fs = $(this).parent().next();

                //Add Class Active
                $("#progressbar li").eq($("fieldset").index(next_fs)).addClass("active");

                //show the next fieldset
                next_fs.show();
                //hide the current fieldset with style
                current_fs.animate({ opacity: 0 }, {
                    step: function (now) {
                        // for making fielset appear animation
                        opacity = 1 - now;

                        current_fs.css({
                            'display': 'none',
                            'position': 'relative'
                        });
                        next_fs.css({ 'opacity': opacity });
                    },
                    duration: 500
                });
                setProgressBar(++current);
            });

            $(".previous").click(function () {

                current_fs = $(this).parent();
                previous_fs = $(this).parent().prev();

                //Remove class active
                $("#progressbar li").eq($("fieldset").index(current_fs)).removeClass("active");

                //show the previous fieldset
                previous_fs.show();

                //hide the current fieldset with style
                current_fs.animate({ opacity: 0 }, {
                    step: function (now) {
                        // for making fielset appear animation
                        opacity = 1 - now;

                        current_fs.css({
                            'display': 'none',
                            'position': 'relative'
                        });
                        previous_fs.css({ 'opacity': opacity });
                    },
                    duration: 500
                });
                setProgressBar(--current);
            });

            function setProgressBar(curStep) {
                var percent = parseFloat(100 / steps) * curStep;
                percent = percent.toFixed();
                $(".progress-bar")
                    .css("width", percent + "%")
            }

            $(".submit").click(function () {
                return false;
            })

        });
    </script>
   
    </asp:Content>
