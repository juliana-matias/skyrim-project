using System.ComponentModel.DataAnnotations.Schema;

namespace skyrim_project.Models
{
    public class User
    {
        public int Id { get; set; }        
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = new byte[0];
        public byte[] PasswordSalt { get; set; } = new byte[0];

        //adding properties to the models to create the relationship between tables: in this case User and Character
        //a user can have a list of characters, but the character belongs to one user
        public List<Character>? Characters { get; set; }
    }
}
