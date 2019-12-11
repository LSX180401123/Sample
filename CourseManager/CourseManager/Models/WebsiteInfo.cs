using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public class WebsiteInfo
    {
        public class ActionLink
        {
            public string Name { get; set; }
            public string Controller { get; set; }
            public string Action { get; set; }
        }
        public const string SiteName = "课程管理系统";
        private string p1;
        private string p2;

        public List<ActionLink> ActionLinks { get; set; }

        public WebsiteInfo()
        {
            ActionLinks = new List<ActionLink>
        {
           new ActionLink{Name="主页",Controller="Home",Action="Index"},
            new ActionLink{Name="关于",Controller="Home",Action="About"},
             new ActionLink{Name="联系方式",Controller="Home",Action="Contact"},
        };
        }

        public WebsiteInfo(string p1, string p2)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
        }
    }
}