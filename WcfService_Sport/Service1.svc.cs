using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService_Sport
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "Service1" sowohl im Code als auch in der SVC- und der Konfigurationsdatei ändern.
    // HINWEIS: Wählen Sie zum Starten des WCF-Testclients zum Testen dieses Diensts Service1.svc oder Service1.svc.cs im Projektmappen-Explorer aus, und starten Sie das Debuggen.
    public class Service1 : IService1
    {
        public Events[] GetAllEvents()
        {

            using (Model1Container context = new Model1Container())
            {
                context.Configuration.LazyLoadingEnabled = false;
                context.Configuration.ProxyCreationEnabled = false;

                var q = from ev in context.Events.Include("Results")
                        select ev;
                return q.ToArray<Events>();

            }
        }

        public Result[] GetResults(Events events)
        {
            using (Model1Container context = new Model1Container())
            {
                context.Configuration.LazyLoadingEnabled = false;
                context.Configuration.ProxyCreationEnabled = false;

                var q = from c in context.Results.Include("Events")
                        where c.Events == events   
                        orderby c.Points descending                                       
                        select c;

                return q.ToArray<Result>();

            }
        }

        public void InsertEvents(Events eventss)
        {
            using (Model1Container context = new Model1Container())
            {
                context.Configuration.LazyLoadingEnabled = false;
                context.Configuration.ProxyCreationEnabled = false;

                context.Event_Create(eventss.Sport, eventss.Date, eventss.Competition);
                context.SaveChanges();
            }
        }
    }
}
