<%@ Page Title="detail" Language="C#" MasterPageFile="~/Ecommerce-website/MasterPage.master" AutoEventWireup="true" CodeFile="detail.aspx.cs" Inherits="Ecommerce_website_detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <!-- Custom CSS -->
    <style>
        /* Add your custom styles here */
        .product {
            border: 1px solid #ddd;
            border-radius: 5px;
            overflow: hidden;
            position: relative;
            display:flex;
        }

        .product img {
            width: 60%;
            height: 60;
            display: block;
        }

        .product .status {
            position: absolute;
            top: 10px;
            right: 10px;
            background-color: #f8f9fa;
            padding: 5px 10px;
            border-radius: 5px;
            font-size: 14px;
        }

        .product .overlay {
            position: absolute;
            top: 0;
            left: 0;
            width: 65%;
            height: 60%;
            background-color: rgba(0, 0, 0, 0.5);
            opacity: 0;
            transition: opacity 0.3s ease;
        }

        .product:hover .overlay {
            opacity: 1;
        }

        .product .text {
            position: absolute;
            bottom: 0;
            left: 0;
            width: 100%;
            padding: 20px;
            background-color: rgba(255, 255, 255, 0.9);
            transition: transform 0.3s ease;
            transform: translateY(100%);
        }

        .product:hover .text {
            transform: translateY(0);
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <!-- Breadcrumb Start -->
    <div class="container-fluid">
        <div class="row px-xl-5">
            <div class="col-12">
                <nav class="breadcrumb bg-light mb-30">
                    <a class="breadcrumb-item text-dark" href="#">Home</a>
                    <a class="breadcrumb-item text-dark" href="#">Shop</a>
                    <span class="breadcrumb-item active">Shop Detail</span>
                </nav>
            </div>
        </div>
    </div>
    <!-- Breadcrumb End -->


    <!-- Shop Detail Start -->
    <div class="container-fluid pb-5">
        <div class="row px-xl-5">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            
            <div class="col-lg-5 mb-30">
                <div id="product-carousel" class="carousel slide" data-ride="carousel">
                    <div class="carousel-inner bg-light">
                        <div class="carousel-item active">
<%--                            <img class="w-100 h-100" src="img/product-1.jpg" alt="Image">--%>
                 <img src='<%# ResolveUrl(Eval("Image1", "~/Admin/productImages/{0}")) %>' class="w-100 h-100" alt="Product Image" />

                        </div>
                        <div class="carousel-item">
                     <img src='<%# ResolveUrl(Eval("Image2", "~/Admin/productImages/{0}")) %>' class="w-100 h-100" alt="Product Image" />

<%--                            <img class="w-100 h-100" src="img/product-2.jpg" alt="Image">--%>
                        </div>
                        <div class="carousel-item">
             <img src='<%# ResolveUrl(Eval("Image3", "~/Admin/productImages/{0}")) %>' class="w-100 h-100" alt="Product Image" />

<%--                            <img class="w-100 h-100" src="img/product-3.jpg" alt="Image">--%>
                        </div>
                        <%--<div class="carousel-item">
                            <img class="w-100 h-100" src="img/product-4.jpg" alt="Image">
                        </div>--%>
                    </div>
                    <a class="carousel-control-prev" href="#product-carousel" data-slide="prev">
                        <i class="fa fa-2x fa-angle-left text-dark"></i>
                    </a>
                    <a class="carousel-control-next" href="#product-carousel" data-slide="next">
                        <i class="fa fa-2x fa-angle-right text-dark"></i>
                    </a>
                </div>
                <div class="slick3-dot-overlay"></div>
            </div>

            <div class="col-lg-7 h-auto mb-30">
                <div class="h-100 bg-light p-30">
                    <h3><%#Eval("SubCatName") %></h3>
                    <div class="d-flex mb-3">
                        <div class="text-primary mr-2">
                            <small class="fas fa-star"></small>
                            <small class="fas fa-star"></small>
                            <small class="fas fa-star"></small>
                            <small class="fas fa-star-half-alt"></small>
                            <small class="far fa-star"></small>
                        </div>
                        <small class="pt-1">(99 Reviews)</small>
                    </div>
                    <h4><%# Eval("BrandName") %></h4>
                    <h3 class="font-weight-semi-bold mb-4"><%# Eval("Price") %></h3>
                    <p class="mb-4"><%# Eval("Description") %></p>
                    <div class="d-flex mb-3">
                        <strong class="text-dark mr-3"><%# Eval("Size") %>:</strong>
                        <form>
                            <div class="custom-control custom-radio custom-control-inline">
                                <input type="radio" class="custom-control-input" id="size-1" name="size">
                                <label class="custom-control-label" for="size-1">XS</label>
                            </div>
                            <div class="custom-control custom-radio custom-control-inline">
                                <input type="radio" class="custom-control-input" id="size-2" name="size">
                                <label class="custom-control-label" for="size-2">S</label>
                            </div>
                            <div class="custom-control custom-radio custom-control-inline">
                                <input type="radio" class="custom-control-input" id="size-3" name="size">
                                <label class="custom-control-label" for="size-3">M</label>
                            </div>
                            <div class="custom-control custom-radio custom-control-inline">
                                <input type="radio" class="custom-control-input" id="size-4" name="size">
                                <label class="custom-control-label" for="size-4">L</label>
                            </div>
                            <div class="custom-control custom-radio custom-control-inline">
                                <input type="radio" class="custom-control-input" id="size-5" name="size">
                                <label class="custom-control-label" for="size-5">XL</label>
                            </div>
                        </form>
                    </div>
                    <div class="d-flex mb-4">
                        <strong class="text-dark mr-3">Colors:</strong>
                        <form>
                            <div class="custom-control custom-radio custom-control-inline">
                                <input type="radio" class="custom-control-input" id="color-1" name="color">
                                <label class="custom-control-label" for="color-1">Black</label>
                            </div>
                            <div class="custom-control custom-radio custom-control-inline">
                                <input type="radio" class="custom-control-input" id="color-2" name="color">
                                <label class="custom-control-label" for="color-2">White</label>
                            </div>
                            <div class="custom-control custom-radio custom-control-inline">
                                <input type="radio" class="custom-control-input" id="color-3" name="color">
                                <label class="custom-control-label" for="color-3">Red</label>
                            </div>
                            <div class="custom-control custom-radio custom-control-inline">
                                <input type="radio" class="custom-control-input" id="color-4" name="color">
                                <label class="custom-control-label" for="color-4">Blue</label>
                            </div>
                            <div class="custom-control custom-radio custom-control-inline">
                                <input type="radio" class="custom-control-input" id="color-5" name="color">
                                <label class="custom-control-label" for="color-5">Green</label>
                            </div>
                        </form>
                    </div>

                   <%-- <asp:Label ID="lblQty" runat="server" Text="Qty:" Font-Size="Large"></asp:Label>
                                                <asp:Button ID="BtnMinus" CommandArgument='<%# Eval("ID") %>' CommandName="DoMinus" Font-Size="Large" runat="server" Text="-" />&nbsp
                                    <asp:TextBox ID="txtQuantity" runat="server" Width="40" Font-Size="Large" TextMode="SingleLine" Style="text-align: center" Text='<%# Eval("Quantity") %>'></asp:TextBox>&nbsp
                                     <asp:Button ID="BtnPlus" CommandArgument='<%# Eval("ID") %>' CommandName="DoPlus" runat="server" Text="+" Font-Size="Large" />&nbsp&nbsp&nbsp                                          
                                            </div>--%>


                    <div class="d-flex align-items-center mb-4 pt-2">
                        <div class="input-group quantity mr-3" style="width: 130px;">
                            <div class="input-group-btn">
                                <button class="btn btn-primary btn-minus">
                                    <i class="fa fa-minus"></i>
                                </button>
                            </div>
                            <input type="text" class="form-control bg-secondary border-0 text-center" value="'<%# Eval("Quantity") %>'" >
                            <div class="input-group-btn">
                                <button class="btn btn-primary btn-plus">
                                    <i class="fa fa-plus"></i>
                                </button>
                            </div>
                        </div>
                    
                       <asp:LinkButton ID="LinkButton1" runat="server" class="add-to-cart text-center py-2 mr-1" CommandName="AddToCart" CommandArgument='<%# Eval("SubCatName") %>'><span>Add to cart <i class="ion-ios-add ml-1"></i></span></asp:LinkButton>
                                                <a href="cart5.aspx" class="buy-now text-center py-2">Buy now<span><i class="ion-ios-cart ml-1"></i></span></a>
                                           
                    </div>
                    <div class="d-flex pt-2">
                        <strong class="text-dark mr-2">Share on:</strong>
                        <div class="d-inline-flex">
                            <a class="text-dark px-2" href="">
                                <i class="fab fa-facebook-f"></i>
                            </a>
                            <a class="text-dark px-2" href="">
                                <i class="fab fa-twitter"></i>
                            </a>
                            <a class="text-dark px-2" href="">
                                <i class="fab fa-linkedin-in"></i>
                            </a>
                            <a class="text-dark px-2" href="">
                                <i class="fab fa-pinterest"></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row px-xl-5">
            <div class="col">
                <div class="bg-light p-30">
                    <div class="nav nav-tabs mb-4">
                        <a class="nav-item nav-link text-dark active" data-toggle="tab" href="#tab-pane-1"></a>
                       <%-- <a class="nav-item nav-link text-dark" data-toggle="tab" href="#tab-pane-2">Information</a>
                        <a class="nav-item nav-link text-dark" data-toggle="tab" href="#tab-pane-3">Reviews (0)</a>--%>
                    </div>
                    <div class="tab-content">
                        <div class="tab-pane fade show active" id="tab-pane-1">
                            <h4 class="mb-3">Product Description</h4>
                            <p><%# Eval("Description") %></p>
<%--                            <p>Dolore magna est eirmod sanctus dolor, amet diam et eirmod et ipsum. Amet dolore tempor consetetur sed lorem dolor sit lorem tempor. Gubergren amet amet labore sadipscing clita clita diam clita. Sea amet et sed ipsum lorem elitr et, amet et labore voluptua sit rebum. Ea erat sed et diam takimata sed justo. Magna takimata justo et amet magna et.</p>--%>
                        </div>
        </ItemTemplate>
    </asp:Repeater>

            <h1>More Products</h1>

            <div class="container">
        <div class="row">
            <div class="col-md-6">
                <div class="col-sm col-md-6 col-lg ftco-animate">
                     <asp:Repeater ID="moreRepeater" runat="server">

                  <ItemTemplate>
                        <div class="col-sm col-md-6 col-lg ftco-animate">
                                    <div class="product">
                                            <img class="img-fluid" runat="server" src='<%#Eval("Image1", "~/Admin/productImages/{0}") %>' alt="Colorlib Template">
                                            <span class="status">30%</span>
                                            <div class="overlay"></div>
                                        </a>
                                        <div class="text py-3 px-3">
                                                <asp:Label ID="lblSubCatName" runat="server" Text='<%# Eval("SubCatName") %>'></asp:Label></a></h3>
                                            <div class="d-flex">
                                                <div class="pricing">
                                                    <p class="price">
                                                        <span class="mr-2 price-dc">₹
                                                <asp:Label ID="lblPrice" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
                                                    </p>
                                                </div>
                                                <div class="rating">
                                                    <p class="text-right">
                                                        <a href="#"><span class="ion-ios-star-outline"></span></a>
                                                        <a href="#"><span class="ion-ios-star-outline"></span></a>
                                                        <a href="#"><span class="ion-ios-star-outline"></span></a>
                                                        <a href="#"><span class="ion-ios-star-outline"></span></a>
                                                        <a href="#"><span class="ion-ios-star-outline"></span></a>
                                                    </p>
                                                </div>
                                            </div>
                                            <a href='<%# "detail.aspx?SubCatName=" + Eval("SubCatName") %>' class="btn btn-primary">View Details</a>
                                            <p class="bottom-area d-flex px-3">
                                           <asp:LinkButton ID="LinkButton1" runat="server" class="add-to-cart text-center py-2 mr-1" CommandName="AddToCart" CommandArgument='<%# Eval("SubCatName") %>'><span>Add to cart <i class="ion-ios-add ml-1"></i></span></asp:LinkButton>
                                                <a href="cart5.aspx" class="buy-now text-center py-2">Buy now<span><i class="ion-ios-cart ml-1"></i></span></a>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                      
                  </ItemTemplate>



                  </asp:Repeater>
                </div>
                </div>
            </div>
                
            </div>
    </div>
    </div>
   
                        <%--<div class="tab-pane fade" id="tab-pane-2">
                            <h4 class="mb-3">Additional Information</h4>
                            <p>Eos no lorem eirmod diam diam, eos elitr et gubergren diam sea. Consetetur vero aliquyam invidunt duo dolores et duo sit. Vero diam ea vero et dolore rebum, dolor rebum eirmod consetetur invidunt sed sed et, lorem duo et eos elitr, sadipscing kasd ipsum rebum diam. Dolore diam stet rebum sed tempor kasd eirmod. Takimata kasd ipsum accusam sadipscing, eos dolores sit no ut diam consetetur duo justo est, sit sanctus diam tempor aliquyam eirmod nonumy rebum dolor accusam, ipsum kasd eos consetetur at sit rebum, diam kasd invidunt tempor lorem, ipsum lorem elitr sanctus eirmod takimata dolor ea invidunt.</p>
                            <div class="row">
                                <div class="col-md-6">
                                    <ul class="list-group list-group-flush">
                                        <li class="list-group-item px-0">
                                            Sit erat duo lorem duo ea consetetur, et eirmod takimata.
                                        </li>
                                        <li class="list-group-item px-0">
                                            Amet kasd gubergren sit sanctus et lorem eos sadipscing at.
                                        </li>
                                        <li class="list-group-item px-0">
                                            Duo amet accusam eirmod nonumy stet et et stet eirmod.
                                        </li>
                                        <li class="list-group-item px-0">
                                            Takimata ea clita labore amet ipsum erat justo voluptua. Nonumy.
                                        </li>
                                      </ul> 
                                </div>
                                <div class="col-md-6">
                                    <ul class="list-group list-group-flush">
                                        <li class="list-group-item px-0">
                                            Sit erat duo lorem duo ea consetetur, et eirmod takimata.
                                        </li>
                                        <li class="list-group-item px-0">
                                            Amet kasd gubergren sit sanctus et lorem eos sadipscing at.
                                        </li>
                                        <li class="list-group-item px-0">
                                            Duo amet accusam eirmod nonumy stet et et stet eirmod.
                                        </li>
                                        <li class="list-group-item px-0">
                                            Takimata ea clita labore amet ipsum erat justo voluptua. Nonumy.
                                        </li>
                                      </ul> 
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane fade" id="tab-pane-3">
                            <div class="row">
                                <div class="col-md-6">
                                    <h4 class="mb-4">1 review for "Product Name"</h4>
                                    <div class="media mb-4">
                                        <img src="img/user.jpg" alt="Image" class="img-fluid mr-3 mt-1" style="width: 45px;">
                                        <div class="media-body">
                                            <h6>John Doe<small> - <i>01 Jan 2045</i></small></h6>
                                            <div class="text-primary mb-2">
                                                <i class="fas fa-star"></i>
                                                <i class="fas fa-star"></i>
                                                <i class="fas fa-star"></i>
                                                <i class="fas fa-star-half-alt"></i>
                                                <i class="far fa-star"></i>
                                            </div>
                                            <p>Diam amet duo labore stet elitr ea clita ipsum, tempor labore accusam ipsum et no at. Kasd diam tempor rebum magna dolores sed sed eirmod ipsum.</p>
                                        </div>
                                    </div>
                                </div>--%>
                               <%-- <div class="col-md-6">
                                    <h4 class="mb-4">Leave a review</h4>
                                    <small>Your email address will not be published. Required fields are marked *</small>
                                    <div class="d-flex my-3">
                                        <p class="mb-0 mr-2">Your Rating * :</p>
                                        <div class="text-primary">
                                            <i class="far fa-star"></i>
                                            <i class="far fa-star"></i>
                                            <i class="far fa-star"></i>
                                            <i class="far fa-star"></i>
                                            <i class="far fa-star"></i>
                                        </div>
                                    </div>
                                    <form>
                                        <div class="form-group">
                                            <label for="message">Your Review *</label>
                                            <textarea id="message" cols="30" rows="5" class="form-control"></textarea>
                                        </div>
                                        <div class="form-group">
                                            <label for="name">Your Name *</label>
                                            <input type="text" class="form-control" id="name">
                                        </div>
                                        <div class="form-group">
                                            <label for="email">Your Email *</label>
                                            <input type="email" class="form-control" id="email">
                                        </div>
                                        <div class="form-group mb-0">
                                            <input type="submit" value="Leave Your Review" class="btn btn-primary px-3">
                                        </div>
                                    </form>
                                </div>
                            </div>--%>
<%--                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>--%>
    <!-- Shop Detail End -->

</asp:Content>

