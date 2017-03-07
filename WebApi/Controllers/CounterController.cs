using System.Collections.Generic;
using System.Web.Http;
using BankingAssociation.Interfaces;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using System;
using Microsoft.ServiceFabric.Services.Client;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ServiceRequestActionFilter]
    public class CounterController : ApiController
    {
        // GET api/counter
        public async Task<long> Get()
        {
            IPaymentProcessor counter = ServiceProxy.Create<IPaymentProcessor>(new Uri("fabric:/BankingAssociation.Payment/PaymentProcessor"), new ServicePartitionKey(0));

            long count = await counter.Get();

            return count;
        }
    }
}
