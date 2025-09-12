using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiLibrary.Controller
{
    public class Controller
    {
        private string URL_BASE = "http://149.130.164.32/library/public/api/";

        public Controller()
        {
            
        }

        public string getUrlBase()
        {
            return URL_BASE;
        }
    }
}
