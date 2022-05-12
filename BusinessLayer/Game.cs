using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussinesLayer
{
    public class Game
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("Player")]
        public List<Player> Player_ID { get; set; }

        [ForeignKey("Game")]
        public List<Genre> Genre_ID { get; set; }

        private Game()
        {

        }

        public Game(string name)
        {
            this.Name = name;
            this.Player_ID = new List<Player>();
            this.Genre_ID = new List<Genre>();
        }
    }
}
