using System;
using System.ComponentModel.DataAnnotations;

namespace PhoneListAtanga.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "please enter a name.")]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(12)]
        [Required(ErrorMessage = "Please enter a phone number.")]
        public string Phone { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Please enter an Adress.")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Please enter a note.")]
        public string NoteId { get; set; }
        public Note Note { get; set; }

        public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + Phone?.ToString();
    }
}
