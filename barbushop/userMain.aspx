<%@ Page Title="" Language="C#" MasterPageFile="~/user.Master" AutoEventWireup="true" CodeBehind="userMain.aspx.cs" Inherits="barbushop.userMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <style>
     /* The Modal (background) */
.modal {
  display: none; /* Hidden by default */
  position: fixed; /* Stay in place */
  z-index: 1; /* Sit on top */
  left: 0;
  top: 0;
  width: 100%; /* Full width */
  height: 100%; /* Full height */
  overflow: auto; /* Enable scroll if needed */
  background-color: rgb(0,0,0); /* Fallback color */
  background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
}

/* Modal Content/Box */
.modal-content {
  background-color: #fefefe;
  margin: 15% auto; /* 15% from the top and centered */
  padding: 20px;
  border: 1px solid #888;
  width: 80%; /* Could be more or less, depending on screen size */
}

/* The Close Button */
.close {
  color: #aaa;
  float: right;
  font-size: 28px;
  font-weight: bold;
}

.close:hover,
.close:focus {
  color: black;
  text-decoration: none;
  cursor: pointer;
}
 </style>
  <style>
* {
  box-sizing: border-box;
}

body {
  background-color: #f1f1f1;
}

#regForm {
  background-color: #ffffff;
  margin: 100px auto;
  font-family: Raleway;
  padding: 40px;
  width: 70%;
  min-width: 300px;
}

h1 {
  text-align: center;  
}

input {
  padding: 10px;
  font-size: 17px;
  font-family: Raleway;
  border: 1px solid #aaaaaa;
}

/* Mark input boxes that gets an error on validation: */
input.invalid {
  background-color: #ffdddd;
}

/* Hide all steps by default: */
.tab {
  display: none;
}

button {
  background-color: #4CAF50;
  color: #ffffff;
  border: none;
  padding: 10px 20px;
  font-size: 17px;
  font-family: Raleway;
  cursor: pointer;
}

button:hover {
  opacity: 0.8;
}

#prevBtn {
  background-color: #bbbbbb;
}

/* Make circles that indicate the steps of the form: */
.step {
  height: 15px;
  width: 15px;
  margin: 0 2px;
  background-color: #bbbbbb;
  border: none;  
  border-radius: 50%;
  display: inline-block;
  opacity: 0.5;
}

.step.active {
  opacity: 1;
}

/* Mark the steps that are finished and valid: */
.step.finish {
  background-color: #4CAF50;
}
</style>
    
    <link href="css/mainStyle.css" rel="stylesheet" />
            <link rel="stylesheet" type="text/css" href="css/userMain.css"/>
    <link href="css/userMainBtn.css" rel="stylesheet" />
    <style>
        .jumbotron {
    display: block;
    position: static;
    top: auto;
    left: auto;
    right: auto;
    bottom: auto;
    background: -webkit-linear-gradient(left, #6f2600, #dc3545) !important;

}
        #login-box{


            background-color: black;
            width: max-content;
            padding-bottom: 30px;
             max-width: fit-content;
                border-radius: 12px;
        }
        #login .container #login-row #login-column #login-box {
    /* margin-top: 120px; */
    max-width: 600px;
    height: 400px;
    width:400px;
    border: 1px solid #5f0e0e;
    background-color: #000000;
    border-radius:20px;
}
        .text-info {
    color: #fcf4e7!important;
    text-align: right;
    padding-left: 250px;
}

#login .container #login-row #login-column #login-box #login-form {
  padding: 20px;
}
#login .container #login-row #login-column #login-box #login-form #register-link {
  margin-top: -85px;
}
p{
    color:aliceblue;
   font-weight:700
}
h1{
    color:white;
    font-weight:700;
}
    </style>
    
    <div class="jumbotron">
        <div class="container">
            
            <div class="row">
                <div class="col-6">
                    <section>
                 
       <h1 >ברוכים הבאים למספרה </h1>
  </section>
         <div>
        <h1>כאן תוכלו לנהל את התורים שלכם ולנהל את   </h1>
    <h1> לוח הזמנים שלכם לבחור את המספרה הקרובה </h1>

    </div>
   
                </div>
                <div class="col-6">
                      <div id="login">
                            

        
            <div id="login-row" class="row justify-content-center align-items-center">
                <div id="login-column" class="col-md-6">
                    <div id="login-box" class="col-md-12" style="width: max-content; max-width: fit-content; ">
                        

 

                            <div class="form-group">
                                            <label style="color:white; float:right;">עיר</label>
                       
                                            
                            <asp:Literal ID="LtlUsers" runat="server" />
<asp:DropDownList ID="BarberCityS" runat="server" class="form-control" AutoPostBack="true"  OnTextChanged="BarberCityS_TextChanged" ></asp:DropDownList>
                                         
                                     </div>
                 
                           
                       <div class="form-group">
                                            <label style="color:white; float:right;">שם המספרה</label>
                            <asp:Literal ID="LtlBarberNAme" runat="server" />
                           <asp:DropDownList ID="barbername"  runat="server" class="  form-control" AutoPostBack="true" OnSelectedIndexChanged="barbername_SelectedIndexChanged"></asp:DropDownList>
                                           
                                            
                                        </div>
                            <div class="form-group">
                                
                                <label for="remember-me" class="text-info" style="white-space: nowrap;"><span>זכור אותי</span> <span>
                                    <asp:CheckBox ID="BOXremember" runat="server" /><%--<input id="remember-me" name="remember-me" type="checkbox">--%></span></label><br>
                          <asp:Button ID="Button1" runat="server" Class="btn btn-primary btn-lg btn-block mb-3" Text="בחר" OnClick="Button1_Click" />
                                </div>
                    </div>
                </div>

            </div>
        </div>
                     <h1 style="color:white;">בחר עיר ומספרה כדי להתחיל</h1> 

                </div>
            </div>

        </div>
                       

                                     </div>
    <br />
    

    <section>
        <br />
   

        <div id="home_quicklinks">
                                <a class="quicklink link1" href="UserOrderCut.aspx">
                                    <span class="ql_caption">
                                        <span class="outer">
                                            <span class="inner">
                                                <h2>קבע תור</h2>
                                            </span>
                                        </span>
                                    </span>
                                    <span class="ql_top"></span>
                                    <span class="ql_bottom"></span>
                                </a>

                                <a class="quicklink link2"  href="tetst1.aspx">
                                    <span class="ql_caption">
                                        <span class="outer">
                                            <span class="inner">
                                                                                                <h2> הספרים שלנו</h2>

<%--                     <img alt=""  style="height:143px;" src="image/backg/New Project.png" />--%>
                                            </span>
                                        </span>
                                    </span>
                                    <span class="ql_top"></span>
                                    <span class="ql_bottom"></span>
                                </a>

                                <a class="quicklink link3" href="UserMeetings.aspx">
                                    <span class="ql_caption">
                                        <span class="outer">
                                            <span class="inner">
                                                <h2>התור שלך </h2>
                                            </span>
                                        </span>
                                    </span>
                                    <span class="ql_top"></span>
                                    <span class="ql_bottom"></span>
                                </a>

                                <div class="clear"></div>
                            </div>
                           

        <div id="myModal" class="modal">

  <!-- Modal content -->
  <div class="modal-content">
    <span class="close">&times;</span>
    <p>Some text in the Modal..</p>
  </div>

</div>
        



    </section>
         


<script>
         // Get the modal
         var modal = document.getElementById("myModal");

         // Get the button that opens the modal
         var btn = document.getElementById("myBtn");

         // Get the <span> element that closes the modal
         var span = document.getElementsByClassName("close")[3];

         // When the user clicks the button, open the modal 
         btn.onclick = function () {
             modal.style.display = "block";
         }

         // When the user clicks on <span> (x), close the modal
         span.onclick = function () {
             modal.style.display = "none";
         }

         // When the user clicks anywhere outside of the modal, close it
         window.onclick = function (event) {
             if (event.target == modal) {
                 modal.style.display = "none";
             }
         }
     </script>     
        <%--<script>

            var currentTab = 0; // Current tab is set to be the first tab (0)
            showTab(currentTab); // Display the current tab

            function showTab(n) {
                // This function will display the specified tab of the form ...
                var x = document.getElementsByClassName("tab");
                x[n].style.display = "block";
                // ... and fix the Previous/Next buttons:
                if (n == 0) {
                    document.getElementById("prevBtn").style.display = "none";
                } else {
                    document.getElementById("prevBtn").style.display = "inline";
                }
                if (n == (x.length - 1)) {
                    document.getElementById("nextBtn").innerHTML = "Submit";
                } else {
                    document.getElementById("nextBtn").innerHTML = "Next";
                }
                // ... and run a function that displays the correct step indicator:
                fixStepIndicator(n)
            }

            function nextPrev(n) {
                // This function will figure out which tab to display
                var x = document.getElementsByClassName("tab");
                // Exit the function if any field in the current tab is invalid:
                if (n == 1 && !validateForm()) return false;
                // Hide the current tab:
                x[currentTab].style.display = "none";
                // Increase or decrease the current tab by 1:
                currentTab = currentTab + n;
                // if you have reached the end of the form... :
                if (currentTab >= x.length) {
                    //...the form gets submitted:
                    document.getElementById("regForm").submit();
                    return false;
                    
                }
                // Otherwise, display the correct tab:
                showTab(currentTab);
            }

            function validateForm() {
                // This function deals with validation of the form fields
                var x, y, i, valid = true;
                x = document.getElementsByClassName("tab");
                y = x[currentTab].getElementsByTagName("input");
                // A loop that checks every input field in the current tab:
                for (i = 0; i < y.length; i++) {
                    // If a field is empty...
                    if (y[i].value == "") {
                        // add an "invalid" class to the field:
                        y[i].className += " invalid";
                        // and set the current valid status to false:
                        valid = false;
                    }
                }
                // If the valid status is true, mark the step as finished and valid:
                if (valid) {
                    document.getElementsByClassName("step")[currentTab].className += " finish";
                }
                return valid; // return the valid status
            }

            function fixStepIndicator(n) {
                // This function removes the "active" class of all steps...
                var i, x = document.getElementsByClassName("step");
                for (i = 0; i < x.length; i++) {
                    x[i].className = x[i].className.replace(" active", "");
                }
                //... and adds the "active" class to the current step:
                x[n].className += " active";
            }
        </script>--%>

     
</asp:Content>
