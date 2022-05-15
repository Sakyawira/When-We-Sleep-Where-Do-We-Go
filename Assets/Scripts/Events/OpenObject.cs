using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenObject : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameObject;

    public void OpenGameObject()
    {
        _gameObject.SetActive(true);
    }
}