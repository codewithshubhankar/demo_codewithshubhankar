<%@ Page Title="" Language="C#" MasterPageFile="~/Ecommerce-website/MasterPage.master" AutoEventWireup="true" CodeFile="cart5.aspx.cs" Inherits="Ecommerce_website_cart5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
    /* Customize table styles */

    .a{
        background-repeat:no-repeat;
       
    }

    .ftco-section .container {
        padding: 40px;
    }
    
    .table {
        width: 100%;
        margin-bottom: 1rem;
        color: #212529;
    }
    
    .thead-primary th {
        background-color: #007bff;
        color: #fff;
    }
    
    .table td, .table th {
        padding: .75rem;
        vertical-align: top;
        border-top: 1px solid #dee2e6;
    }
    
    .table tbody tr:nth-of-type(odd) {
        background-color: rgba(0, 123, 255, 0.05);
    }
    
    .table tbody tr:hover {
        background-color: rgba(0, 123, 255, 0.1);
    }


   .repeater-container {
    padding: 1rem; /* This will add 1rem (16px) of padding on all sides */
    border: 1px solid #ccc;
    border-radius: 5px;
}


.item-row {
    border-bottom: 1px solid #eee;
}

.item-name {
    font-weight: bold;
}

.subtotal-row,
.discount-row,
.total-row {
    border-top: 1px solid #eee;
    padding-top: 10px;
}

.text-right {
    text-align: right;
}

.text-black {
    color: #333;
}

.text-green {
    color: green;
}


.repeater-container{
    width:300px;
           margin-right:70px;

    
}

.cart-total {
        background-color: #fff;
        border: 2px solid #ccc;
        border-radius: 5px;
        padding: 20px;
    }

    .cart-total h3 {
        margin-top: 0;
        margin-bottom: 20px;
        font-size: 24px;
        color: #333;
    }

    .item-name {
        font-weight: bold;
    }

    .subtotal-row,
    .discount-row,
    .total-row {
        border-top: 1px solid #ddd;
        padding-top: 10px;
        margin-top: 10px;
    }

    .text-black {
        color: #333;
    }

    .text-right {
        text-align: right;
    }

    .btn-checkout {
        background-color: #007bff;
        color: #fff;
        border: none;
        border-radius: 5px;
        padding: 10px 20px;
        font-size: 18px;
        cursor: pointer;
        transition: background-color 0.3s ease;
    }

    .btn-checkout:hover {
        background-color: #0056b3;
    }
</style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<%--    <div class="hero-wrap hero-bread a" style="background-image: url('img/OIP.jpg');">--%>
    <div class="container">   
        <div class="row no-gutters slider-text align-items-center justify-content-center">
            <div class="col-md-9 ftco-animate text-center">
                <p class="breadcrumbs">
                    <a href="Default.aspx">Home</a>
                    <span class="mr-2">/</span>
                    <span>Cart</span>
                </p>
                <h1 class="mb-0 bread">My Cart</h1>
            </div>
        </div>
    </div>

    


  

    <div class="container-fluid content-wrapper">
        <div class="row px-xl-5">
        <% if (Repeater1.Items.Count == 0) { %>
            <div class="col-lg-8 text-center mb-5">
                <div class="alert alert-info">
                    Your cart is empty.
                </div>
            </div>
        <% } else { %>
    <div class="row px-xl-5">
            
        <!-- Cart Table -->
        <div class="col-lg-8 table-responsive mb-5">
                <table class="table table-light table-borderless table-hover text-center mb-0">
                    <!-- Table Header -->
                <thead class="thead-dark">
                    <tr class="text-center">
                        <th>&nbsp;</th>                    
                        <th>Image</th>                        
                        <th>Product name</th>  
                        <th>Description</th>                        
                        <th>Price</th>                       
                        <th>Quantity</th>                        
                        <th>Total</th>                           
                        <th>Remove</th> 
                    </tr>
                </thead>
                <!-- Table Body -->
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                        <ItemTemplate>

          
                            <tr class="text-center">
                                <td class="product-remove">
                                    <asp:LinkButton runat="server" CommandName="RemoveFromCart" CommandArgument='<%# Container.ItemIndex %>'>
                                        <span class="ion-ios-close"></span>
                                    </asp:LinkButton>
                                </td>
                                <td class="image-prod">
                                    <asp:Image ID="Image1" runat="server" CssClass="img" ImageUrl='<%# Eval("Image1", "../Admin/ProductImages/{0}") %>' Height="50" Width="50"/>
                                </td>
                                <td class="product-name">
                                    <h3><%# Eval("SubCatName") %></h3>
                                </td>
                                <td>
                                    <p><%# Eval("Description") %></p>
                                </td>
                                <td class="price"> <%# Eval("Price") %></td>


                                 <td class="quantity">
                                                <div class="input-group mb-3">
                                                    <span class="input-group-btn mr-2">
                                                        <button type="button" class="quantity-left-minus" data-type="minus" data-field="" commandname="Decreaseproduct" commandargument='<%# Container.ItemIndex %>' onclick="Increaseproduct_click">
                                                            <i class="ion-ios-remove"></i>
                                                        </button>
                                                        
                                                    </span>
                                                    <asp:TextBox ID="lblQty" runat="server" class="quantity form-control input-number" Text='<%# Eval("Quantity") %>' data-product-id='<%= Session["ID"] %>'></asp:TextBox>
                                                    <span class="input-group-btn ml-2">
                                                        <button type="button" class="quantity-right-plus" data-type="plus" data-field="" commandname="Increaseproduct" commandargument='<%# Container.ItemIndex %>'>
                                                            <i class="ion-ios-add"></i>
                                                        </button>
                                                        
                                                    </span>
                                                </div>
                                            </td>
                                <!-- Total price -->
                                <td class="total"> <%# Eval("TotalPrice") %></td>
                                <!-- Remove button -->
                                <td class="product-remove">
                                    <asp:LinkButton runat="server" CommandName="RemoveFromCart" CommandArgument='<%# Container.ItemIndex %>'
                                        OnClientClick="return confirm('Are you sure you want to remove this item from the cart?');">
                                        <span class="ion-ios-close">
                                            <button class="input-group-btn alert-danger">X</button>
                                        </span>
                                    </asp:LinkButton>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
             <% } %>
            </div>


       



        <div class="col-sm-3 mt-5 ftco-animate">
    <div class="cart-total mb-3">
        <h3>Cart Totals</h3>
        
        <asp:Repeater ID="ItemRepeater" runat="server">
            <ItemTemplate>
                <div class="row mb-3">
                    <div class="col-md-6">
                        <span class="text-black"><%# Eval("SubCatName") %></span> 
                    </div>
                    <div class="col-md-6 text-right">
                        <strong class="text-black">$<%# Eval("Price") %></strong> 
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
       

        <div class="row mb-5">
            <div class="col-md-6">
                <span class="text-danger">Subtotal</span>
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
                <span class="text-info">Total</span>
            </div>
            <div class="col-md-6 text-right">
                <asp:Label ID="lblTotal" runat="server" Text='<%# "Total" %>'></asp:Label>
            </div>
        </div>
        
        <div class="row">
            <div class="col-md-12">
                <a href="Checkout1.aspx" class="btn btn-primary py-3 px-4 btn-block">Proceed to Checkout</a>
            </div>   
        </div>
    </div>
</div>



    </div>
            
                        <a href="shop.aspx" class="btn btn-secondary btn-sm">Continue Shopping</a>

        </div>
            <asp:Button ID="btnUpdateTotal" runat="server" Text="Update" CssClass="btn btn-primary" OnClick="btnUpdateTotal_Click" />

      
       





  <%--  <script>
        function getAvailableQuantity(ID) {
            $.ajax({
                type: "POST",
                url: "cart5.aspx/GetAvailableQuantity",
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify({ ID: ID }),
                dataType: "json",
                success: function (response) {
                    // On success, handle the response
                    console.log("Available Quantity:", response.d);
                },
                error: function (xhr, status, error) {
                    // Handle errors if any
                    console.error('Error fetching available quantity:', error);
                }
            });
        }
    </script>--%>



    <script>
        // Add event listeners to plus buttons
        //document.querySelectorAll('.btn-plus').forEach(button => {
        //    button.addEventListener('click', () => {
        //        const parentRow = button.closest('tr'); // Find the parent row
        //        const quantityInput = parentRow.querySelector('.quantity-input');
        //        const totalPriceElement = parentRow.querySelector('.total');
        //        const priceElement = parentRow.querySelector('.price');

        //        // Retrieve current values
        //        let price = parseFloat(priceElement.innerText);
        //        let quantity = parseInt(quantityInput.value);

        //        // Update values
        //        quantityInput.value = quantity + 1;
        //        totalPriceElement.innerText = (price * (quantity + 1)).toFixed(0); // Update total price
        //    });
        //});

        //// Add event listeners to minus buttons
        //document.querySelectorAll('.btn-minus').forEach(button => {
        //    button.addEventListener('click', () => {
        //        const parentRow = button.closest('tr'); // Find the parent row
        //        const quantityInput = parentRow.querySelector('.quantity-input');
        //        const totalPriceElement = parentRow.querySelector('.total');
        //        const priceElement = parentRow.querySelector('.price');

        //        // Retrieve current values
        //        let price = parseFloat(priceElement.innerText);
        //        let quantity = parseInt(quantityInput.value);

        //        // Ensure quantity is greater than 1 before decrementing
        //        if (quantity > 1) {
        //            quantityInput.value = quantity - 1;
        //            totalPriceElement.innerText = (price * (quantity - 1)).toFixed(0); // Update total price
        //        }
        //    });
        //});

        //Get all add buttons with class 'quantity-right-plus'

        var addButtonList = document.querySelectorAll('.quantity-right-plus');

        // Iterate over each add button
        addButtonList.forEach(function (button) {
            // Add click event listener to the button
            button.addEventListener('click', function () {
                // Find the input field for the quantity in the same row
                var inputField = this.parentElement.parentElement.querySelector('.input-number');

                // Get the current value of the input field
                var currentValue = parseInt(inputField.value);
                //// Increase the quantity by 1
                //var newValue = currentValue + 1;
                //// Update the value of the input field
                //inputField.value = newValue;

                //updateTotalPrice(inputField);
                var pid = inputField.dataset.productId;
                var sessionId = '<%= Session["ID"] %>';
                console.log(sessionId);

                // Get the maximum available quantity from the database
                var availableQuantity = getAvailableQuantity(pid);
                console.log(availableQuantity + "hello");

                // Check if increasing quantity will exceed available stock
                if (currentValue < availableQuantity) {
                    // Increase the quantity by 1
                    var newValue = currentValue + 1;

                    // Update the value of the input field
                    inputField.value = newValue;

                    // Recalculate total price
                    updateTotalPrice(inputField);
                } else {
                    // Display out of stock message or handle as needed
                    alert("Out of Stock");
                }
            });
        });


        // Function to update total price
        function updateTotalPrice(inputField) {
            // Find the parent row of the input field
            var row = inputField.parentElement.parentElement.parentElement;

            // Get the price and quantity from the row
            var price = parseFloat(row.querySelector('.price').textContent.trim().substring(1)); // Remove the currency symbol and convert to float
            var quantity = parseInt(inputField.value);

            // Calculate the total price
            var totalPrice = price * quantity;

            // Update the total price in the row
            row.querySelector('.total').textContent = '₹ ' + totalPrice.toFixed(2); // Format the total price with 2 decimal places
        }
    </script>


 


</asp:Content>