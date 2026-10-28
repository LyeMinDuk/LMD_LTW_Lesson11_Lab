using System.ComponentModel.DataAnnotations;

namespace Lab03.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Tên bắt buộc phải nhập")]
        [Display(Name ="Họ và tên")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Email bắt buộc phải nhập")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string? Email { get; set; }

        [StringLength(100, MinimumLength =8)]
        [Required]
        [Display(Name ="Mật khẩu")]
        public string? Password { get; set; }

        [Required]
        [Display(Name ="Khoa")]
        public Branch? Branch { get; set; }

        [Required]
        [Display(Name ="Giới tính")]
        public Gender? Gender { get; set; }

        [Display(Name ="Chính quy")]
        public bool IsRegular { get; set; }

        [DataType(DataType.MultilineText)]
        [Required]
        [Display(Name ="Địa chỉ")]
        public string? Address { get; set; }

        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [DataType(DataType.Date)]
        [Required]
        [Display(Name ="Ngày sinh")]
        public DateTime DateOfBirth { get; set; }
    }
}
