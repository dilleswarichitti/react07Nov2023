using System.ComponentModel.DataAnnotations;

namespace EventCalendarApp.Models
{
    public class User
    {
        [Key]
        public string Email { get; set; }//user's email this is unique for every user
        public string FirstName { get; set; }//firstname of the user
        public string LastName { get; set; }//lastname of the user
        public byte[] Password { get; set; }//encrypted password
        public string Role { get; set; }//role of the user
        public byte[] Key { get; set; }

    }
}
