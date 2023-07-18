using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverComplete : MonoBehaviour
{
    void Start()
    {
        EventHandler.OnObjectInteraction += EventHandler_OnObjectInteraction;
    }

    private void EventHandler_OnObjectInteraction(string type)
    {
        if (type == "Object")
        {
            
        }
    }
}
