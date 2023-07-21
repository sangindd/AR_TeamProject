using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    public string[] texts; //���߿� �ٲ� �ؽ�Ʈ

    private void Start()
    {
        texts = new string[1];
        texts[0] = "���� �̰� �������� �ɰŰ�����?";
        GameManager.instance.bottleEvent.bottle = this.gameObject;
        EventHandler.OnObjectInteraction += EventHandler_OnObjectInteraction;
    }

    private void EventHandler_OnObjectInteraction(string name, GameObject obj)
    {
        if (obj == null) return;

        if (!Quest.instance.stepOneCheck && name == "��")
        {
            Quest.instance.stepOneCheck = true;
        }
        else if (Quest.instance.stepTwoCheck && name == "��ġ" && GetComponent<Objects>().objectname == "��")
        {
            GetComponent<Objects>().TextChange(texts);
        }
    }
}
