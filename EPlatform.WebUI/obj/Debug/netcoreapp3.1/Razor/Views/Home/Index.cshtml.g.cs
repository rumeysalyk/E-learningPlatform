#pragma checksum "C:\Users\rumeysa\source\repos\EPlatform\EPlatform.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa8b0f486e980f623e1c55b1003ccabb492dfa2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\rumeysa\source\repos\EPlatform\EPlatform.WebUI\Views\_ViewImports.cshtml"
using EPlatform.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rumeysa\source\repos\EPlatform\EPlatform.WebUI\Views\_ViewImports.cshtml"
using EPlatform.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rumeysa\source\repos\EPlatform\EPlatform.WebUI\Views\_ViewImports.cshtml"
using EPlatform.WebUI.Models.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rumeysa\source\repos\EPlatform\EPlatform.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa8b0f486e980f623e1c55b1003ccabb492dfa2f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d951876840cd9102101b3a798507816597af7f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cta"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\rumeysa\source\repos\EPlatform\EPlatform.WebUI\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa8b0f486e980f623e1c55b1003ccabb492dfa2f5612", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <link rel=\"stylesheet\" href=\"./css/style.css\">\r\n    <title>MOON</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa8b0f486e980f623e1c55b1003ccabb492dfa2f6777", async() => {
                WriteLiteral(@"
    <!-- Header -->
    <section id=""header"">
        <div class=""header container"">
            <div class=""nav-bar"">
                <div class=""brand"">
                    <a href=""#hero""><h1><span>MOON</span></h1></a>
                </div>
                <div class=""nav-list"">
                    <div class=""hamburger""><div class=""bar""></div></div>
                    <ul>
                        <li><a href=""#hero"" data-after=""Home"">Home</a></li>
                        <li><a href=""#services"" data-after=""Service"">Lessons</a></li>
                        <li><a href=""#about"" data-after=""About"">About</a></li>
                        <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa8b0f486e980f623e1c55b1003ccabb492dfa2f7726", async() => {
                    WriteLiteral("Login");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
    </section>
    <!-- End Header -->
    <!-- Hero Section  -->
    <section id=""hero"">
        <div class=""hero container"">
            <div>
                <h1>MAKE <span></span></h1>
                <h1>YOUR DREAMS <span></span></h1>
                <h1>COME TRUE <span></span></h1>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa8b0f486e980f623e1c55b1003ccabb492dfa2f9567", async() => {
                    WriteLiteral("Join Us");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
        </div>
    </section>
    <!-- End Hero Section  -->
    <!-- Service Section -->
    <section id=""services"">
        <div class=""services container"">
            <div class=""service-top"">
                <h1 class=""section-title"">Lessons</h1>
            </div>
            <div class=""service-bottom"">
                <div class=""service-item"">
                    <div class=""icon""><img src=""https://img.icons8.com/bubbles/100/000000/services.png"" /></div>
                    <h2>Mathematics</h2>

                </div>
                <div class=""service-item"">
                    <div class=""icon""><img src=""https://img.icons8.com/bubbles/100/000000/services.png"" /></div>
                    <h2>Physics</h2>
                </div>
                <div class=""service-item"">
                    <div class=""icon""><img src=""https://img.icons8.com/bubbles/100/000000/services.png"" /></div>
                    <h2>Literature</h2>
                </div>
           ");
                WriteLiteral(@"     <div class=""service-item"">
                    <div class=""icon""><img src=""https://img.icons8.com/bubbles/100/000000/services.png"" /></div>
                    <h2>Geographics</h2>
                </div>
                <div class=""service-item"">
                    <div class=""icon""><img src=""https://img.icons8.com/bubbles/100/000000/services.png"" /></div>
                    <h2>History</h2>
                </div>
                <div class=""service-item"">
                    <div class=""icon""><img src=""https://img.icons8.com/bubbles/100/000000/services.png"" /></div>
                    <h2>Chemistry</h2>
                </div>
                <div class=""service-item"">
                    <div class=""icon""><img src=""https://img.icons8.com/bubbles/100/000000/services.png"" /></div>
                    <h2>Biology</h2>
                </div>
                <div class=""service-item"">
                    <div class=""icon""><img src=""https://img.icons8.com/bubbles/100/000000/services.png"" /");
                WriteLiteral(@"></div>
                    <h2>Geometry</h2>
                </div>



            </div>
        </div>
    </section>
    <!-- End Service Section -->
    <!-- Projects Section -->
    <section id=""projects"">
        <div class=""projects container"">
            <div class=""projects-header"">
                <h1 class=""section-title"">Recent <span>Projects</span></h1>
            </div>
            <div class=""all-projects"">
                <div class=""project-item"">
                    <div class=""project-info"">
                        <h1>Esma Yıldırım</h1>
                        <h2>Ankara Atatürk High School</h2>
                        <p>Moon is a very intuitive tool. We used it to provide eLearning training.Moon is a global online learning platform that offers massive open online courses.It is easy to learn how to use the tool and its features"".</p>
                    </div>
                    <div class=""project-img"">
                        <img src=""./img/studentComments/e");
                WriteLiteral(@"sma.png"" alt=""img"">
                    </div>
                </div>
                <div class=""project-item"">
                    <div class=""project-info"">
                        <h1>Berk Durmaz</h1>
                        <h2>Ankara Fen Lisesi</h2>
                        <p>""I really enjoyed working through the videos and questions. It's a great way to learn and can see how it can really help businesses. As a dyslexic person, this method of learning is a winner and the practice functionality before the test is a great idea"". </p>
                    </div>
                    <div class=""project-img"">
                        <img src=""./img/studentComments/berk.png"" alt=""img"">
                    </div>
                </div>
                <div class=""project-item"">
                    <div class=""project-info"">
                        <h1>Emir Turna</h1>
                        <h2>Maltepe High Shcool</h2>
                        <p>""A short response time is a critical metric for o");
                WriteLiteral(@"ur dealers, and traditional on-site training could not help us achieve our goals. However, with the Moon platform, we have managed to deliver training to our dealers and their sales reps- fast and with only few resources""</p>
                    </div>
                    <div class=""project-img"">
                        <img src=""./img/studentComments/emir.png"" alt=""img"">
                    </div>
                </div>
                <div class=""project-item"">
                    <div class=""project-info"">
                        <h1>Selin Aydın</h1>
                        <h2>Special Nilüfer High School</h2>
                        <p>""I tried the Moon video eLearning platform during the Christmas promotion. Due to the nature of my work I have tested many different eLearning platforms, and I must say that Moon has the upper hand in ease of use.The promotional eLearning was fun and engaging, and the fact that I was also lucky enough to win an iPad while having fun just shows that the people beh");
                WriteLiteral(@"ind are as great as the product"". </p>
                    </div>
                    <div class=""project-img"">
                        <img src=""./img//studentComments/selin.png"" alt=""img"">
                    </div>
                </div>

            </div>
        </div>
    </section>
    <!-- End Projects Section -->
    <!-- About Section -->
    <section id=""about"">
        <div class=""about container"">
            <div class=""col-left"">
                <div class=""about-img"">
                    <img src=""./img/aboutUs.png"" alt=""img"">
                </div>
            </div>
            <div class=""col-right"">
                <h1 class=""section-title"">About <span>Us</span></h1>
                
                <p>Our values guide how we design and build Moon.We’re transparent with our learners, our partners and each other about what we’re doing and why.We listen to and address the needs of our learners and partners, celebrating our successes and learning from our failures.We li");
                WriteLiteral(@"sten to and address the needs of our learners and partners, celebrating our successes and learning from our failures.We make online learning enjoyable for our learners and our partners alike, and have fun while we’re doing it.</p>
                
            </div>
        </div>
    </section>
    <!-- End About Section -->
    <!-- Contact Section -->
    <section id=""contact"">
        <div class=""contact container"">
            <div><h1 class=""section-title"">Contact<span> </span></h1></div>
            <div class=""contact-items"">
                <div class=""contact-item"">
                    <div class=""icon""><img src=""https://img.icons8.com/bubbles/100/000000/phone.png"" /></div>
                    <div class=""contact-info"">
                        <h1>Phone</h1>
                        <h2>+90 541 5258</h2>
                        
                    </div>
                </div>
                <div class=""contact-item"">
                    <div class=""icon""><img src=""https://img.i");
                WriteLiteral(@"cons8.com/bubbles/100/000000/new-post.png"" /></div>
                    <div class=""contact-info"">
                        <h1>Email</h1>
                        <h2>layikrumeysa@gmail.com</h2>
                        
                    </div>
                </div>
                <div class=""contact-item"">
                    <div class=""icon""><img src=""https://img.icons8.com/bubbles/100/000000/map-marker.png"" /></div>
                    <div class=""contact-info"">
                        <h1>Address</h1>
                        <h2>Ankara, Turkey</h2>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- End Contact Section -->
    <!-- Footer -->
    <section id=""footer"">
        <div class=""footer container"">
            <div class=""brand""><h1><span>MOON</span></h1></div>
            <h2>Online Education System </h2>
            <div class=""social-icon"">
                <div class=""social-item"">
                    <a href=""");
                WriteLiteral(@"#""><img src=""https://img.icons8.com/bubbles/100/000000/facebook-new.png"" /></a>
                </div>
                <div class=""social-item"">
                    <a href=""#""><img src=""https://img.icons8.com/bubbles/100/000000/instagram-new.png"" /></a>
                </div>
                <div class=""social-item"">
                    <a href=""#""><img src=""https://img.icons8.com/bubbles/100/000000/twitter.png"" /></a>
                </div>
                <div class=""social-item"">
                    <a href=""#""><img src=""https://img.icons8.com/bubbles/100/000000/behance.png"" /></a>
                </div>
            </div>
            <p>Copyright © 2020 Rumeysa. All rights reserved</p>
        </div>
    </section>
    <!-- End Footer -->
    <script src=""./js/app.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
