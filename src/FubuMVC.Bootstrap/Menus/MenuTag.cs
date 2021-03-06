using System.Collections.Generic;
using FubuMVC.Navigation;
using HtmlTags;

namespace FubuMVC.Bootstrap.Menus
{
    public class MenuTag : HtmlTag
    {
        public MenuTag(IEnumerable<MenuItemToken> tokens) : base("ul")
        {
            AddClass("nav");
            tokens.Each(token => Append(new MenuItemTag(token)));
        }
    }
}