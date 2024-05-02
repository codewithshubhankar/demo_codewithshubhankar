<%@ Page Title="" Language="C#" MasterPageFile="~/Ecommerce-website/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Ecommerce_website_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
    

   <style>
    body {
        background-color: #f0f0f0; /* Light gray background color */
        font-family: Arial, sans-serif; 
    }

    .container {
        width: 500px;
        margin: auto;
        margin-top: 80px;
        background-color: #333; /* Dark background color */
        padding: 20px; /* Add padding */
        border-radius: 8px;
        box-shadow: 0px 0px 20px 0px #aaaaaa;
        border: 2px solid #4CAF50; /* Border color */
    }

    h2 {
        text-align: center; /* Center align the heading */
        margin-bottom: 20px; /* Bottom margin for spacing */
        color: #007bff; /* Blue color for heading */
    }

    .form-group {
        margin-bottom: 20px; /* Bottom margin for spacing */
    }

    #btnRegister {
        width: 100%; /* Full width button */
        background-color: #007bff; /* Blue color for button */
        border: none; /* No border */
        color: white; /* White text color */
        padding: 10px; /* Padding for button */
        cursor: pointer; /* Cursor style on hover */
        transition: background-color 0.3s; /* Smooth transition effect */
    }

    #btnRegister:hover {
        background-color: #0056b3; /* Darker blue color on hover */
    }

    #lblMessage {
        text-align: center; /* Center align the message */
        display: block; /* Display as block element */
        color: #28a745; /* Green color for message */
    }

    #fileProfileImage {
        display: none; /* Hide the file upload input */
    }

    #btnUploadImage {
        width: 100%; /* Full width button */
        background-color: #28a745; /* Green color for button */
        border: none; /* No border */
        color: white; /* White text color */
        padding: 10px; /* Padding for button */
        cursor: pointer; /* Cursor style on hover */
        transition: background-color 0.3s; /* Smooth transition effect */
        text-align: center; /* Center align the text */
        box-shadow: 0 0 20px rgba(0, 0, 0, 0.1); /* Glow effect */
    }

    #btnUploadImage:hover {
        background-color: #218838; /* Darker green color on hover */
        box-shadow: 0 0 30px rgba(0, 0, 0, 0.2); /* Increase glow on hover */
    }

    /* Additional colorful design elements */
    #signupContainer h1 {
        text-align: center; /* Center align the heading */
        color: #ff6347; /* Tomato color for heading */
    }

    #signupContainer input {
        width: 100%;
        padding: 10px;
        margin-bottom: 10px;
        border: 1px solid #ff6347; /* Input border color */
        border-radius: 4px;
        background-color: #f8f9fa; /* Light gray background color for input */
        color: #333; /* Text color for input */
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-6">
     <div id="signupContainer">
          <h1>Sign Up Now</h1>
        </div>
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                    <div class="form-group">
                        <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Username" Required="true"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email"  Required="true"></asp:TextBox>
                    </div>
                    <div class="form-group"> 
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Password" Required="true"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="fileProfileImage" id="btnUploadImage" class="btn">Upload Profile Image</label>
                        <asp:FileUpload ID="fileProfileImage" runat="server" />
                    </div>
                    <div class="form-group">
    <asp:TextBox ID="txtmobile" runat="server" CssClass="form-control" placeholder="Mobile" TextMode="SingleLine" Required="true"></asp:TextBox>
</div>

                     <div class="form-group">
                         <asp:DropDownList ID="DropDownList1" runat="server"  CssClass="form-control">
                             <asp:ListItem>
                                 User
                                 
                             </asp:ListItem>

                             <asp:ListItem>
                                 Admin
                                 
                             </asp:ListItem>
                         </asp:DropDownList>
                    </div>
                    <div class="form-group">
<asp:LinkButton ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click"></asp:LinkButton>
                    </div>
                            
                     <div class="col-12  mt-3">
                                   <p>Already have an account? <a href="../AdminDashboard/LoginPage.aspx">Sign In</a></p>
                                                </div>
                </div>
            </div>
        </div>

    <script>
        (document).ready(function () {
            // Show selected file name on the button label
            ('#fileProfileImage').change(function () {
                var fileName = $(this).val().split('\\').pop();
                ('#btnUploadImage').text(fileName);
            });
        });
    </script>
</asp:Content>

