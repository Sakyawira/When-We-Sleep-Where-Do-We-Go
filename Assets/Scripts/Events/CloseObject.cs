using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseObject : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _gameObjects;

    public void CloseObjects()
    {
        foreach(var obj in _gameObjects)
        {
            obj.SetActive(false);
        }
    }

    public void CloseSelf()
    {
        gameObject.SetActive(false);
    }
}
