using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiLibrary.Model
{
    public class Book
    {
        public long id { get; set; }
        public string isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public Category category { get; set; }
        public Editorial editorial { get; set; }

        public int category_id { get; set; }
        public int editorial_id { get; set; }

        public string CategoryName => category?.Name; 
        public string EditorialName => editorial?.name; 
    }
}
