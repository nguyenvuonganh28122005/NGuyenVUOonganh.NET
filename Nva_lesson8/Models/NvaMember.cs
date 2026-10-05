using System.ComponentModel;

namespace Nva_lesson8.Models
{
    public class NvaMember
    {
        public string NvaMemberId { get; set; }
        public string NvaUserName { get; set; }
        public string NvaPassword { get; set; }

        [DisplayName("Họ và tên")]
        public string NvaFullName { get; set; }
        public string NvaEmail { get; set; }
    }
}