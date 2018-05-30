using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WFC_Service_Bec
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAgregar" in both code and config file together.
    [ServiceContract]
    public interface IAgregar
    {
        [OperationContract]
        void DoWork();
    }
}
