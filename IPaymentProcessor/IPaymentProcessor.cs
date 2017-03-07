using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Remoting;

namespace BankingAssociation.Interfaces
{
    using System.ServiceModel;
    using System.Threading.Tasks;

    // Define a service contract.
    [ServiceContract]
    public interface IPaymentProcessor : IService
    {
        Task<long> Get();
    }
}
