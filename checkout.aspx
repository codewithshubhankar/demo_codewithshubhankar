<%@ Page Title="" Language="C#" MasterPageFile="~/Ecommerce-website/MasterPage.master" AutoEventWireup="true" CodeFile="checkout.aspx.cs" Inherits="checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Breadcrumb Start -->
    <div class="container-fluid">
        <div class="row px-xl-5">
            <div class="col-12">
                <nav class="breadcrumb bg-light mb-30">
                    <a class="breadcrumb-item text-dark" href="Default.aspx">Home</a>
                    <a class="breadcrumb-item text-dark" href="#">Shop</a>
                    <span class="breadcrumb-item active">Checkout</span>
                </nav>
            </div>
        </div>
    </div>
    <!-- Breadcrumb End -->


    <!-- Checkout Start -->
    <div class="container-fluid">
        <div class="row px-xl-5">
            <div class="col-lg-8">
                <h5 class="section-title position-relative text-uppercase mb-3"><span class="bg-secondary pr-3">Billing Address</span></h5>
                <div class="bg-light p-30 mb-5">
                    <div class="row">
                        <div class="col-md-6">
                            <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                            <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control" placeholder="John"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                            <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" placeholder="Doe"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblEmail" runat="server" Text="E-mail"></asp:Label>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="example@email.com"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblMobileNo" runat="server" Text="Mobile No"></asp:Label>
                            <asp:TextBox ID="txtMobileNo" runat="server" CssClass="form-control" placeholder="+123 456 789"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblAddress1" runat="server" Text="Address Line 1"></asp:Label>
                            <asp:TextBox ID="txtAddress1" runat="server" CssClass="form-control" placeholder="123 Street"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblAddress2" runat="server" Text="Address Line 2"></asp:Label>
                            <asp:TextBox ID="txtAddress2" runat="server" CssClass="form-control" placeholder="123 Street"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
                            <asp:DropDownList ID="ddlCountry" runat="server" CssClass="form-control">
                                <asp:ListItem Text="United States" Value="US"></asp:ListItem>
                                <asp:ListItem Text="Afghanistan" Value="AF"></asp:ListItem>
                                <asp:ListItem Text="Albania" Value="AL"></asp:ListItem>
                                <asp:ListItem Text="Algeria" Value="DZ"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                            <asp:TextBox ID="txtCity" runat="server" CssClass="form-control" placeholder="New York"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                            <asp:TextBox ID="txtState" runat="server" CssClass="form-control" placeholder="New York"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblZipCode" runat="server" Text="ZIP Code"></asp:Label>
                            <asp:TextBox ID="txtZipCode" runat="server" CssClass="form-control" placeholder="123"></asp:TextBox>
                        </div>
                        <div class="col-md-12">
                            <asp:CheckBox ID="chkCreateAccount" runat="server" Text="Create an account" />
                        </div>
                        <div class="col-md-12">
                            <div class="custom-control custom-checkbox">
                                <input type="checkbox" class="custom-control-input" id="shipto" data-toggle="collapse" data-target="#shipping-address">
                                <label class="custom-control-label" for="shipto">Ship to different address</label>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="collapse mb-5" id="shipping-address">
                    <h5 class="section-title position-relative text-uppercase mb-3"><span class="bg-secondary pr-3">Shipping Address</span></h5>
                    <div class="bg-light p-30">
                        <div class="row">
                            <div class="col-md-6">
                                <asp:Label ID="lblShippingFirstName" runat="server" Text="First Name"></asp:Label>
                                <asp:TextBox ID="txtShippingFirstName" runat="server" CssClass="form-control" placeholder="John"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="lblShippingLastName" runat="server" Text="Last Name"></asp:Label>
                                <asp:TextBox ID="txtShippingLastName" runat="server" CssClass="form-control" placeholder="Doe"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="lblShippingEmail" runat="server" Text="E-mail"></asp:Label>
                                <asp:TextBox ID="txtShippingEmail" runat="server" CssClass="form-control" placeholder="example@email.com"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="lblShippingMobileNo" runat="server" Text="Mobile No"></asp:Label>
                                <asp:TextBox ID="txtShippingMobileNo" runat="server" CssClass="form-control" placeholder="+123 456 789"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="lblShippingAddress1" runat="server" Text="Address Line 1"></asp:Label>
                                <asp:TextBox ID="txtShippingAddress1" runat="server" CssClass="form-control" placeholder="123 Street"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="lblShippingAddress2" runat="server" Text="Address Line 2"></asp:Label>
                                <asp:TextBox ID="txtShippingAddress2" runat="server" CssClass="form-control" placeholder="123 Street"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="lblShippingCountry" runat="server" Text="Country"></asp:Label>
                                <asp:DropDownList ID="ddlShippingCountry" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="United States" Value="US"></asp:ListItem>
                                    <asp:ListItem Text="Afghanistan" Value="AF"></asp:ListItem>
                                    <asp:ListItem Text="Albania" Value="AL"></asp:ListItem>
                                    <asp:ListItem Text="Algeria" Value="DZ"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="lblShippingCity" runat="server" Text="City"></asp:Label>
                                <asp:TextBox ID="txtShippingCity" runat="server" CssClass="form-control" placeholder="New York"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="lblShippingState" runat="server" Text="State"></asp:Label>
                                <asp:TextBox ID="txtShippingState" runat="server" CssClass="form-control" placeholder="New York"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="lblShippingZIPCode" runat="server" Text="ZIP Code"></asp:Label>
                                <asp:TextBox ID="txtShippingZIPCode" runat="server" CssClass="form-control" placeholder="123"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4">
                <h5 class="section-title position-relative text-uppercase mb-3"><span class="bg-secondary pr-3">Order Total</span></h5>
                <div class="bg-light p-30 mb-5">
                    <div class="border-bottom">
                        <h6 class="mb-3">Products</h6>
                        <!-- Display dynamic product list here -->
                    </div>
                    <div class="border-bottom pt-3 pb-2">
                        <div class="d-flex justify-content-between mb-3">
                            <h6> <%# Eval("Price") %></h6>
                            <h6>$150</h6> <!-- Replace with calculated subtotal -->
                        </div>
                        <div class="d-flex justify-content-between">
                            <h6 class="font-weight-medium">Shipping</h6>
                            <h6 class="font-weight-medium">$10</h6> <!-- Replace with calculated shipping cost -->
                        </div>
                    </div>
                    <div class="pt-2">
                        <div class="d-flex justify-content-between mt-2">
                            <h5>Total</h5>
                            <h5>$160</h5> <!-- Replace with calculated total -->
                        </div>
                    </div>
                </div>
                <div class="mb-5">
                    <h5 class="section-title position-relative text-uppercase mb-3"><span class="bg-secondary pr-3">Payment</span></h5>
                    <div class="bg-light p-30">
                        <div class="form-group">
                            <div class="custom-control custom-radio">
                                <asp:RadioButton ID="rbPaypal" runat="server" Text="Paypal" CssClass="custom-control-input" GroupName="payment" />
                                <label class="custom-control-label" for="rbPaypal"></label>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="custom-control custom-radio">
                                <asp:RadioButton ID="rbDirectCheck" runat="server" Text="Direct Check" CssClass="custom-control-input" GroupName="payment" />
                                <label class="custom-control-label" for="rbDirectCheck"></label>
                            </div>
                        </div>
                        <div class="form-group mb-4">
                            <div class="custom-control custom-radio">
                                <asp:RadioButton ID="rbBankTransfer" runat="server" Text="Bank Transfer" CssClass="custom-control-input" GroupName="payment" />
                                <label class="custom-control-label" for="rbBankTransfer"></label>
                            </div>
                        </div>
                        <asp:Button ID="btnPlaceOrder" runat="server" Text="Place Order" CssClass="btn btn-block btn-primary font-weight-bold py-3" OnClick="btnPlaceOrder_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Checkout End -->
</asp:Content>

