using System;
using Magicite.Utils;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Magicite.Input
{
    public class GameInput: Singleton<GameInput>
    {

        public event EventHandler OnJumpAction;

        private MagiciteRewrittenInputActions playerInputActions;

        protected override void Awake()
        {
            base.Awake();
            playerInputActions = new MagiciteRewrittenInputActions();

            playerInputActions.Player.Enable();

            // playerInputActions.Player.Jump.performed += Jump_Performed;
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            // playerInputActions.Player.Jump.performed -= Jump_Performed;
        }

        private void Jump_Performed(InputAction.CallbackContext obj) {
            OnJumpAction?.Invoke(this, EventArgs.Empty);
        }

        public Vector2 GetMovementVectorNormalized() {
            Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();

            inputVector = inputVector.normalized;
            // Debug.Log(inputVector);

            return inputVector;
        }
    }
}
