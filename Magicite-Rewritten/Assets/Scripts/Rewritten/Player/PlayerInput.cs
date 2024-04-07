using Magicite.Input;
using Magicite.Utils;
using UnityEngine;

namespace Magicite.Player
{
    public class PlayerInput : Singleton<PlayerInput>
    {
        [SerializeField] private float _movementForce = 5;

        private PlayerReplicator replicator;
        private Rigidbody rb;

        private bool disabled = true;

        void FixedUpdate()
        {
            if (disabled)
                return;

            // TODO:  Implement movement
            var movementInput = GameInput.Instance.GetMovementVectorNormalized();
            rb.velocity = new Vector3(movementInput.x * _movementForce, 0f, movementInput.y * _movementForce);
        }

        public void RegisterReplicator(PlayerReplicator replicator)
        {
            this.replicator = replicator;
            rb = replicator.GetComponent<Rigidbody>();
            disabled = false;
        }

        public void UnregisterReplicator()
        {
            rb = null;
            replicator = null;
            disabled = true;
        }
    }
}
