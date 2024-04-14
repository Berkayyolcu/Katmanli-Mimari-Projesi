using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardOverviewPartial:ViewComponent
    {
        AgricultureContext context = new AgricultureContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.teamcount = context.Teams.Count();
            ViewBag.servicecount = context.Services.Count();
            ViewBag.messagecount = context.Contacts.Count();

            ViewBag.announcementtrue = context.Announcements.Where(x => x.Status == true).Count();
            ViewBag.announcementfalse = context.Announcements.Where(x => x.Status == false).Count();
            ViewBag.duty = context.Teams.Where(x => x.Title == "FIELD WORKER").Select(y => y.PersonName).FirstOrDefault();
            return View();
        }
    }
}
