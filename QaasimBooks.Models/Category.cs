using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QaasimBooks.Models
{
    public class Category
    {
        [Key]
        /*public int Id { get; set; } i made the casing mistake*/ 
        public int id { get; set; }

        [Display(Name = "Category Name")]
        [Required]
        [MaxLength(50)]
        public string Name{ get; set;}
    }
}
