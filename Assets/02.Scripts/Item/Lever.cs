using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject Lever_Complete;

    void Start()
    {
        EventHandler.OnObjectInteraction += EventHandler_OnObjectInteraction;
    }

    private void EventHandler_OnObjectInteraction(string type)
    {
        if (type == "Object" && GameManager.instance.getItem.ItemLeverHandleCheck() && !Quest.instance.stepFiveCheck)
        {
            GameObject ins = Instantiate(Lever_Complete, transform.position, Quaternion.Euler(-90, 0, 0));
            ins.transform.parent = FindObjectOfType<Parent>().gameObject.transform;
            if (!Quest.instance.stepFiveCheck)
                Quest.instance.stepFiveCheck = true;
            Destroy(gameObject);
        }
    }
}
