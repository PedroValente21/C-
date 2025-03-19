using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Contabil
{
    public class Juros
    {
        public Juros() 
        {
            Valor = 10;
        }
        public int Valor {  get; set; }
    }
}
