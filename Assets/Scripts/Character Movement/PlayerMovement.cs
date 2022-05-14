using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement
{
    private void Update()
    {
        UpdateMove(Input.GetAxisRaw("Horizontal"));
    }
}
