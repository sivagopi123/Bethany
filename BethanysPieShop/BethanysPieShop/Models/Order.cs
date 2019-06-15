using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BethanysPieShop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        public List<OrderDetail> OrderLines { get; set; }

        [Display(Name = "First Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }
        [Display(Name = "Address Line 1")]
        [StringLength(100)]
        [Required(ErrorMessage = "Please enter your delivery Address")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        [StringLength(100)]
        public string AddressLine2 { get; set; }
        [Display(Name = "Zip Code")]
        [StringLength(20)]
        public string ZipCode { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your city")]
        public string City { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your State")]
        public string State { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your Country")]
        public string Country { get; set; }
        [Display(Name = "Phone Number")]
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5})$",
            ErrorMessage = "The email address is not entered in the correct format")]
        public string Email { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [BindNever]
        public decimal OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlaced { get; set; }
    }
}
