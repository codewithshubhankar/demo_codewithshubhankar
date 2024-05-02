<%@ Page Title="" Language="C#" MasterPageFile="~/Ecommerce-website/MasterPage.master" AutoEventWireup="true" CodeFile="Signups.aspx.cs" Inherits="Ecommerce_website_Signups" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container d-flex" id="mainDiv" runat="server">
    <div class="container-fluid">
        <div class="content-wrapper  align-items-stretch auth auth-img-bg">
            <div class="row flex-grow">
                <div class="col-lg-6 d-flex align-items-center justify-content-center">
                    <div class="auth-form-transparent text-left p-3 w-100">
                        <div class="brand-logo mb-0">
                        </div>
                        <h4>Welcome back!</h4>
                        <h6 class="font-weight-light">Happy to see you again!</h6>
                        <div class="pt-3">
                            <div class="row mb-0">
                                <div class="col-md-6 mb-3">
                                    <asp:Label ID="lblName" runat="server" AssociatedControlID="txtName" Text="Name"></asp:Label>
                                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control form-control-lg" Height="50px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Please enter name." Text="*" CssClass="text-danger"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 mb-3">
                                    <asp:Label ID="lblEmail" runat="server" AssociatedControlID="txtEmail" Text="Email"></asp:Label>
                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control form-control-lg" Height="50px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please enter email." Text="*" CssClass="text-danger"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="row mb-0">
                                <div class="col-md-6 mb-3">
                                    <asp:Label ID="lblGender" runat="server" AssociatedControlID="ddlGender" Text="Gender"></asp:Label>
                                    <asp:DropDownList ID="ddlGender" runat="server" CssClass="form-control form-control-lg">
                                        <asp:ListItem Text="Select Gender" Value=""></asp:ListItem>
                                        <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                                        <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvGender" runat="server" ControlToValidate="ddlGender" ErrorMessage="Please choose gender." Text="*" CssClass="text-danger"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 mb-3">
                                    <asp:Label ID="lblMobile" runat="server" AssociatedControlID="txtMobile" Text="Mobile"></asp:Label>
                                    <asp:TextBox ID="txtMobile" runat="server" CssClass="form-control form-control-lg" Height="50px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvMobile" runat="server" ControlToValidate="txtMobile" ErrorMessage="Please enter mobile no." Text="*" CssClass="text-danger"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="row mb-0">
                                <div class="col-md-6 mb-3">
                                    <asp:Label ID="lblLocality" runat="server" AssociatedControlID="txtLocality" Text="Locality (Landmark)"></asp:Label>
                                    <asp:TextBox ID="txtLocality" runat="server" CssClass="form-control form-control-lg" Height="50px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvLocality" runat="server" ControlToValidate="txtLocality" ErrorMessage="Please enter locality." Text="*" CssClass="text-danger"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 mb-3">
                                    <asp:Label ID="lblCity" runat="server" AssociatedControlID="txtCity" Text="City"></asp:Label>
                                    <asp:TextBox ID="txtCity" runat="server" CssClass="form-control form-control-lg" Height="50px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="txtCity" ErrorMessage="Please enter city." Text="*" CssClass="text-danger"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="row mb-0">
                                <div class="col-md-6 mb-3">
                                    <asp:Label ID="lblState" runat="server" AssociatedControlID="txtState" Text="State"></asp:Label>
                                    <asp:TextBox ID="txtState" runat="server" CssClass="form-control form-control-lg" Height="50px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvState" runat="server" ControlToValidate="txtState" ErrorMessage="Please enter state." Text="*" CssClass="text-danger"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 mb-3">
                                    <asp:Label ID="lblPincode" runat="server" AssociatedControlID="txtPincode" Text="Pincode"></asp:Label>
                                    <asp:TextBox ID="txtPincode" runat="server" CssClass="form-control form-control-lg" Height="50px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvPincode" runat="server" ControlToValidate="txtPincode" ErrorMessage="Please enter pincode." Text="*" CssClass="text-danger"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="row mb-0">
                                <div class="col-md-6 mb-3">
                                    <asp:Label ID="lblUserName" runat="server" AssociatedControlID="txtUserName" Text="UserName"></asp:Label>
                                    <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control form-control-lg" Height="50px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ControlToValidate="txtUserName" ErrorMessage="Please enter username." Text="*" CssClass="text-danger"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 mb-3">
                                    <asp:Label ID="lblPassword" runat="server" AssociatedControlID="txtPassword" Text="Password"></asp:Label>
                                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control form-control-lg" Height="50px" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please enter password." Text="*" CssClass="text-danger"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="row mb-0">
                                <div class="col-md-12 mb-3">
                                    <asp:Label ID="lblFullAddress" runat="server" AssociatedControlID="txtFullAddress" Text="Full Address"></asp:Label>
                                    <asp:TextBox ID="txtFullAddress" runat="server" CssClass="form-control form-control-lg" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvFullAddress" runat="server" ControlToValidate="txtFullAddress" ErrorMessage="Please enter full address." Text="*" CssClass="text-danger"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <!-- Submit button -->
                            <asp:LinkButton ID="BtnSignup" runat="server" Text="Signup" CssClass="btn-block mb-4" OnClick="BtnSignup_Click"></asp:LinkButton>

                            <!-- Register buttons -->
                            <div class="text-center">
                                <p style="margin-top: 1rem;">Already Signup? <a href="signin.aspx" style="color: #2d3092 !important">Signin</a></p>
                            </div>   
                        </div>
                    </div>
                </div>
                <div class="col-lg-6 login-half-bg d-none d-lg-flex flex-row">
                    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel" style="width: 100%; display: flex; align-items: center">
                        <ol class="carousel-indicators">
                            <li data-target="#carouselExampleIndicators" data-slide-to="0"></li>
                            <li data-target="#carouselExampleIndicators" data-slide-to="1" class="active"></li>
                            <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                        </ol>
                        <div class="carousel-inner">
                            <div class="carousel-item">
                                <asp:Image ID="Image1" runat="server" CssClass="d-block w-100" ImageUrl="img/product-1.jpg" AlternateText="First slide" />
                            </div>      
                            <div class="carousel-item active">
                                <asp:Image ID="Image2" runat="server" CssClass="d-block w-100" ImageUrl="img/product-2.jpg" AlternateText="Second slide" />
                            </div>
                            <div class="carousel-item">   
                                <asp:Image ID="Image3" runat="server" CssClass="d-block w-100" ImageUrl="img/product-5.jpg" AlternateText="Third slide" />
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
        <!-- content-wrapper ends -->
    </div>
    <!-- page-body-wrapper ends -->
</div>

</asp:Content>

