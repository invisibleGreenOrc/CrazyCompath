using System;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

namespace CrazyCompath.Units.Player
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerControls _controls;

        private float _speed = 5f;

        private void Awake()
        {
            _controls = new PlayerControls();
            _controls.GameMap.FastAttack.performed += OnFastAttack;
            _controls.GameMap.StrongAttack.performed += OnStrongAttack;
        }

        private void Update()
        {
            OnMovement();
        }

        private void OnMovement()
        {
            var direction = _controls.GameMap.Movement.ReadValue<Vector2>();

            var velocity = new Vector3(direction.x, 0f, direction.y);
            transform.position += _speed * Time.deltaTime * velocity;
        }

        private void OnStrongAttack(CallbackContext context)
        {
            throw new NotImplementedException();
        }

        private void OnFastAttack(CallbackContext context)
        {
            throw new NotImplementedException();
        }

        private void OnDestroy()
        {
            _controls.Dispose();
        }

        private void OnEnable()
        {
            _controls.Enable();
        }

        private void OnDisable()
        {
            _controls.Disable();
        }
    }
}
