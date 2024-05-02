<%@ Page Title="" Language="C#" MasterPageFile="~/Ecommerce-website/MasterPage.master" AutoEventWireup="true" CodeFile="Notice.aspx.cs" Inherits="Ecommerce_website_Notice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .blinking {
            animation: blinker 1s linear infinite;
        }
        
        @keyframes blinker {
            50% {
                opacity: 0;
            }
        }

        .card {
            border: 2px solid #ccc;
            border-radius: 15px;
            padding: 15px;
            margin-bottom: 15px;
            background-color: orange;
            box-shadow: 0 0 20px 0 rgba(0, 0, 0, 0.2);
        }

        .card-container {
            display: flex;
            justify-content: center;
            flex-wrap: wrap; /* allow cards to wrap to the next line */
        }

        .card {
            flex: 0 0 calc(33.33% - 30px); /* adjust the width of cards */
            margin: 15px;
            max-width: 200px; /* set maximum width for cards */
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <div class="container-fluid">
        <marquee class="blinking" behavior="alternate"><h2>Notices</h2></marquee>
        <div class="card-container">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="card">
                        <p><%# Eval("NoticeText") %>
                            <br /><%# Eval("DateAdded","{0:dd MMMM yyyy}") %><br />
                            <%# Eval("Time", "{0:hh:mm:ss tt}") %>

                        </p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
