<%@ Page Title="" Language="C#" MasterPageFile="~/Ecommerce-website/MasterPage.master" AutoEventWireup="true" CodeFile="Checkout1.aspx.cs" Inherits="Ecommerce_website_Checkout1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <!-- Breadcrumb Start -->
    <div class="container-fluid">
        <div class="row px-xl-5">
            <div class="col-12">
                <nav class="breadcrumb bg-light mb-30">
                    <a class="breadcrumb-item text-dark" href="Default.aspx">Home</a>
                    <a class="breadcrumb-item text-dark" href="shop.aspx">Shop</a>
                    <span class="breadcrumb-item active">Checkout</span>
                </nav>
            </div>
        </div>
    </div>
    <!-- Breadcrumb End -->

    <div class="site-section">
        <div class="container">
            <div class="row mb-5">
                <div class="col-md-12">
                    <div class="border p-4 rounded" role="alert">
                        Returning customer? <a href="#">Click here</a> to login
           
                    </div>
                </div>
                </div>
            </div>
        
            </div>
            <div class="row">
                <div class="col-md-6 mb-5 mb-md-0">
                    <h2 class="h3 mb-3 text-black">Billing Details</h2>
                    <div class="p-3 p-lg-5 border">

                        <div class="form-group row">
                            <div class="col-md-6">
                                <asp:Label ID="lblFirstName" runat="server" AssociatedControlID="c_fname" CssClass="text-black" Text="First Name *"></asp:Label>
                                <asp:TextBox ID="c_fname" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="lblLastName" runat="server" AssociatedControlID="c_lname" CssClass="text-black" Text="Last Name *"></asp:Label>
                                <asp:TextBox ID="c_lname" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group row">
                            <div class="col-md-12">
                                <asp:Label ID="lblCompanyName" runat="server" AssociatedControlID="c_companyname" CssClass="text-black" Text="Company Name *"></asp:Label>
                                <asp:TextBox ID="c_companyname" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group row">
                            <div class="col-md-12">
                                <asp:Label ID="lblAddress" runat="server" AssociatedControlID="c_address" CssClass="text-black" Text="Address *"></asp:Label>
                                <asp:TextBox ID="c_address" runat="server" CssClass="form-control" placeholder="Street address"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:TextBox runat="server" ID="apartment" CssClass="form-control" placeholder="Apartment, suite, unit etc. (optional)"></asp:TextBox>
                        </div>

                        <div class="form-group row">
                            <div class="col-md-6">
                                <asp:Label ID="lblStateCountry" runat="server" AssociatedControlID="c_state_country" CssClass="text-black" Text="State / Country *"></asp:Label>
                                <asp:TextBox ID="c_state_country" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="lblPostalZip" runat="server" AssociatedControlID="c_postal_zip" CssClass="text-black" Text="Postal / Zip *"></asp:Label>
                                <asp:TextBox ID="c_postal_zip" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group row mb-5">
                            <div class="col-md-6">
                                <asp:Label ID="lblEmailAddress" runat="server" AssociatedControlID="c_email_address" CssClass="text-black" Text="Email Address *"></asp:Label>
                                <asp:TextBox ID="c_email_address" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="lblPhone" runat="server" AssociatedControlID="c_phone" CssClass="text-black" Text="Phone *"></asp:Label>
                                <asp:TextBox ID="c_phone" runat="server" CssClass="form-control" placeholder="Phone Number"></asp:TextBox>
                            </div>
                        </div>


                        <div class="form-group">
                            <label for="c_create_account" class="text-black" data-toggle="collapse" href="#create_an_account" role="button" aria-expanded="false" aria-controls="create_an_account">
                                <input type="checkbox" value="1" id="c_create_account">
                                Create an account?</label>
                            <div class="collapse" id="create_an_account">
                                <div class="py-2">
                                    <p class="mb-3">Create an account by entering the information below. If you are a returning customer please login at the top of the page.</p>
                                    <div class="form-group">
                                        <label for="c_account_password" class="text-black">Account Password</label>
                                        <input type="email" class="form-control" id="c_account_password" name="c_account_password" placeholder="">
                                    </div>
                                </div>
                            </div>
                        </div>


                        <div class="form-group">
                            <label for="c_ship_different_address" class="text-black" data-toggle="collapse" href="#ship_different_address" role="button" aria-expanded="false" aria-controls="ship_different_address">
                                <input type="checkbox" value="1" id="c_ship_different_address">
                                Ship To A Different Address?</label>
                            <div class="collapse" id="ship_different_address">
                                <div class="py-2">




                                    <div class="form-group row">
                                        <div class="col-md-6">
                                            <asp:Label ID="lblfname" class="text-black" runat="server" Text="First Name"></asp:Label>
                                            <asp:TextBox ID="c_diff_fname" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="col-md-6">
                                            <asp:Label ID="lblDiffLastname" runat="server" CssClass="text-black" Text="Last Name"></asp:Label>
                                            <asp:TextBox ID="c_diff_lname" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div class="form-group row">
                                        <div class="col-md-12">
                                            <asp:Label ID="lblCompany" class="text-black" runat="server" Text="Company Name *"></asp:Label>

                                            <asp:TextBox ID="c_diff_companyname" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div class="form-group row">
                                        <div class="col-md-12">
                                            <asp:Label ID="Label1" class="text-black" runat="server" Text="Address *"></asp:Label>

                                            <asp:TextBox ID="c_diff_address" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <asp:TextBox runat="server" CssClass="form-control" placeholder="Apartment, suite, unit etc. (optional)"></asp:TextBox>
                                    </div>

                                    <div class="form-group row">
                                        <div class="col-md-6">
                                            <asp:Label ID="Label2" class="text-black" runat="server" Text="State / Country *"></asp:Label>

                                            <asp:TextBox ID="c_diff_state_country" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="col-md-6">
                                            <asp:Label ID="Label3" class="text-black" runat="server" Text="Posta / Zip  *"></asp:Label>

                                            <asp:TextBox ID="c_diff_postal_zip" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div class="form-group row mb-5">
                                        <div class="col-md-6">
                                            <asp:Label ID="Label4" class="text-black" runat="server" Text="Email Address *"></asp:Label>

                                            <asp:TextBox ID="c_diff_email_address" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="col-md-6">
                                            <asp:Label ID="Label5" class="text-black" runat="server" Text="Phone *"></asp:Label>

                                            <asp:TextBox ID="c_diff_phone" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>

                                </div>

                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label6" class="text-black" runat="server" Text="Order Notes *"></asp:Label>
                            <asp:TextBox ID="c_order_notes" runat="server" CssClass="form-control" Rows="3" TextMode="MultiLine"></asp:TextBox>
                        </div>

                    </div>
                </div>
                
                <div class="col-md-6">

                    <div class="row mb-5">
                        <div class="col-md-12">
                            <h2 class="h3 mb-3 text-black">Coupon Code</h2>
                            <div class="p-3 p-lg-5 border">

                                <label for="c_code" class="text-black mb-3">Enter your coupon code if you have one</label>
                                <div class="input-group w-75">
                                    <input type="text" class="form-control" id="c_code" placeholder="Coupon Code" aria-label="Coupon Code" aria-describedby="button-addon2">
                                    <div class="input-group-append">
                                        <button class="btn btn-primary btn-sm" type="button" id="button-addon2">Apply</button>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>

                    <div class="row mb-5">
                        <div class="col-md-12">
                            <h2 class="h3 mb-3 text-black">Your Order</h2>
                            <div class="p-3 p-lg-5 border">
                                <div class="repeater-container">
                                    <!-- Start of repeater loop -->
                                    <asp:Repeater ID="ItemRepeater" runat="server">
                                        <ItemTemplate>
                                            <div class="row mb-3">
                                                <div class="col-md-6">
                                                    <span class="text-black"><%# Eval("SubCatName") %></span>
                                                    <!-- Assuming item has a 'Name' property -->
                                                </div>
                                                <div class="col-md-6 text-right">
                                                    <strong class="text-black">$<%# Eval("Price") %></strong>
                                                    <!-- Assuming item has a 'Price' property -->
                                                </div>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                    <!-- End of repeater loop -->

                                    <!-- Display subtotal and total -->
                                    <div class="row mb-5">
                                        <div class="col-md-6">
                                            <span class="text-black">ProductName</span>
                                        </div>
                                        <div class="col-md-6 text-right">
                                            <asp:Label ID="lblSubCatName" runat="server" Text='<%#"SubCatName" %>'></asp:Label>
                                        </div>
                                    </div>

                                     <div class="row mb-5">
                                      <div class="col-md-6">

                                     <span class="text-black">Quantity</span>
                                        </div>
                                   <div class="col-md-6 text-right">

                               <asp:Label ID="lblQuantity" runat="server" Text='<%# "Quantity" %>'></asp:Label>
                                  </div>
                                    </div>
                                         
                                    

                                    <div class="row mb-5">
                                        <div class="col-md-6">
                                            <span class="text-black">Subtotal</span>
                                        </div>
                                        <div class="col-md-6 text-right">
                                            <asp:Label ID="lblSubtotal" runat="server" Text='<%# "Subtotal" %>'></asp:Label>
                                        </div>
                                    </div>
                                    <div class="row mb-5">
                                        <div class="col-md-6">
                                            <span class="text-black">Discount Price</span>
                                        </div>
                                        <div class="col-md-6 text-right">
                                            <asp:Label ID="lbldiscount" runat="server" Text='<%# "Discount" %>'></asp:Label>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col-md-6">
                                            <span class="text-black">Total</span>
                                        </div>
                                        <div class="col-md-6 text-right">
                                            <asp:Label ID="lblTotal" runat="server" Text='<%# "TotalPrice" %>'></asp:Label>

                                        </div>
                                    </div>
                                </div>



<%--                                <asp:Panel runat="server" CssClass="border p-3 mb-3">--%>
                                    <h3 class="h6 mb-0">Select Payment Method:</h3>
                                    <asp:DropDownList ID="ddlPaymentMethod" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="ddlPaymentMethod_SelectedIndexChanged">
                                        <asp:ListItem Text="Direct Bank Transfer" Value="BankTransfer"></asp:ListItem>
                                        <asp:ListItem Text="SBI"></asp:ListItem>
                                        <asp:ListItem Text="HDCF"></asp:ListItem>
                                        <asp:ListItem Text="Bank of Baroda"></asp:ListItem>
                                        <asp:ListItem Text="Bank of India"></asp:ListItem>
                                        <asp:ListItem Text="Bank of Maharashtra"></asp:ListItem>
                                        <asp:ListItem Text="Canara Bank"></asp:ListItem>
                                        <asp:ListItem Text="Central Bank of India"></asp:ListItem>
                                        <asp:ListItem Text="Indian Bank"></asp:ListItem>
                                        <asp:ListItem Text="Punjab and Sind Bank"></asp:ListItem>
                                        <asp:ListItem Text="Punjab National Bank"></asp:ListItem>
                                        <asp:ListItem Text="State Bank of India"></asp:ListItem>
                                        <asp:ListItem Text="UCO Bank"></asp:ListItem>
                                        <asp:ListItem Text="Union Bank of India"></asp:ListItem>
                                        <asp:ListItem Text="Axis Bank"></asp:ListItem>
                                        <asp:ListItem Text="ICICI Bank"></asp:ListItem>
                                        <asp:ListItem Text="Cheque Payment"></asp:ListItem>
                                        <asp:ListItem>cheque payment</asp:ListItem>
                                    </asp:DropDownList>

                                    <div id="collapsebank" class="collapse">
                                        <div class="py-2">
                                            <p class="mb-0">Make your payment directly into our bank account. Please use your Order ID as the payment reference. Your order won’t be shipped until the funds have cleared in our account.</p>
                                        </div>
                                    </div>

                                    <div id="collapsecheque" class="collapse">
                                        <div class="py-2">
                                            <p class="mb-0">Make your payment by sending a cheque to our address. Please use your Order ID as the payment reference. Your order will be processed once the cheque is received and cleared.</p>
                                        </div>
                                    </div>

                                <asp:Panel runat="server" CssClass="border p-3 mb-3">
                                    <h3 class="h6 mb-0">Select Payment Method:</h3>
                                    <asp:DropDownList ID="dlPaymentMethod" runat="server" AutoPostBack="true" CssClass="form-control">
                                        <asp:ListItem Text="Cash on delivery" Value="cashondelvery"></asp:ListItem>
                                        <asp:ListItem>Cash on delivery </asp:ListItem>
                                    </asp:DropDownList>
                                </asp:Panel>


                                <div class="form-group">
<asp:LinkButton ID="btnPlaceOrder" runat="server" Text="Place Order" CssClass="btn btn-primary btn-lg py-3 btn-block" OnClick="btnPlaceOrder_Click1" OnClientClick="return validateForm();" />
                                </div>

                            </div>
                        </div>
                    </div>

                </div>
            </div>


<asp:LinkButton ID="btnPrintBill" runat="server" OnClick="btnPrintBill_Click" OnClientClick="return confirmPrint();" CssClass="btn">Print Bill</asp:LinkButton>

        <script>


        function toggleCollapse(id) {
           var collapseDiv = document.getElementById(id);
           if (collapseDiv.classList.contains('show')) {
               collapseDiv.classList.remove('show');
           } else {
               collapseDiv.classList.add('show');
           }
       }



        </script>

        <script type="text/javascript">
            function validateForm() {
                // Your validation logic goes here
                // For example, you can check if certain fields are filled out correctly
                if (/* validation passes */) {
                    return true; // Allow the server-side click event to execute
                } else {
                    // Display an error message or take any other necessary action
                    alert("Please fill out all required fields.");
                    return false; // Prevent the server-side click event from executing
                }
            }
        </script>

</asp:Content>

