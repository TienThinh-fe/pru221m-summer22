using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
	void Start()
	{
        Invoker invoker = Camera.main.GetComponent<Invoker>();
        invoker.AddNoArgumentListener(HandleMessageEvent);
	}
	
    void HandleMessageEvent()
    {
        print("MessageEvent");
    }
}
