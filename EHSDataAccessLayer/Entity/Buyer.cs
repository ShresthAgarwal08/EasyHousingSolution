﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EHSDataAccessLayer.Entity
{
    public class Buyer
    {
        [Key]
        public int BuyerId { get; set; }
        [Required]
        [StringLength(30)]
        public string UserName { get; set; }

        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }

        [StringLength(25)]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(10)]
        public string PhoneNo { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailId { get; set; }

        // Navigation Properties
        public Cart Cart { get; set; }
    }
}