﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesWeb.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [StringLength(50)]
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Position { get; set; }


        [StringLength(100)]
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [NotMapped]
        public IFormFile? ProfilePicture { get; set; }
        public string? ProfilePictureUrl { get; set; } 

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn{ get; set; }

        public Guid? DeletedBy{ get; set; }

        public DateTime? DeletedOn{ get; set; }

        public  bool IsDeleted { get; set; }
    }
}
