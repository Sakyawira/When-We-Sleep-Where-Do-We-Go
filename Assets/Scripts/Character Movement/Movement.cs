using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _movementSpeed = 3.0f;
    [SerializeField]
    private Rigidbody2D _rigidBody;
    [SerializeField]
    private Animator _playerAnimator;
    [SerializeField]
    private bool _inputSwitch = true;

    public Vector2 _movement;
    private float _tempSpeed = 0.0f;
    private Vector2 _idleDir;

    protected void Start()
    {
        _tempSpeed = _movementSpeed;
    }

    protected void FixedUpdate()
    {
        _rigidBody.MovePosition(_rigidBody.position + _movement * _movementSpeed * Time.fixedDeltaTime);
    }

    protected void UpdateMove(float movementX)
    {
        if (_inputSwitch)
        {
            _movement.x = movementX;
            // _movement.y = Input.GetAxisRaw("Vertical");

            if (_movement.x != 0)
            {
                _idleDir.x = _movement.x;
                _idleDir.y = 0;
            }
            if (_movement.y != 0)
            {
                _idleDir.y = _movement.y;
                _idleDir.x = 0;
            }
        }

        _playerAnimator.SetFloat("Horizontal", _idleDir.x);
        _playerAnimator.SetFloat("Vertical", _idleDir.y);
        _playerAnimator.SetFloat("Speed", _movement.SqrMagnitude());

        if (_movement.x != 0.0f && _movement.y != 0.0f)
        {
            _movementSpeed = Mathf.Sqrt(_tempSpeed * _tempSpeed / 2);
        }
        else
        {
            _movementSpeed = _tempSpeed;
        }
    }
}
