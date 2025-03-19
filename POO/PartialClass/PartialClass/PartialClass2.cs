using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class PartialClass1
    {
        public void Tarefa()
        {
            Console.WriteLine("Eu estou fazendo {0}", this.tarefa);
        }
    }
}
