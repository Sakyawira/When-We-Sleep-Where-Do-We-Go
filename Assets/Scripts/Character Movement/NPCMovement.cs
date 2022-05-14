using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : Movement
{
    [SerializeField]
    private NPCController _npcController;

    private int _fakeAxis = 0;
    private void Update()
    {
        if (_npcController.CanMove)
        {
            NPCMove();
        }
    }

    private void NPCMove()
    {
        int changeChance = 100;
        if (_fakeAxis == 1)
        {
            changeChance = 1000;
        }
        if (Random.Range(0, changeChance) == 0)
        {
            if (_fakeAxis == 0)
            {
                _fakeAxis = 1;
            }
            else
            {
                _fakeAxis = 0;
            }
        }
        UpdateMove(_fakeAxis);
    }
}
