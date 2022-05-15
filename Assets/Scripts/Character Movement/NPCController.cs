using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/NPC Controller", fileName = "NPC Controller")]
public class NPCController : ScriptableObject
{
    private void OnEnable()
    {
        CanMove = false;
    }

    public bool CanMove { private set; get; }
    public void AllowMove()
    {
        CanMove = true;
    }
}
