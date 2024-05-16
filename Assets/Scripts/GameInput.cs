using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    [SerializeField] VoidEventChannelSO _pauseEventBroadcaster = default;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
