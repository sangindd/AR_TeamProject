using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    public List<GameObject> items;

    void Start()
    {
        EventHandler.OnItemPickedUp += EventHandler_OnItemPickedUp;
    }

    private void EventHandler_OnItemPickedUp(GameObject item)
    {
        items.Add(item);
        item.SetActive(false);
    }

    public bool ItemHammerCheck() //�������߿� �ظӰ� �ִ��� Ȯ��
    {
        foreach (var item in items)
        {
            if (item.GetComponent<Hammer>() != null)
            {
                return true;
            }
        }
        return false;
    }
    public bool ItemLeverHandleCheck() //�������߿� ���������̰� �ִ��� Ȯ��
    {
        foreach (var item in items)
        {
            if (item.GetComponent<LeverHandle>() != null)
            {
                return true;
            }
        }
        return false;
    }
}
