using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Runtime;
using Microsoft.ServiceFabric.Actors.Client;
using HelloWorld.Interfaces;

namespace HelloWorld
{
    [StatePersistence(StatePersistence.Persisted)]
    internal class HelloWorld : Actor, IHelloWorld
    {
        public HelloWorld(ActorService actorService, ActorId actorId)
            : base(actorService, actorId)
        {
        }

        public Task<string> GetHelloWorldAsync()
        {
            return Task.FromResult("Hello ,I am Ankit chandra");
        }

        public Task<string> GetHelloAsync()
        {
            return Task.FromResult("Hello ,I am Staing in Banglore");
        }

    }
}
