using System.ComponentModel.DataAnnotations;

namespace MaximeThifagne.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage ="Le nom est obligatoire")]
        [Display(Name ="Nom")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "L'adresse email est obligatoire")]
        [Display(Name ="Email")]
        public string UserEmail { get; set; }

        [Display(Name = "Site internet")]
        public string UserWebSite { get; set; }

        [Display(Name = "Téléphone")]
        public string UserPhoneNumber { get; set; }

        [Display(Name = "Message")]
        [Required(ErrorMessage ="Le message est obligatoire")]
        public string UserMessage { get; set; }
    }
}