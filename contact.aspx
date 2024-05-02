<%@ Page Title="" Language="C#" MasterPageFile="~/Ecommerce-website/MasterPage.master" AutoEventWireup="true" CodeFile="contact.aspx.cs" Inherits="Ecommerce_website_contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div class="brand_color">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="titlepage">
                        <h2>Contact Us</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Contact Form -->
    <div class="contact">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="contact-form">
                        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control" placeholder="Your name"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Please enter your name" ValidationGroup="ContactValidation"></asp:RequiredFieldValidator>

                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please enter your email" ValidationGroup="ContactValidation"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid email format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="ContactValidation"></asp:RegularExpressionValidator>

                        <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" placeholder="Phone"></asp:TextBox>

                        <asp:TextBox ID="txtMessage" runat="server" CssClass="textarea" TextMode="MultiLine" placeholder="Message"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvMessage" runat="server" ControlToValidate="txtMessage" ErrorMessage="Please enter your message" ValidationGroup="ContactValidation"></asp:RequiredFieldValidator>

<asp:LinkButton ID="btnSend" runat="server" CssClass="send" OnClick="btnSend_Click" ValidationGroup="ContactValidation">Send</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

