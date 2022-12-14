#pragma checksum "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Shared\_QuickViewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb1893ea67e1569e67bea208e731c7bf1021d4ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__QuickViewProduct), @"mvc.1.0.view", @"/Views/Shared/_QuickViewProduct.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\_ViewImports.cshtml"
using ElectronicSalesManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\_ViewImports.cshtml"
using ElectronicSalesManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\_ViewImports.cshtml"
using ElectronicSalesManagement.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\_ViewImports.cshtml"
using Core.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb1893ea67e1569e67bea208e731c7bf1021d4ad", @"/Views/Shared/_QuickViewProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d1a8f12826ad9c4c89e83498a6afeb80b54d5b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__QuickViewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <!-- QUICKVIEW PRODUCT -->
<div id=""quickview-wrapper"">
    <!-- Modal -->
    <div class=""modal fade"" id=""productModal"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog modal__container"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                </div>
                <div class=""modal-body"">
                    <div class=""modal-product"">
                        <!-- Start product images -->
                        <div class=""product-images"">
                            <div class=""main-image images"">
                                <img alt=""big images"" src=""images/product/big-img/1.jpg"">
                            </div>
                        </div>
                        <!-- end product images -->
                        <div class=""product-info"">
                 ");
            WriteLiteral(@"           <h1>Simple Fabric Bags</h1>
                            <div class=""rating__and__review"">
                                <ul class=""rating"">
                                    <li><span class=""ti-star""></span></li>
                                    <li><span class=""ti-star""></span></li>
                                    <li><span class=""ti-star""></span></li>
                                    <li><span class=""ti-star""></span></li>
                                    <li><span class=""ti-star""></span></li>
                                </ul>
                                <div class=""review"">
                                    <a href=""#"">4 customer reviews</a>
                                </div>
                            </div>
                            <div class=""price-box-3"">
                                <div class=""s-price-box"">
                                    <span class=""new-price"">$17.20</span>
                                    <span class=""old-price");
            WriteLiteral(@""">$45.00</span>
                                </div>
                            </div>
                            <div class=""quick-desc"">
                                Designed for simplicity and made from high quality materials. Its sleek geometry and material combinations creates a modern look.
                            </div>
                            <div class=""select__color"">
                                <h2>Select color</h2>
                                <ul class=""color__list"">
                                    <li class=""red""><a title=""Red"" href=""#"">Red</a></li>
                                    <li class=""gold""><a title=""Gold"" href=""#"">Gold</a></li>
                                    <li class=""orange""><a title=""Orange"" href=""#"">Orange</a></li>
                                    <li class=""orange""><a title=""Orange"" href=""#"">Orange</a></li>
                                </ul>
                            </div>
                            <div class=""select__size");
            WriteLiteral(@""">
                                <h2>Select size</h2>
                                <ul class=""color__list"">
                                    <li class=""l__size""><a title=""L"" href=""#"">L</a></li>
                                    <li class=""m__size""><a title=""M"" href=""#"">M</a></li>
                                    <li class=""s__size""><a title=""S"" href=""#"">S</a></li>
                                    <li class=""xl__size""><a title=""XL"" href=""#"">XL</a></li>
                                    <li class=""xxl__size""><a title=""XXL"" href=""#"">XXL</a></li>
                                </ul>
                            </div>
                            <div class=""social-sharing"">
                                <div class=""widget widget_socialsharing_widget"">
                                    <h3 class=""widget-title-modal"">Share this product</h3>
                                    <ul class=""social-icons"">
                                        <li><a target=""_blank"" title=""rss"" href");
            WriteLiteral(@"=""#"" class=""rss social-icon""><i class=""zmdi zmdi-rss""></i></a></li>
                                        <li><a target=""_blank"" title=""Linkedin"" href=""#"" class=""linkedin social-icon""><i class=""zmdi zmdi-linkedin""></i></a></li>
                                        <li><a target=""_blank"" title=""Pinterest"" href=""#"" class=""pinterest social-icon""><i class=""zmdi zmdi-pinterest""></i></a></li>
                                        <li><a target=""_blank"" title=""Tumblr"" href=""#"" class=""tumblr social-icon""><i class=""zmdi zmdi-tumblr""></i></a></li>
                                        <li><a target=""_blank"" title=""Pinterest"" href=""#"" class=""pinterest social-icon""><i class=""zmdi zmdi-pinterest""></i></a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class=""addtocart-btn"">
                                <a href=""#""><i class=""fas fa-cart-plus""></i>&nbsp;Add to cart</a>
                            ");
            WriteLiteral(@"</div>
                        </div><!-- .product-info -->
                    </div><!-- .modal-product -->
                </div><!-- .modal-body -->
            </div><!-- .modal-content -->
        </div><!-- .modal-dialog -->
    </div>
    <!-- END Modal -->
</div>
<!-- END QUICKVIEW PRODUCT -->
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
