using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussinesLayer
{
    public class Genre
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("Player")]
        public List<Player> Player_ID { get; set; }

        private Genre()
        {

        }

        public Genre(string name)
        {
            this.Name = name;
            this.Player_ID = new List<Player>();
        }
    }
}
