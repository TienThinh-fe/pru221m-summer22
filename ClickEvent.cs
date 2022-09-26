using UnityEngine;
using UnityEngine.EventSystems;

public class ClickEvent : EventTrigger
{
    public void ClickQuit()
    {
        Debug.Log("QUIT");
    }
    public void ClickStart()
    {
        Debug.Log("START");
    }
}
