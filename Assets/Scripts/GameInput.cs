using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    [SerializeField] VoidEventChannelSO _pauseEventBroadcaster = default;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_pauseEventBroadcaster != null)
            {
                _pauseEventBroadcaster.RaiseEvent();
            }
        }
            

    }
}
