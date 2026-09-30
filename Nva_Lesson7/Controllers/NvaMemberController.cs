using Microsoft.AspNetCore.Mvc;
using Nva_Lesson7.Models.DataModels;

namespace Nva_Lesson7.Controllers
{
    public class NvaMemberController : Controller
    {
        protected List<NvaMember> _members = new List<NvaMember>
        {
            new NvaMember
            {
                NvaMemberId = Guid.NewGuid().ToString(),
                NvaUserName = "vuonganh01",
                NvaPassword = "123456password",
                NvaFullName = "Nguyễn Vương Anh",
                NvaEmail = "vuonganh01@gmail.com"
            },
            new NvaMember
            {
                NvaMemberId = Guid.NewGuid().ToString(),
                NvaUserName = "hoangnam",
                NvaPassword = "123456password",
                NvaFullName = "Trần Hoàng Nam",
                NvaEmail = "hoangnam@gmail.com"
            },
            new NvaMember
            {
                NvaMemberId = Guid.NewGuid().ToString(),
                NvaUserName = "phuongthao",
                NvaPassword = "123456password",
                NvaFullName = "Lê Phương Thảo",
                NvaEmail = "phuongthao@gmail.com"
            },
            new NvaMember
            {
                NvaMemberId = Guid.NewGuid().ToString(),
                NvaUserName = "minhduc",
                NvaPassword = "123456password",
                NvaFullName = "Phạm Minh Đức",
                NvaEmail = "minhduc@gmail.com"
            },
            new NvaMember
            {
                NvaMemberId = Guid.NewGuid().ToString(),
                NvaUserName = "khanhlinh",
                NvaPassword = "123456password",
                NvaFullName = "Vũ Khánh Linh",
                NvaEmail = "khanhlinh@gmail.com"
            }
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetMember()
        {
            var member = new NvaMember
            {
                NvaMemberId = Guid.NewGuid().ToString(),
                NvaUserName = "vươnganh",
                NvaPassword = "password123",
                NvaFullName = "Nguyễn Vương Anh",
                NvaEmail = "nguyenvuonganh@gmail.com"
            };

            ViewBag.Member = member;
            return View();
        }

        public IActionResult GetMembers()
        {
            ViewBag.Members = _members; // Đã sửa từ ViewBag.Member -> ViewBag.Members
            return View();
        }
    }
}