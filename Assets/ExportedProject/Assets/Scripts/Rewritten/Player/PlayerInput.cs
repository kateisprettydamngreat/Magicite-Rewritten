using Magicite.Input;
using Magicite.Utils;
using UnityEngine;

namespace Magicite.Player
{
    public class PlayerInput : Singleton<PlayerInput>
    {
        [SerializeField] private float _movementForce = 5;

        public PlayerActor PlayerActor { get; set; }
        public PlayerNetwork PlayerNetwork { get; set; }

        protected override void Awake()
        {
            base.Awake();
            // if (NetworkManager.Singleton.connect)
            // {
            //
            // }
        }

        void FixedUpdate()
        {
            var movementInput = GameInput.Instance.GetMovementVectorNormalized();
            // rb.velocity = new Vector3(movementInput.x * _movementForce, 0f, movementInput.y * _movementForce);
        }
    }
}
