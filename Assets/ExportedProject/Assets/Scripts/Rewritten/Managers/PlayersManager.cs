using System.Collections.Generic;
using Magicite.Player;
using Magicite.Utils;
using UnityEngine;

namespace Magicite.Interfaces
{
    public class PlayersManager : Singleton<PlayersManager>
    {
        [SerializeField] private PlayerActor _playerActorPrefab;

        public PlayerReplicator CurrentPlayerReplicator { get; private set; }

        private readonly List<PlayerReplicator> activePlayers = new();
        private readonly List<PlayerActor> actors = new();

        public void RegisterReplicator(PlayerReplicator replicator)
        {
            var replicatorExists = activePlayers.Find(r => r.PlayerId.Value == replicator.PlayerId.Value);
            if (replicatorExists)
            {
                Debug.LogWarning("Something weird happened here, the same player registered a second time.");
                return;
            }

            activePlayers.Add(replicator);
            if (replicator.IsOwner)
            {
                CurrentPlayerReplicator = replicator;
            }

            PlayerActor replicatorActor = actors.Find(a => a.PlayerId == replicator.PlayerId.Value);
            if (replicatorActor is not null)
            {
                // Found pre-existing actor for given player Id, reconnecting
                replicatorActor.Connect(replicator);
                return;
            }
            else
            {
                var newActorGO = Instantiate(_playerActorPrefab.gameObject, Vector3.zero, Quaternion.identity);
                var newActor = newActorGO.GetComponent<PlayerActor>();
                actors.Add(newActor);
                newActor.Connect(replicator);
            }
        }

        public void UnregisterReplicator(PlayerReplicator replicator)
        {
            PlayerActor replicatorActor = actors.Find(a => a.PlayerId == replicator.PlayerId.Value);
            if (replicatorActor is not null)
            {
                replicatorActor.Disconnect();
            }
            else
            {
                Debug.LogWarning("This is weird and shouldn't happen, the replicator is disconnecting but didn't have an actor.");
            }
            activePlayers.Remove(replicator);
        }
    }
}
