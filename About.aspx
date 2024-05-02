<%@ Page Title="" Language="C#" MasterPageFile="~/Ecommerce-website/MasterPage.master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="Ecommerce_website_About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
    /* Custom CSS for About Us section design */
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


    <div class="slider-height2 d-flex align-items-center">
                <div class="container">
                    <div class="row">
                        <div class="col-xl-12">
                            <div class="hero-cap hero-cap2 text-center">
                                <h2 style="color: wheat">About Us</h2>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    <div class="container-xxl py-5">
    <div class="container">
        <div class="row g-5 align-items-center">
            <div class="col-lg-10 wow fadeInUp" data-wow-delay="0.1s">
                <h1 class="mb-4 text-center">WELCOME TO FASHION ADDA!</h1>
                <p>Fashion Adda was created in 2024 out of a passion for incredible style and service. The then one-woman operation saw rapid growth through immense hard work and a commitment to provide unique fashion goods.</p>
                <p>Fashion Adda has managed to become one of the most successful market leaders by incorporating a diverse product portfolio and loyal clientele. The brand has hence been recognized as one of the most preferred importers and distributors for all the leading international fashion brands dealing in clothing, accessories, and more.</p>
                <p>The company distributes its multi-category product portfolio across the country and has built a pan-India distribution network covering top-tier cities and towns. We lay a strong emphasis on quality, professional packaging, and timely home deliveries.</p>

                <h1>Our Mission</h1>
                <p>From the beginning, our mission has been to bring the world’s finest fashion to our customers and make it collectively accessible. Today, people all over the country seek superior quality and stylish products. We consider it a privilege to be able to help. As choices continue to evolve, our commitment will forever be the same: helping people access the world’s finest fashion.</p>

                <h1>OUR CLIENTS:</h1>
                <p>We are incredibly proud of our association with an exclusive clientele;</p>
                <p>We cater to diverse formats ranging from :</p>

                <ul style="position: relative; left: 18px">
                    <li style="list-style: disc; font-size: 14px;">Fashion Boutiques</li>
                    <li style="list-style: disc; font-size: 14px;">Retail Stores</li>
                    <li style="list-style: disc; font-size: 14px;">Online Marketplaces</li>
                    <li style="list-style: disc; font-size: 14px;">Fashion Events</li>
                    <li style="list-style: disc; font-size: 14px;">Individual Customers</li>
                </ul>

                <h1>OUR RANGE OF PRODUCTS:</h1>
                <p>Having established ourselves as the forerunner in the fashion distribution chain, we endeavor to offer our products at competitive rates with no compromise in quality.</p>
                <ul style="position: relative; left: 18px">
                    <li style="list-style: disc; font-size: 14px;">Clothing</li>
                    <li style="list-style: disc; font-size: 14px;">Accessories</li>
                    <li style="list-style: disc; font-size: 14px;">Footwear</li>
                    <li style="list-style: disc; font-size: 14px;">Jewelry</li>
                    <li style="list-style: disc; font-size: 14px;">Bags</li>
                    <li style="list-style: disc; font-size: 14px;">Beauty Products</li>
                </ul>
                <p>Fashion Adda is proud to be a subunit of Adda Fashion Pvt. Ltd.</p>
                <p>Please visit our FAQ page for more information about our products and services.</p>

            </div>
        </div>
    </div>
</div>

</asp:Content>

