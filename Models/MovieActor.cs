using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180201028_yagmurkaya_cproject.Models
{
    public class MovieActor
    {
        [PrimaryKey, AutoIncrement]
        public int MovieActorID { get; set; }
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public int ActorID { get; set; }
        public string ActorName { get; set; }
        public string ActorSurname { get; set; }

    }
}
