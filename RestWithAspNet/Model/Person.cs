using RestWithAspNet.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithAspNet.Model
{
    [Table("persons")]
    public class Person : BaseEntity
    {
        //public long? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
