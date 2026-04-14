using System.ComponentModel.DataAnnotations;

namespace teachersWorkload.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите название")]
        [StringLength(15, ErrorMessage = "Название не более 15 символов")]
        public string Name { get; set; }

        [Range(6, 72, ErrorMessage = "Кол-во часов: от 6 до 72")]
        public int Hours { get; set; }

        [RegularExpression(@"^[1-4][0-9]$", ErrorMessage = "двузначное число: первая цифра от 1 до 4")]
        // Алана Казбековна, я это всё знаю, честно причестно <3
        public string GroupNumber { get; set; }

        [Range(1, 8, ErrorMessage = "Семестр: от 1 до 8")] 
        public int Semester { get; set; }
        public bool IsOnline { get; set; }
    }
}
