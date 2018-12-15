using MPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPD_MPI
{
    class Program
    {
        static void Main(string[] args)
        {
            if(Communicator.world.Rank == 0)
            {
                Communicator.world.Send("Hello", 1, 0);
            }
            else if(Communicator.world.Rank == 1)
            {
                string msg = Communicator.world.Receive<String>(0, 0);
                Console.WriteLine(msg);
            }
        }
    }
}
