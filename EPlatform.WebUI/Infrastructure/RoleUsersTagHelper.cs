using EPlatform.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPlatform.WebUI.Infrastructure
{
    [HtmlTargetElement("td", Attributes = "identity-role")]
    public class RoleUsersTagHelper : TagHelper
    {

        private UserManager<User> userManager;
        private RoleManager<User> roleManager;


        [HtmlAttributeName("identity-role")]
        public string Role { get; set; }
        public RoleUsersTagHelper(UserManager<User> userManager, RoleManager<User> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }


        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            List<string> names = new List<string>();

            var role = await roleManager.FindByIdAsync(Role);

            if (role != null)
            {
                foreach (var user in userManager.Users)
                {
                    if (user != null && await userManager.IsInRoleAsync(user, role.UserName))
                    {
                        names.Add(user.UserName);
                    }
                }
            }

            output.Content.SetContent(names.Count == 0 ? "No Users" : string.Join(", ", names));
        }

    }

}
