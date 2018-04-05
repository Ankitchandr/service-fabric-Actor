using System;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Client;
using HelloActor.Interfaces;

namespace ActorClient
{
    class Program
    {
        static void Main(string[] args)
        {

           
                IHelloActor actor = ActorProxy.Create<IHelloActor>(ActorId.CreateRandom(), new Uri("fabric:/HelloWorldExample/HelloActorService	"));
            Task<string> retval = actor.GetHelloActorAsync();
                Console.Write(retval.Result);
                Console.ReadLine();
           

          
        }
    }
}