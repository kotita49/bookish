
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bookish.Data;
using Bookish.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bookish.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        { 
            var context = new BookContext();

            var allMembers = context.Members.ToList(); //this is a List of members
            var displayedMembers = new ListOfMembers { MemberList = allMembers };
            return View(displayedMembers);
        //     using (var context = new BookContext())
        //     {
                
        //         context.Members.Add(member2);
        //         context.SaveChanges();
           // }
           return View();
        }

    public IActionResult AddMemberForm()
        {
            return View();
        }

        [HttpPost]
    public IActionResult AddMemberForm(Member member)
        {
            using (var context = new BookContext())
            {
                var newMember = new Member()
                    {
                        Name = member.Name,
                        Address = member.Address,
                        
                    };
                context.Members.Add(newMember);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}