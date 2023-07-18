using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        EventHandler.OnObjectInteraction += EventHandler_OnObjectInteraction;
    }

    private void EventHandler_OnObjectInteraction(string type)
    {
        if (Quest.instance.stepFiveCheck)
        {
            anim.SetTrigger("Start");
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
