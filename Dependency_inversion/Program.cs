using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion
{
    interface IWorker
    {
         void work();
    }

    class Worker : IWorker
    {

    public void work()
        {

        }
    }

    class SuperWorker : IWorker
    {

    public void work()
        {

        }
     }
 
    class Manager
    {
    IWorker worker;

        public void setWorker(IWorker w)
        {
            worker = w;
        }

        public void manage()
        {
            worker.work();
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
