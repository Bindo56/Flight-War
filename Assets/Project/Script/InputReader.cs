using UnityEngine;
using UnityEngine.InputSystem;

namespace FlightWar
{
    [RequireComponent(typeof(PlayerInput))]
    public class InputReader : MonoBehaviour
    {
        public PlayerInput playerInput;
        private InputAction moveAction;
        
        public Vector2 Move => moveAction.ReadValue<Vector2>();

        void Start()
        {
            playerInput = GetComponent<PlayerInput>();
            moveAction = playerInput.actions["Move"];
        }

    }
}