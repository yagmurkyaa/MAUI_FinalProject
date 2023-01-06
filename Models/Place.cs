using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180201028_yagmurkaya_cproject.Models
{
    public class Place
    {
        [PrimaryKey, AutoIncrement]
        public int PlaceID { get; set; }
        public string PlaceName { get; set; }

    }
}
