using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProje.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment c)
        {
            c.Date =Convert.ToDateTime(DateTime.Now.ToShortDateString());
            c.State = true;
            c.DestinationID = 1;
            commentManager.TAdd(c);
            return RedirectToAction("Index","Destination");
        }
    }
}
