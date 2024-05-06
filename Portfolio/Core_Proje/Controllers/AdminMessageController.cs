using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System;
using System.Linq;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult Inbox()
        {
            ViewBag.V1 = "Mesajlar";
            ViewBag.V2 = "Mesaj Listesi";
            ViewBag.V3 = "";
            ViewBag.V2URL = "/AdminMessage/Inbox/";

            string p;
            p = "palaomerfar16@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p).OrderByDescending(x => x.Date).ToList();
            return View(values);
        }

        public IActionResult Sendbox()
        {
            ViewBag.V1 = "Mesajlar";
            ViewBag.V2 = "Mesaj Listesi";
            ViewBag.V3 = "";
            ViewBag.V2URL = "/AdminMessage/Sendbox/";

            string p;
            p = "palaomerfar16@gmail.com";
            var values = writerMessageManager.GetListSenderMessage(p).OrderByDescending(x => x.Date).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult NewMessage()
        {
            ViewBag.V1 = "Yeni Mesaj Gönderme Formu";
            ViewBag.V2 = "Mesaj Listesi";
            ViewBag.V3 = "Yeni Mesaj Gönderme Formu";
            ViewBag.V2URL = "/AdminMessage/Inbox/";

            return View();
        }

        [HttpPost]
        public IActionResult NewMessage(WriterMessage writerMessage)
        {
            ViewBag.V1 = "Yeni Mesaj Gönderme Formu";
            ViewBag.V2 = "Mesaj Listesi";
            ViewBag.V3 = "Yeni Mesaj Gönderme Formu";
            ViewBag.V2URL = "/AdminMessage/Inbox/";

            AdminMessageValidator validations = new AdminMessageValidator();
            ValidationResult result = validations.Validate(writerMessage);

            Context context = new Context();
            var usernamesurname = context.Users.Where(x => x.Email == writerMessage.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();

            writerMessage.ReceiverName = usernamesurname;
            writerMessage.Sender = "palaomerfar16@gmail.com";
            writerMessage.SenderName = "Ömer Faruk Pala";
            writerMessage.Date = DateTime.Now;

            if (result.IsValid)
            {
                writerMessageManager.TAdd(writerMessage);
                return RedirectToAction("Sendbox");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteAdminMessage(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            writerMessageManager.TDelete(values);
            return RedirectToAction("Sendbox");
        }

        public IActionResult AdminMessageDetailI(int id)
        {
            ViewBag.V1 = "Mesaj Detayı";
            ViewBag.V2 = "Mesaj Listesi";
            ViewBag.V3 = "Mesaj Detayı";
            ViewBag.V2URL = "/AdminMessage/Inbox/";

            var values = writerMessageManager.TGetByID(id);
            return View(values);
        }

        public IActionResult AdminMessageDetailS(int id)
        {
            ViewBag.V1 = "Mesaj Detayı";
            ViewBag.V2 = "Mesaj Listesi";
            ViewBag.V3 = "Mesaj Detayı";
            ViewBag.V2URL = "/AdminMessage/Sendbox/";

            var values = writerMessageManager.TGetByID(id);
            return View(values);
        }
    }
}
