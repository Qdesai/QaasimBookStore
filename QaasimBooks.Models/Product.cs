using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;



namespace QaasimBooks.Models

{
    public class Product
    {

        [Key]

        public int id { get; set; }

        [Required]
        public string Title { get; set; }


        public string Description { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]

        [Range(1, 10000)]

        public double ListPrice { get; set; }

        public string ImageUrl { get; set; }



        [Required]
        public int Categoryid { get; set; }     // foreign key reference


        [ForeignKey("Categoryid")]
        public Category Category { get; set; }


        [Required]
        public int CoverTypeid { get; set; }    // foreign key reference


        [ForeignKey("CoverTypeid")]             //This was CategoryId when i created the migration 
        public CoverType CoverType { get; set; }

    }
}