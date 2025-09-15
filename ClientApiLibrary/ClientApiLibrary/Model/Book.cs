﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiLibrary.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Isbn{ get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Category Category{ get; set; }
        public Editorial Editorial{ get; set; } 
    }
}
