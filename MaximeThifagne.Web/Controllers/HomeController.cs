using MaximeThifagne.DataAccess.Command.Interface;
using MaximeThifagne.DTO;
using MaximeThifagne.Models;
using System.Linq;
using System.Web.Mvc;

namespace MaximeThifagne.Controllers
{
    public class HomeController : Controller
    {
        private IContactCommand ContactCommand;
        public HomeController(IContactCommand contactCommand)
        {
            ContactCommand = contactCommand;
        }

        public HomeController()
        {

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult LegalMention()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SendMessage(ContactViewModel message)
        {
            if (!ModelState.IsValid)
                return Json(new { success = false, issue = message, errors = ModelState.Values.Where(i => i.Errors.Count > 0) });

            bool result = ContactCommand.SendMessage(new ContactDto
            {
                UserEmail = message.UserEmail,
                UserMessage = message.UserMessage,
                UserPhoneNumber = message.UserPhoneNumber,
                UserName = message.UserName,
                UserWebSite = message.UserWebSite
            });

            return Json(new { success = result });
        }
    }
}