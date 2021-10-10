using System;
using System.ComponentModel.DataAnnotations;

namespace NationalCenterforPalmsandDates.Models
{
    public class FarmerSetting
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string MidName { get; set; }
        [Required, MaxLength(100)]
        public string GrandFatherName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        public string FullName { get; set; }

        [Required]
        public DateTime RegisterationDate { get; set; }

        [Required]
        public string NationalIdentityCode { get; set; }

        [Required]
        public DateTime ExpDate { get; set; }

        [Required]
        public string PlaceofNationalIdentity { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string MailAddress { get; set; }

        [Required]
        public string BankName { get; set; }

        [Required]
        public string IBANumber { get; set; }

        [Required]
        public bool IsCanceled { get; set; }
    }
}
