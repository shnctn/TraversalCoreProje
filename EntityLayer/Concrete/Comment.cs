using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommemtID { get; set; }
        public string Name { get; set; }
        public string lastName { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool State { get; set; }
        public int DestinationID { get; set; }
        public Destination destination { get; set; }

    }
}
