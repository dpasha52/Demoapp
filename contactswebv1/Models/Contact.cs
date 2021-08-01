using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactswebv1.Models
{
    public class Contact
    {
        [Key]
        public int  Id { get; set; }


        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required ")]
        [StringLength(ContactWebConstants.MAX_FIRST_NAME_LENGTH)]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required ")]
        [StringLength(ContactWebConstants.MAX_lAST_NAME_LENGTH)]
        public string LastName { get; set; }


        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage ="Inavlid Email Address")]
        [StringLength(ContactWebConstants.MAX_EMAIL_LENGTH)]
        public string Email { get; set; }


        [Display(Name = "Home/Office Phone")]
        [Required(ErrorMessage = "Phone is required")]
        [StringLength(ContactWebConstants.MAX_PHONE_LENGTH)]
        [Phone(ErrorMessage ="Invalid Phone Number")]
        public String PhonePrimary { get; set; }

   
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [StringLength(ContactWebConstants.MAX_PHONE_LENGTH)]
        public string PhoneSecondary { get; set; }
        
        [DataType (DataType.Date)]
        public DateTime Birthday { get; set; }


        [Display(Name = "Street Address Line1")]
        [StringLength(ContactWebConstants.MAX_STREET_ADDRESS_LENGTH)]
        public string StreetAddress1 { get; set; }

        [StringLength(ContactWebConstants.MAX_STREET_ADDRESS_LENGTH)]

        [Display(Name = "Street Address Line2")]

        public string StreetAddress2 { get; set; }
        [Display(Name = "Stat")]


        [Required (ErrorMessage ="State is required")]
        public int StateId { get; set; }
        
        [Required (ErrorMessage = "city is required")]
        [StringLength(ContactWebConstants.MAX_CITY_LENGTH)]
        public string City { get; set; }
        
        public virtual State State { get; set; }
        
        [Required]
        [Display(Name ="ZIP_CODE")]
        [RegularExpression("(^\\d{5}(-\\d{4})?$)|(^[ABCEGHJKLMNPRSTVXY]{1}\\d{1}[A-Z]{1} *\\d{1}[A-Z]{1}\\d{1}$)", ErrorMessage = "Zip code is invalid.")] // US or Canada
        [StringLength(ContactWebConstants.MAX_ZIP_CODE_LENGTH,MinimumLength = ContactWebConstants.MIN_ZIP_CODE_LENGTH)]
        public string Zip { get; set; }
        
        [Required]
        public string UserId { get; set; }


        public virtual ApplicationUser User { get; set; }
        [Display (Name = "Full Name")]
        public string FriendlyName => $"{FirstName} {LastName}";

        [Display(Name ="Full Address")]
        public string FriendlyAdderss => string.IsNullOrWhiteSpace(StreetAddress1)?  $"{City}, {State.Abbreviation}, {Zip}":
                                           string.IsNullOrWhiteSpace(StreetAddress2)
                                         ? $"{StreetAddress1}, {City}, {State.Abbreviation}, {Zip}"
                                         : $"{StreetAddress1} - {StreetAddress2} , {City}, {State.Abbreviation}, {Zip}";

    }
}
