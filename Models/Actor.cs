using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180201028_yagmurkaya_cproject.Models
{
    public class Actor
    {
        [PrimaryKey, AutoIncrement]
        public int ActorID { get; set; }
        public string ActorName { get; set; }
        public string ActorSurName { get; set; }
        public string ActorGender { get; set; }

    }
}

