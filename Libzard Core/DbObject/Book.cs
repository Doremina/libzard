using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libzard_Core.DbObject
{
    public class Book
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime CreationDate { get; set; }
        public Publisher Publisher { get; set; }

    }


}
