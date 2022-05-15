using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WorldEventTrigger : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _worldEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _worldEvent?.Invoke();
    }
}
