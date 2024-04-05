using Magicite.Input;
using Magicite.Utils;
using UnityEngine;

namespace Magicite.Player
{
    public class PlayerInput : Singleton<PlayerInput>
    {
        [SerializeField] private float _movementForce = 5;

        private Rigidbody rb;

        void FixedUpdate()
        {
            // TODO:  Implement movement
            // var movementInput = GameInput.Instance.GetMovementVectorNormalized();
            // rb.velocity = new Vector3(movementInput.x * _movementForce, 0f, movementInput.y * _movementForce);
        }
    }
}
