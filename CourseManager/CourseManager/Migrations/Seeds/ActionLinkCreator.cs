using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CourseManager.Migrations.Seeds
{
    public class ActionLinkCreator
    {
        private readonly CourseManager.Models.CourseManagerEntities _context;
        public ActionLinkCreator(CourseManager.Models.CourseManagerEntities context)
        {
            _context = context;
        }
        public void Seed()
        {
            var intialActionLink = new List<ActionLink>
           {
             new ActionLink
             {
                Name="主页",
                Controller="Home",
                Action="Index"
             }
           };
            foreach (var action in intialActionLink)
            {
                if (_context.ActionLink.Any(r => r.Name == action.Name))
                {
                    continue;
                }
            _context.ActionLink.Add(action);
        }
            _context.SaveChanges();
        }

    }
}
