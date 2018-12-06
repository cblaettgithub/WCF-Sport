using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService_Sport
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "IService1" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Events[]  GetAllEvents();

       [OperationContract]
       Result[] GetResults(Events events);

        [OperationContract]
        void InsertEvents(Events events);

        // TODO: Hier Dienstvorgänge hinzufügen
    }


    // Verwenden Sie einen Datenvertrag, wie im folgenden Beispiel dargestellt, um Dienstvorgängen zusammengesetzte Typen hinzuzufügen.
   
    
}
