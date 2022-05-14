using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinemachineHelper : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera _cinemachineRecomposer;
    [SerializeField]
    private float horizontalMovement = 0;

    private void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        if (Input.GetAxis("Horizontal") != 0)
        {
            float baseOffset = Mathf.Abs(_cinemachineRecomposer.GetCinemachineComponent<CinemachineFramingTransposer>().m_TrackedObjectOffset.x);
            _cinemachineRecomposer.GetCinemachineComponent<CinemachineFramingTransposer>().m_TrackedObjectOffset.x = baseOffset * Normalise(Input.GetAxis("Horizontal"));
        }
        //if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        //{
        //    int baseOffset = (int)Mathf.Abs(_cinemachineRecomposer.GetCinemachineComponent<CinemachineFramingTransposer>().m_TrackedObjectOffset.x);
        //    if (Input.GetKeyDown(KeyCode.A))
        //    {
        //        _cinemachineRecomposer.GetCinemachineComponent<CinemachineFramingTransposer>().m_TrackedObjectOffset.x = baseOffset * -1;
        //    }
        //    else
        //    {
        //        _cinemachineRecomposer.GetCinemachineComponent<CinemachineFramingTransposer>().m_TrackedObjectOffset.x = baseOffset;
        //    }
        //}
    }

    private int Normalise(float number)
    {
        if (number >= 0)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
}
