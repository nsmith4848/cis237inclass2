using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Hanoi
    {

        public void MoveDisk(int n, char source, char auxilary, char destination)
        {          
            //Base case to exit recursive loop.
            if(n==1)
            {
                //Since we only have to move one disk.  (n = 1), we don't want to make another recursive call.  We just want to output the move that we are performing
                Console.WriteLine("Move disk from tower {0} to tower {1}", source, destination);                
            }
            else
            {
                MoveDisk(n - 1, source, destination, auxilary);

                MoveDisk(1, source, auxilary, destination);

                MoveDisk(n - 1, auxilary, source, destination);
            }
        }
    }
}
