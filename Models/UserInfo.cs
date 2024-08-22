using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
     public int Id { get; set; }

     [Required(ErrorMessage ="Lütfen Ad Soyad alanını boş bırakmayınız.")]
     public string? Name { get; set; } 

     [Required(ErrorMessage ="Lütfen Telefon alanını boş bırakmayınız.")]  
     public string? Phone { get; set; }

     [Required(ErrorMessage ="Hatalı Email girişi.")]
     [EmailAddress]
     public string? Email { get; set; }

     [Required(ErrorMessage ="Lütfen bir seçim yapınız.")]
     public bool? WillAttend { get; set; } //true-false-null
    }
}