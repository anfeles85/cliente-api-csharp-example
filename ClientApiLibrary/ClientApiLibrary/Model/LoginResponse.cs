using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiLibrary.Model
{
    public  class LoginResponse
    {
        public User user { get; set; }
        public string token { get; set; }

    }
}
