using Microsoft.AspNetCore.Mvc;
using Nva_lesson8.Models;

namespace Nva_lesson8.Controllers
{
    public class NvaMemberController : Controller
    {
        // Danh sách lưu trữ dữ liệu tạm thời
        private static List<NvaMember> _members = new List<NvaMember>()
        {
            new NvaMember
            {
                NvaMemberId = "1",
                NvaUserName = "ChungTv",
                NvaPassword = "Password123!",
                NvaFullName = "Trịnh Văn Chung",
                NvaEmail = "chungtrinhj@gmail.com"
            },
            new NvaMember
            {
                NvaMemberId = "2",
                NvaUserName = "tranthib",
                NvaPassword = "SecurePass456*",
                NvaFullName = "Trần Thị B",
                NvaEmail = "tranthib@outlook.com"
            }
        };

        // 1. Trang danh sách thành viên (GET: NvaMember/Index)
        public IActionResult Index()
        {
            return View(_members);
        }

        // 2. Mở form thêm mới (GET: NvaMember/Create)
        public IActionResult Create()
        {
            return View();
        }

        // 2.1. Xử lý lưu thông tin thêm mới (POST: NvaMember/Create)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NvaMember member)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(member.NvaMemberId))
                {
                    member.NvaMemberId = Guid.NewGuid().ToString();
                }
                _members.Add(member);
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        // 3. Xem chi tiết thành viên (GET: NvaMember/Details/id)
        public IActionResult Details(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var member = _members.FirstOrDefault(m => m.NvaMemberId == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // 4. Mở form chỉnh sửa (GET: NvaMember/Edit/id)
        public IActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var member = _members.FirstOrDefault(m => m.NvaMemberId == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // 4.1. Xử lý cập nhật thông tin (POST: NvaMember/Edit/id)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, NvaMember member)
        {
            if (id != member.NvaMemberId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingMember = _members.FirstOrDefault(m => m.NvaMemberId == id);
                if (existingMember != null)
                {
                    existingMember.NvaUserName = member.NvaUserName;
                    existingMember.NvaPassword = member.NvaPassword;
                    existingMember.NvaFullName = member.NvaFullName;
                    existingMember.NvaEmail = member.NvaEmail;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        // 5. Xóa trực tiếp thành viên không qua trang xác nhận (GET: NvaMember/Delete/id)
        public IActionResult Delete(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                var member = _members.FirstOrDefault(m => m.NvaMemberId == id);
                if (member != null)
                {
                    _members.Remove(member);
                }
            }

            return RedirectToAction(nameof(Index));
        }
    }
}