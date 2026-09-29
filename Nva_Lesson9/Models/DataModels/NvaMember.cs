namespace Nva_Lesson9.Models.DataModels
{
    public class NvaMember
    {
        public int NvaMemberId { get; set; }
        public string NvaUserName { get; set; }
        public string NvaPassword { get; set; }
        public string NvaEmail { get; set; }
        public string NvaPhoneNumber { get; set; }
        public string NvaFullName { get; set; }
        public DateTime NvaBirthday { get; set; }
    }
}
