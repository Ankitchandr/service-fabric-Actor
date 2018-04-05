using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Remoting.FabricTransport;
using Microsoft.ServiceFabric.Actors.Runtime;
using Microsoft.ServiceFabric.Services.Remoting;

[assembly: FabricTransportActorRemotingProvider(RemotingListener = RemotingListener.V2Listener, RemotingClient = RemotingClient.V2Client)]
namespace HelloActor.Interfaces
{
    /// <summary>
    /// This interface defines the methods exposed by an actor.
    /// Clients use this interface to interact with the actor that implements it.
    /// </summary>
    /// 
    public interface IHelloActor : IActor
    {
        Task<string> GetHelloActorAsync();
        Task<int> GetCountAsync(CancellationToken cancellationToken);
        Task SetCountAsync(int count, CancellationToken cancellationToken);
    }
    [StatePersistence(StatePersistence.Persisted)]
    internal class HelloActor : Actor, IHelloActor
    {
        public HelloActor(ActorService actorService, ActorId actorId)
            : base(actorService, actorId)
        {
        }

        public Task<int> GetCountAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetHelloActorAsync()
        {
            return Task.FromResult("Hello from my reliable actor!");
        }

        public Task SetCountAsync(int count, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
