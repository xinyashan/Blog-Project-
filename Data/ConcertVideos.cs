using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace btsprojectweb.Data
{
    public class ConcertVideos
    {
        [Key]

        public int ConcertVideosID { get; set; }
        public string VideoName { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string information { get; set; }

        public string videos { get; set; }


    }
}
