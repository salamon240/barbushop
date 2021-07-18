<%@ Page Title="" Language="C#" MasterPageFile="~/managerMster.Master" AutoEventWireup="true" CodeBehind="MangerCancel.aspx.cs" Inherits="barbushop.MangerCancel" %>
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
               text: '  נשלחה הודעה ללקוח    !',
           })
       }
   </script>

    <style>
        .styled-table {
            width:100%;
    border-collapse: collapse;
   margin: 52px 12px 66px 38px;
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
           
                   <h1 class="prsonl" style="color:white;"> ביטולים </h1>
<br />
    <div>
      

    </div>
            
       
   </div>
        </div>

    </div>
     </div>
    <div class="container">
        <div class="row">
            <div class="col-12"  style="text-align:right;">
                <h3>הזמנות מוצרים</h3>
                <table class="styled-table">
      <thead>
        <tr>
            <th scope="col">פרטי הזמנה</th>

          <th scope="col">הסר הזמנה</th>
            <th scope="col">אישור הזמנה</th>
          <th scope="col"> שם פרטי</th>
      <th scope="col">שם משפחה  </th>
      <th scope="col"> פלאפון </th>
        <th scope="col">עיר  </th>
            <th scope="col">דואר אלקטרוני  </th>
        <th scope="col">   תאריך הזמנה</th>
         <th scope="col">   מספר הזמנה</th>
            <th scope="col">   סטטוס הזמנה </th>
        </tr>
      </thead>
      <tbody>
          <asp:Repeater ID="yourrepeter" runat="server">
            <ItemTemplate>
                <tr >
                <td><a class="add-to-cart" style="color:darkcyan; float:right;"  href="MangerProductCencelInfo.aspx?OrderID=<%#Eval("OrderID")%>"> פרטים</a></td>

                    <td>
                        <%--<asp:LinkButton runat="server" ID="<%# Eval("MeetingID") %>" OnClick="test" </asp:LinkButton>--%>
                        <asp:LinkButton runat="server" ID="prodCancel"
                            OnCommand="cancelOrder"
                            CommandArgument='<%# Eval("OrderID") %>'>
                            <div class="someID">הסר</div>
                        </asp:LinkButton>

                    </td>
                    <td>
                        <%--<asp:LinkButton runat="server" ID="<%# Eval("MeetingID") %>" OnClick="test" </asp:LinkButton>--%>
                        <asp:LinkButton runat="server" ID="confirm"
                            OnCommand="confirmlOrder"
                            CommandArgument='<%# Eval("OrderID") %>'>
                            <div class="someID">אישור הזמנה</div>
                        </asp:LinkButton>

                    </td>
                      
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

        
      </tbody>
    </table>

            </div>

            <div class="col-12" style="text-align:right;">
                <h3>הזמנות שאושרו</h3>
                <table class="styled-table">
      <thead>
        <tr>
            <th scope="col">פרטי הזמנה</th>

          <th scope="col">הסר הזמנה</th>
            <th scope="col"> סיום הזמנה</th>
          <th scope="col"> שם פרטי</th>
      <th scope="col">שם משפחה  </th>
      <th scope="col"> פלאפון </th>
        <th scope="col">עיר  </th>
            <th scope="col">דואר אלקטרוני  </th>
        <th scope="col">   תאריך הזמנה</th>
         <th scope="col">   מספר הזמנה</th>
            <th scope="col">   סטטוס הזמנה </th>
            
        </tr>
      </thead>
      <tbody>
          <asp:Repeater ID="RepOrderConfitm" runat="server">
            <ItemTemplate>
                <tr >
                <td><a class="add-to-cart" style="color:darkcyan; float:right;"  href="MangerProductCencelInfo.aspx?OrderID=<%#Eval("OrderID")%>"> פרטים</a></td>

                    <td>
                        <%--<asp:LinkButton runat="server" ID="<%# Eval("MeetingID") %>" OnClick="test" </asp:LinkButton>--%>
                        <asp:LinkButton runat="server" ID="prodCancel"
                            OnCommand="cancelOrder"
                            CommandArgument='<%# Eval("OrderID") %>'>
                            <div class="someID">הסר</div>
                        </asp:LinkButton>

                    </td>
                    
                      <td>
                        <%--<asp:LinkButton runat="server" ID="<%# Eval("MeetingID") %>" OnClick="test" </asp:LinkButton>--%>
                        <asp:LinkButton runat="server" ID="paid"
                            OnCommand="PaidOrder"
                            CommandArgument='<%# Eval("OrderID") +","+Eval("productId") %>'>
                            <div class="someID"> הזמנה נאספה</div>
                        </asp:LinkButton>

                    </td>
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

        
      </tbody>
    </table>

            </div>
            <div class="col-12"  style="text-align:right;">
                                <h3> רשמית עובדים</h3>

                <table class="styled-table">
      <thead>
        <tr>
          <th scope="col">הסר עובד</th>
          <th scope="col">שם פרטי</th>
          <th scope="col">שם משפחה</th>
            <th scope="col">כתובת</th>
          <th scope="col">פלאפון</th>
            <th scope="col">תחילת עבודה </th>
            <th scope="col">דואר אלקטרוני</th>
          
        </tr>
      </thead>
      <tbody>
          <asp:Repeater ID="repEmp" runat="server">
            <ItemTemplate>
                <tr >
                    <td>
                        <%--<asp:LinkButton runat="server" ID="<%# Eval("MeetingID") %>" OnClick="test" </asp:LinkButton>--%>
                        <asp:LinkButton runat="server" ID="empCncel"
                            OnCommand="cancelEmployees"
                            CommandArgument='<%# Eval("RolleId") %>'>
                            <div class="someID">מחק</div>
                        </asp:LinkButton>

                    </td>
                     <td><%#Eval("FirstName") %></td>
                     <td><%#Eval("LastName") %></td>
                      <td><%#Eval("Address") %></td>
                     <td><%#Eval("PhoneNumber") %></td>
                      <td><%# Eval("starDay") %></td>                     
                     <td><%# Eval("Email") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>

        
      </tbody>
    </table>

            </div>
            <div class="col-12"  style="text-align:right;">
                                <h3> רשימת תורים</h3>

                <table class="styled-table">
      <thead>
        <tr>
          <th scope="col">הסר תור</th>
          <th scope="col">שם פרטי</th>
          <th scope="col">שם משפחה</th>
            <th scope="col">פלאפון</th>
          <th scope="col">דואר אלקטרוני</th>
            <th scope="col"> שעה  </th>
            <th scope="col">תאריך פגישה </th>
             <th scope="col">תספורת  </th>
          
        </tr>
      </thead>
      <tbody>
          <asp:Repeater ID="RepMeeting" runat="server">
            <ItemTemplate>
                <tr >
                    <td>
                        <%--<asp:LinkButton runat="server" ID="<%# Eval("MeetingID") %>" OnClick="test" </asp:LinkButton>--%>
                        <asp:LinkButton runat="server" ID="MettiCencel"
                            OnCommand="cencelMeetings"
                            CommandArgument='<%# Eval("MeetingID") %>'>
                            <div class="someID">הסר</div>
                        </asp:LinkButton>

                    </td>

                   <td><%#Eval("FirstName") %></td>
                                                
                   <td><%#Eval("LastName") %></td>
                   <td><%#Eval("PhoneNumber") %></td>
                   <td><%#Eval("Email") %></td>
                     <td><%#Eval("Time") %></td>
                    <td><%#Eval("MeetingDate") %></td>
                     <td><%#Eval("HairCut") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>

        
      </tbody>
    </table>

            </div>
        </div>

    </div>
    

</asp:Content>
