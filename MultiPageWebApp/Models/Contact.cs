using System.ComponentModel.DataAnnotations;
using System;

namespace MultiPageWebApp.Models
{
    public class Contact
    {
        [Key]
        public int PhoneId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + PhoneNumber?.ToString();
    }
}
