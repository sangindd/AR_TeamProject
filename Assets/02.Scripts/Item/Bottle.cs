using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    private void Start()
    {
        GameManager.instance.bottleEvent.bottle = this.gameObject;
        EventHandler.OnObjectInteraction += EventHandler_OnObjectInteraction;
    }

    private void EventHandler_OnObjectInteraction(string type)
    {
        if(type == "Object" && !Quest.instance.stepOneCheck)
        {
            Quest.instance.stepOneCheck = true;
        }
    }
}
