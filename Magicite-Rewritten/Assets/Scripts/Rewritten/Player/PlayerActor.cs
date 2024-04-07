using UnityEngine;

namespace Magicite.Player
{
    public class PlayerActor : MonoBehaviour
    {
        [field: SerializeField] public ulong PlayerId { get; private set; }

        private PlayerReplicator replicator;

        private void Update()
        {
            if (replicator is null)
                return;

            var currentPso = transform.position;
            var newPos = replicator.transform.position;

            // Calculate facing direction
            Vector3 crossProduct = Vector3.Cross(currentPso, newPos);
            if (crossProduct.z > 0.1)
            {
                transform.localScale = new Vector3(1, 1, 1);
            } else if (crossProduct.z < -0.1)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }

            transform.position = newPos;
        }

        public void Connect(PlayerReplicator replicator)
        {
            this.replicator = replicator;
            PlayerId = this.replicator.PlayerId.Value;

            // TODO:  Listen to replicator variable changes
        }

        public void Disconnect()
        {
            replicator = null;
            // TODO:  Stop listening to replicator variable changes
        }
    }
}
