#pragma checksum "C:\Users\sh13ld\Desktop\Code\Home\ManyToMany - Copy\WebApplication1\WebApplication1\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4b521aed6cece0015487b6f36c3c252a726f157"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\sh13ld\Desktop\Code\Home\ManyToMany - Copy\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sh13ld\Desktop\Code\Home\ManyToMany - Copy\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sh13ld\Desktop\Code\Home\ManyToMany - Copy\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4b521aed6cece0015487b6f36c3c252a726f157", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc9bdb69e3be835c01fb39ce31d0d03864af570", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sh13ld\Desktop\Code\Home\ManyToMany - Copy\WebApplication1\WebApplication1\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral(" \r\n    <style>\r\n        .product-img .default-img, .product-img .hover-img{\r\n            width:190px;\r\n            height:190px;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"
        <main class=""main"">
            <div class=""page-header mt-30 mb-50"">

            </div>
            <div class=""container mb-30"">
                <div class=""row flex-row-reverse"">
                    <div class=""col-lg-4-5"">
                        <div class=""shop-product-fillter"">
                            <div class=""totall-product"">
                                <p>We found <strong class=""text-brand"">29</strong> items for you!</p>
                            </div>
                            <div class=""sort-by-product-area"">
                                <div class=""sort-by-cover mr-10"">
                                    <div class=""sort-by-product-wrap"">
                                        <div class=""sort-by"">
                                            <span><i class=""fi-rs-apps""></i>Show:</span>
                                        </div>
                                        <div class=""sort-by-dropdown-wrap"">
                                         ");
            WriteLiteral(@"   <span> 50 <i class=""fi-rs-angle-small-down""></i></span>
                                        </div>
                                    </div>
                                    <div class=""sort-by-dropdown"">
                                        <ul>
                                            <li><a class=""active"" href=""#"">50</a></li>
                                            <li><a href=""#"">100</a></li>
                                            <li><a href=""#"">150</a></li>
                                            <li><a href=""#"">200</a></li>
                                            <li><a href=""#"">All</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class=""sort-by-cover"">
                                    <div class=""sort-by-product-wrap"">
                                        <div class=""sort-by"">
                                            <sp");
            WriteLiteral(@"an><i class=""fi-rs-apps-sort""></i>Sort by:</span>
                                        </div>
                                        <div class=""sort-by-dropdown-wrap"">
                                            <span> Featured <i class=""fi-rs-angle-small-down""></i></span>
                                        </div>
                                    </div>
                                    <div class=""sort-by-dropdown"">
                                        <ul>
                                            <li><a class=""active"" href=""#"">Featured</a></li>
                                            <li><a href=""#"">Price: Low to High</a></li>
                                            <li><a href=""#"">Price: High to Low</a></li>
                                            <li><a href=""#"">Release Date</a></li>
                                            <li><a href=""#"">Avg. Rating</a></li>
                                        </ul>
                                    </div>
       ");
            WriteLiteral("                         </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"row product-grid\">\r\n                            ");
#nullable restore
#line 68 "C:\Users\sh13ld\Desktop\Code\Home\ManyToMany - Copy\WebApplication1\WebApplication1\Views\Product\Index.cshtml"
                       Write(await Html.PartialAsync("~/Views/Shared/_ProductParial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3657, "\"", 3686, 1);
#nullable restore
#line 70 "C:\Users\sh13ld\Desktop\Code\Home\ManyToMany - Copy\WebApplication1\WebApplication1\Views\Product\Index.cshtml"
WriteAttributeValue("", 3665, ViewBag.ProductCount, 3665, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""proCount"" />
            <div class=""d-flex justify-content-center mb-30"">
                <button class=""btn btn-brand"" id=""btnLoadMore"">Load more</button>
            </div>
                        <!--product grid-->
                        
");
            WriteLiteral(@"
                        <!--End Deals-->
                    </div>
                    <div class=""col-lg-1-5 primary-sidebar sticky-sidebar"">
                        <div class=""sidebar-widget widget-category-2 mb-30"">
                            <h5 class=""section-title style-1 mb-30"">Category</h5>
");
#nullable restore
#line 99 "C:\Users\sh13ld\Desktop\Code\Home\ManyToMany - Copy\WebApplication1\WebApplication1\Views\Product\Index.cshtml"
                     foreach (Category item in ViewBag.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"category-filter\" data-id=\"");
#nullable restore
#line 101 "C:\Users\sh13ld\Desktop\Code\Home\ManyToMany - Copy\WebApplication1\WebApplication1\Views\Product\Index.cshtml"
                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <a> <img");
            BeginWriteAttribute("src", " src=\"", 5730, "\"", 5763, 2);
            WriteAttributeValue("", 5736, "assets/imgs/shop/", 5736, 17, true);
#nullable restore
#line 102 "C:\Users\sh13ld\Desktop\Code\Home\ManyToMany - Copy\WebApplication1\WebApplication1\Views\Product\Index.cshtml"
WriteAttributeValue("", 5753, item.Logo, 5753, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5764, "\"", 5770, 0);
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 102 "C:\Users\sh13ld\Desktop\Code\Home\ManyToMany - Copy\WebApplication1\WebApplication1\Views\Product\Index.cshtml"
                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><span class=\"count\">");
#nullable restore
#line 102 "C:\Users\sh13ld\Desktop\Code\Home\ManyToMany - Copy\WebApplication1\WebApplication1\Views\Product\Index.cshtml"
                                                                                                             Write(item.Products.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </li>\r\n");
#nullable restore
#line 104 "C:\Users\sh13ld\Desktop\Code\Home\ManyToMany - Copy\WebApplication1\WebApplication1\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <!-- Fillter By Price -->
                        <div class=""sidebar-widget price_range range mb-30"">
                            <h5 class=""section-title style-1 mb-30"">Fill by price</h5>
                            <div class=""price-filter"">
                                <div class=""price-filter-inner"">
                                    <div id=""slider-range"" class=""mb-20""></div>
                                    <div class=""d-flex justify-content-between"">
                                        <div class=""caption"">From: <strong id=""slider-range-value1"" class=""text-brand""></strong></div>
                                        <div class=""caption"">To: <strong id=""slider-range-value2"" class=""text-brand""></strong></div>
                                    </div>
                                </div>
                            </div>
                            <div class=""list-group"">
                                <div class=""li");
            WriteLiteral(@"st-group-item mb-10 mt-10"">
                                    <label class=""fw-900"">Color</label>
                                    <div class=""custome-checkbox"">
                                        <input class=""form-check-input"" type=""checkbox"" name=""checkbox"" id=""exampleCheckbox1""");
            BeginWriteAttribute("value", " value=\"", 7210, "\"", 7218, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <label class=""form-check-label"" for=""exampleCheckbox1""><span>Red (56)</span></label>
                                        <br />
                                        <input class=""form-check-input"" type=""checkbox"" name=""checkbox"" id=""exampleCheckbox2""");
            BeginWriteAttribute("value", " value=\"", 7523, "\"", 7531, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <label class=""form-check-label"" for=""exampleCheckbox2""><span>Green (78)</span></label>
                                        <br />
                                        <input class=""form-check-input"" type=""checkbox"" name=""checkbox"" id=""exampleCheckbox3""");
            BeginWriteAttribute("value", " value=\"", 7838, "\"", 7846, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <label class=""form-check-label"" for=""exampleCheckbox3""><span>Blue (54)</span></label>
                                    </div>
                                    <label class=""fw-900 mt-15"">Item Condition</label>
                                    <div class=""custome-checkbox"">
                                        <input class=""form-check-input"" type=""checkbox"" name=""checkbox"" id=""exampleCheckbox11""");
            BeginWriteAttribute("value", " value=\"", 8305, "\"", 8313, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <label class=""form-check-label"" for=""exampleCheckbox11""><span>New (1506)</span></label>
                                        <br />
                                        <input class=""form-check-input"" type=""checkbox"" name=""checkbox"" id=""exampleCheckbox21""");
            BeginWriteAttribute("value", " value=\"", 8622, "\"", 8630, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <label class=""form-check-label"" for=""exampleCheckbox21""><span>Refurbished (27)</span></label>
                                        <br />
                                        <input class=""form-check-input"" type=""checkbox"" name=""checkbox"" id=""exampleCheckbox31""");
            BeginWriteAttribute("value", " value=\"", 8945, "\"", 8953, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <label class=""form-check-label"" for=""exampleCheckbox31""><span>Used (45)</span></label>
                                    </div>
                                </div>
                            </div>
                            <a href=""shop-grid-right.html"" class=""btn btn-sm btn-default""><i class=""fi-rs-filter mr-5""></i> Fillter</a>
                        </div>

                        <div class=""banner-img wow fadeIn mb-lg-0 animated d-lg-block d-none"">
                            <img src=""assets/imgs/banner/banner-11.png""");
            BeginWriteAttribute("alt", " alt=\"", 9545, "\"", 9551, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            <div class=""banner-text"">
                                <span>Oganic</span>
                                <h4>
                                    Save 17% <br />
                                    on <span class=""text-brand"">Oganic</span><br />
                                    Juice
                                </h4>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </main>
");
            DefineSection("scripts", async() => {
                WriteLiteral(@" 
    <script>
        $(document).on(""click"", ""#btnLoadMore"", function () {
            let skip = $("".product-grid"").children().length;
            let prodCount = $(""#proCount"").val();
            $.ajax({
                url: ""/Product/LoadMore"",
                method: 'GET',
                data: {
                    skip: skip
                },
                success: function (res) {
                    $("".product-grid"").append(res);
                console.log(res)
                    if ($("".product-grid"").children().length >= prodCount) {
                        $(""#btnLoadMore"").remove();
                    }
                }
            })
        })
        $(document).on(""click"", "".category-filter"", function () {
            let id = $(this).attr(""data-id"");
            $.ajax({
                url: ""/Product/CategoryFilter"",
                method: 'GET',
                data: {
                    CategoryId: id
                },
                success: fun");
                WriteLiteral(@"ction (res) {
                    $("".product-grid"").html(res);
                    //if ($("".product-grid"").children().length >= prodCount) {
                    //    $(""#btnLoadMore"").remove();
                    //}
                }
            })
        })
    </script>


");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591