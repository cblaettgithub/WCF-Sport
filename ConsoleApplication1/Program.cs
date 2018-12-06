using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService_Sport;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            Events[] myEvents = client.GetAllEvents();
            Events myev = new Events();
            Result[] myResults = client.GetResults(myev);

            foreach(Events ev in myEvents)
            {
                Console.WriteLine("{0}, {1}, {2}", ev.Competition, ev.Sport, ev.Date);
            }

            foreach (Result res in myResults)
            {
                Console.WriteLine("{0}, {1}", res.Competitor, res.Points);
            }


        }
    }
}
