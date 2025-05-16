using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jurassic_Console_Park
{
    internal class Park
    {
        

    Random rnd = new Random(); 
        public Park()
        {
            rnd = new Random();
        }

        public int GenerateFootage()
        {
            int FootageStore = rnd.Next(1000, 1501);
           return FootageStore;
     
        }
        



    }


}
