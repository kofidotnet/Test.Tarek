using System.ComponentModel.DataAnnotations;

namespace Test.Tarek.Models.Entities
{
    public sealed class UserModel
    {
        [Key] // this is important to specify
        public Guid ID { get; set; }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public string? EmailAddress { get; set; }
    }
}
