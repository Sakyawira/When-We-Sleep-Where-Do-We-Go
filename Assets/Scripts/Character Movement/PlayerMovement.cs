using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement
{
    private bool _isMovementEnabled = false;
    public void EnableMovement()
    {
        _isMovementEnabled = true;
    }
    public void DisableMovement()
    {
        _isMovementEnabled = false;
    }
    private void Update()
    {
        UpdateMove(Input.GetAxisRaw("Horizontal"));
    }
}
