<%@ Page Title="" Language="C#" MasterPageFile="~/user.Master" AutoEventWireup="true" CodeBehind="UserFashion.aspx.cs" Inherits="barbushop.UserFashion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <link href="css/mainStyle.css" rel="stylesheet" />
    <link href="css/fun.css" rel="stylesheet" />
                      <h1>ברוכים הבאים לאיזור הפנאי </h1>
    <section class="search-sec" >
    <div class="container">
        <form action="#" method="post" novalidate="novalidate">
            <div class="row">
                <div class="col-lg-12">


                    <div class="row">

                        <div class="row">

                            <div class="col">
                                
                              <asp:LinkButton class="tag" ID="LinkBun1" runat="server" href="UserFun.aspx">ספורט</asp:LinkButton>
                            </div>

                            <div class="col">
                                  <asp:LinkButton  class="tag" ID="LinkButton2" runat="server" href="Userfu2.aspx">רכב</asp:LinkButton>
                              
                            </div>


                          
                               <div class="col">
                               <asp:LinkButton class="tag" ID="LinkButton4" runat="server" herf="UserFun.aspx">חדשות</asp:LinkButton>
                            </div>

                            

                          </div>
                    
                    </div>


                </div>
            </div>
        </form>
    </div>
</section>
     
    
    <h1>חדשות</h1>
 
       
        
       
                <iframe   src="https://www.walla.co.il/" width="100%" height="700"></iframe>
       
  \
     <br />
</asp:Content>
