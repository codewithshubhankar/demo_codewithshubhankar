<%@ Page Title="" Language="C#" MasterPageFile="~/Ecommerce-website/MasterPage.master" AutoEventWireup="true" CodeFile="signin.aspx.cs" Inherits="Ecommerce_website_signin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="container d-flex" id="mainDiv">
    <div class="container-fluid">
        <div class="content-wrapper align-items-stretch auth auth-img-bg">
            <div class="row flex-grow">
                <div class="col-lg-6 d-flex align-items-center justify-content-center">
                    <div class="auth-form-transparent text-left p-3 w-100">
                        <h4>Welcome back!</h4>
                        <h6 class="font-weight-light">Happy to see you again!</h6>
                        <div class="pt-3">
                            <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control form-control-lg" style="min-height: 50px;"></asp:TextBox>
                            <asp:Label ID="lblUserName" runat="server" AssociatedControlID="txtUserName" CssClass="form-label">UserName</asp:Label>
                            <!-- Validation Icons -->
                            <span class="icon validation small success hide"><span class="fa fa-check"></span></span>
                            <span class="icon validation small error hide"><span class="fa fa-remove"></span></span>
                            <div class="form-notch"></div>
                        </div>
                        <div class="pt-3">
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control form-control-lg" style="min-height: 50px;"></asp:TextBox>
                            <asp:Label ID="lblPassword" runat="server" AssociatedControlID="txtPassword" CssClass="form-label">Password</asp:Label>
                            <!-- Validation Icons -->
                            <span class="icon validation small success hide"><span class="fa fa-check"></span></span>
                            <span class="icon validation small error hide"><span class="fa fa-remove"></span></span>
                            <div class="form-notch"></div>
                        </div>
                        <div>
                            <p style="margin-top: 1rem;">Forgot Password? <a href="ForgotPswrd_1.aspx" style="color: #2d3092 !important">Click here</a></p>
                        </div>
                        <!-- Submit button -->
                        <asp:Button ID="BtnSignin" runat="server" Text="Sign In" CssClass="btn1 btn-primary btn-block mb-4" Style="background-color: #ffd333; color: black;" OnClick="BtnSignin_Click" />
                        <!-- Register link -->
                        <div class="text-center">
                            <p style="margin-top: 1rem;">Not a member? <a href="Signups.aspx" style="color: #2d3092 !important">Signup</a></p>
                        </div>
                    </div>    
                 </div>   

                <div class="col-lg-6 login-half-bg d-none d-lg-flex flex-row">
                    <div id="carouselExampleIndicators" class="carousel slide w-100" data-ride="carousel">
                        <ol class="carousel-indicators">
                            <li data-target="#carouselExampleIndicators" data-slide-to="0"></li>
                            <li data-target="#carouselExampleIndicators" data-slide-to="1" class="active"></li>
                            <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                        </ol>
                        <div class="carousel-inner">   
                            <div class="carousel-item">      
                                <img class="d-block w-100" src="img/product-2.jpg"  style="height:500px" alt="First slide">
                            </div>  
                            <div class="carousel-item active">  
                                <img class="d-block w-100" src="img/product-3.jpg" alt="Second slide">
                            </div>
                            <div class="carousel-item">
                                <img class="d-block w-100" src="img/product-5.jpg" alt="Third slide">
                            </div>
                        </div>
                        <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="sr-only">Previous</span>
                        </a>
                        <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="sr-only">Next</span>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
   
</asp:Content>

