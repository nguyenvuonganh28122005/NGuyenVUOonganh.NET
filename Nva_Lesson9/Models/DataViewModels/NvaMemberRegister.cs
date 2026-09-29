using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nva_Lesson9.Models.DataViewModels
{
    public class NvaMemberRegister
    {
            public int NvaMemberId { get; set; }

            [DisplayName("Tên đăng nhập")]
            [Required(ErrorMessage = "Tên đăng nhập không để trống")]
            [StringLength(30, MinimumLength = 3, ErrorMessage = "Tên đăng nhập có độ dài trong khoảng 2 - 20 ký tự")]
            public string NvaUserName { get; set; }

            [DisplayName("Mật khẩu")]
            [Required(ErrorMessage = "Mật khẩu không được để trống")]
            [DataType(DataType.Password)]
            public string NvaPassword { get; set; }

            public string NvaEmail { get; set; }

            public string NvaPhoneNumber { get; set; }

            public string NvaFullName { get; set; }

            public DateTime NvaBirthday { get; set; }

    }
}
