<%@ Page Title="" Language="C#" MasterPageFile="~/Ecommerce-website/MasterPage.master" AutoEventWireup="true" CodeFile="Help.aspx.cs" Inherits="Ecommerce_website_Help" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
         .slider-height2 {
        background-color: #333; /* Set background color */
        padding: 80px 0; /* Add top and bottom padding */
        color: #fff; /* Set text color to white */
    }

    .hero-cap {
        margin-bottom: 30px; /* Add margin below hero caption */
    }

    .hero-cap h2 {
        font-size: 36px; /* Set font size for heading */
        font-weight: bold; /* Set font weight to bold */
        text-transform: uppercase; /* Transform text to uppercase */
    }

    /* Responsive styles */
    @media (max-width: 768px) {
        .slider-height2 {
            padding: 60px 0; /* Adjust padding on smaller screens */
        }
        .hero-cap h2 {
            font-size: 28px; /* Reduce font size for smaller screens */
        }
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <section id="contact">
         <br />
        <div class="slider-area" style="background-color: #3d464d;">
            <div class="slider-height2 d-flex align-items-center">
                <div class="container">
                    <div class="row">
                        <div class="col-xl-12">
                            <div class="hero-cap hero-cap2 text-center">
                                <h2 style="color: wheat">Help</h2>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Page Header End -->
         <br />
         <br />
        <div class="container">
            <h3 class="text-center text-uppercase">Help</h3>
            <p class="text-center w-75 m-auto">We welcome your inquiries and feedback at Fashion Adda. Our commitment to providing quality education and support extends to our communication with you. If you have any questions, suggestions, or concerns, please don't hesitate to reach out to us. You can contact us through the following:</p>
            <div class="row">
                <div class="col-sm-12 col-md-6 col-lg-4 my-5">
                    <div class="card border-0">
                        <div class="card-body text-center">
                            <i class="fa fa-phone fa-5x mb-3" aria-hidden="true"></i>
                            <h4 class="text-uppercase mb-5">call us</h4>
                            <p>+91 7070090550</p>
                        </div>
                    </div>
                </div>
                <div class="col-sm-12 col-md-6 col-lg-4 my-5">
                    <div class="card border-0">
                        <div class="card-body text-center">
                            <i class="fa fa-map-marker fa-5x mb-3" aria-hidden="true"></i>
                            <h4 class="text-uppercase mb-5">office loaction</h4>
                            <address>
                                B-211, Boaring Road Patna Bihar 800001
                            </address>
                        </div>
                    </div>
                </div>

                <div class="col-sm-12 col-md-6 col-lg-4 my-5">
                    <div class="card border-0">
                        <div class="card-body text-center">
                            <i class="fa fa-globe fa-5x mb-3" aria-hidden="true"></i>
                            <h4 class="text-uppercase mb-5">email</h4>
                            <p>FashionAdda@gmail.com</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js" integrity="sha384-b/U6ypiBEHpOf/4+1nzFpr53nxSS+GLCkfwBdFNTxtclqqenISfwAzpKaMNFNmj4" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js" integrity="sha384-h0AbiXch4ZDo7tp9hKZ4TsHbi047NrKGLO3SEJAg45jXxnGIfYzk4Si90RDIqNm1" crossorigin="anonymous"></script>


</asp:Content>

