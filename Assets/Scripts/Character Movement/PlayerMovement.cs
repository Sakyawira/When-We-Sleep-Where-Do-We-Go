using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement
{
    private bool _isMovementEnabled = false;
    private bool _isLeftMovementEnabled = false;

    public void EnableMovement()
    {
        _isMovementEnabled = true;
    }
    public void DisableMovement()
    {
        _isMovementEnabled = false;
    }

    public bool IsMovementEnabled()
    {
        return _isMovementEnabled;
    }

    public void DisableLeftMovement()
    {
        _isLeftMovementEnabled = false;
    }

    public void EnableLeftMovement()
    {
        _isLeftMovementEnabled = true;
    }

    public bool IsLeftMovementEnabled()
    {
        return _isLeftMovementEnabled;
    }

    private void Update()
    {
        if (_isMovementEnabled)
        {
            if (!_isLeftMovementEnabled && Input.GetAxisRaw("Horizontal") < 0)
            {
                UpdateMove(0);
                return;
            }
            UpdateMove(Input.GetAxisRaw("Horizontal"));
        }
        else
        {
            UpdateMove(0);
        }
    }
}
