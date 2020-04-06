using System;
using RestWithAspNet.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestWithAspNet.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {
        //Removido pois será o Id da BaseEntity
        //[Key]
        //[Column("id")]
        //public int Id { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Author")]
        public string Author { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }

        [Column("LaunchDate")]
        public DateTime LaunchDate { get; set; }
    }
}