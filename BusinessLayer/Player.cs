using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussinesLayer
{
    public class Player
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string First_name { get; set; }
       
        [Required]
        [StringLength(20)]
        public string Last_name { get; set; }

        [Required]
        [Range(10, 80)]
        public int Age { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        [StringLength(70)]
        public string Password { get; set; }

        [Required]
        [StringLength(20)]
        public string Email { get; set; }

        List<Player> Friend_ID { get; set; }

        [ForeignKey("Game")]
        List<Game> Game_ID { get; set; }

        private Player()
        {

        }

        public Player(string first_name, string last_name, int age, string username, string password, string email)
        {
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Age = age;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Friend_ID = new List<Player>();
            this.Game_ID = new List<Game>();
        }
    }
}