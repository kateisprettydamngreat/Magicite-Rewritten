using System.Collections;
using System.Collections.Generic;
using Magicite.Interfaces;
using Unity.Netcode;
using UnityEngine;

namespace Magicite.Player
{
    public class PlayerReplicator : NetworkBehaviour
    {
        public readonly NetworkVariable<ulong> PlayerId = new();

        // Start is called before the first frame update
        private void Start()
        {
            PlayersManager.Instance.RegisterReplicator(this);
        }

        // Update is called once per frame
        public override void OnDestroy()
        {
            PlayersManager.Instance.UnregisterReplicator(this);
            base.OnDestroy();
        }
    }
}
