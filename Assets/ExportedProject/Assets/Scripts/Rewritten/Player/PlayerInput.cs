using System;
using Magicite.Input;
using Magicite.Interfaces;
using Magicite.Utils;
using UnityEngine;

namespace Magicite.Player
{
    public class PlayerInput : Singleton<PlayerInput>
    {
        [SerializeField] private float _movementForce = 5;

        private PlayerReplicator replicator;
        private Rigidbody rb;

        private void Start()
        {
            replicator = PlayersManager.Instance.CurrentPlayerReplicator;
            rb = replicator.GetComponent<Rigidbody>();
        }

        void FixedUpdate()
        {
            // TODO:  Implement movement
            var movementInput = GameInput.Instance.GetMovementVectorNormalized();
            rb.velocity = new Vector3(movementInput.x * _movementForce, 0f, movementInput.y * _movementForce);
        }
    }
}
