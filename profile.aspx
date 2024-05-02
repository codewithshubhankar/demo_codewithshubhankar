<%@ Page Title="" Language="C#" MasterPageFile="~/Ecommerce-website/MasterPage.master" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="Ecommerce_website_profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="row">
        </div>
    </div>

    <div class="container" style="padding-top: 100px;">
        <div class="main-body">

            <!-- Breadcrumb -->
            <nav aria-label="breadcrumb" class="main-breadcrumb">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="Default.aspx" style="color: black; font-weight: 500;">Hi, Welcome to </a>FashionAdda</li>
                </ol>
            </nav>
            <!-- /Breadcrumb -->

            <div class="row gutters-sm">
                <div class="col-md-4 mb-3">
                    <div class="card">
                        <div class="card-body">
                            <div class="d-flex flex-column align-items-center text-center">
                               
                 <asp:Image ID="Image1" runat="server" CssClass="rounded-circle" alt="user" width="150" />

                                <div class="mt-3">
                                    <h4>
                                        &nbsp;</h4>
                                    <asp:LinkButton ID="btnLogout" runat="server" class="btn btn-dark" style="margin-top: 20px;" OnClick="btnLogout_Click">Logout</asp:LinkButton>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-8">
                    <div class="card mb-3">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-sm-3">
                                    <h6 class="mb-0">User Name</h6>
                                </div>
                                <div class="col-sm-9 text-secondary">
                                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                                </div>
                            </div>
                            <hr>
                            <div class="row">
                                <div class="col-sm-3">
                                    <h6 class="mb-0">Email</h6>
                                </div>
                                <div class="col-sm-9 text-secondary">
                                    <asp:Label ID="lblUserEmail" runat="server" Text=""></asp:Label>
                                </div>
                            </div>
                            <hr>
                            <div class="row">
                                <div class="col-sm-3">
                                    <asp:LinkButton ID="btnOrders" runat="server" class="btn btn-dark" OnClick="btnOrders_Click">Orders</asp:LinkButton>
                                </div>
                                <div class="col-sm-9 text-secondary" style="margin-top:7px;">
                                    From where you can able to trackorders also.
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>

