using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Invoker : MonoBehaviour
{
    Timer messageTimer;
    MessageEvent messageEvent;

    void Awake()
    {
        messageEvent = new MessageEvent();
    }

	void Start()
	{
        messageTimer = gameObject.AddComponent<Timer>();
        messageTimer.Duration = 1;
        messageTimer.Run();
	}
	
	void Update()
	{
        if (messageTimer.Finished)
        {
            messageEvent.Invoke();
            messageTimer.Run();
        }
	}

    public void AddNoArgumentListener(UnityAction listener)
    {
        messageEvent.AddListener(listener);
    }
}
