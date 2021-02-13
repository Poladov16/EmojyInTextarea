using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EmojiInTextarea.Models.ViewModels.Notifications;
using Microsoft.AspNetCore.Mvc;

namespace EmojiInTextarea.Controllers
{
    public class NotificationsController : Controller
    {
        [HttpGet]
        public IActionResult getNotification()
        {
            return View();
        }
        [HttpPost]
        public IActionResult getNotification(NotificationsViewModel viewModel)
        {
            return View();
        }
    }
}