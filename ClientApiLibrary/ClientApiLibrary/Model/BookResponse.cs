using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiLibrary.Model
{
    public class BookResponse
    {
        public string Message  { get; set; }
        public Book Book { get; set; }
    }
}
