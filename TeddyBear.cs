using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyBear : MonoBehaviour
{
	void Start()
	{
        EventManager.AddDestroyEventListener(HandleDestroyEvent);
	}
    
    void HandleDestroyEvent()
    {
        Destroy(gameObject);
    }
}
