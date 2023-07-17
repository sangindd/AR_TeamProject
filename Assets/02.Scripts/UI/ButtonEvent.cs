using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
    public void GetItemBtnEvent()
    {
       if (UIManager.instance.textUI != null)
        {
            Objects objectInfo = UIManager.instance.textUI.objectInfo.GetComponent<Objects>();
            if (objectInfo != null && objectInfo.objectType == Objects.Type.Item)
            {
                EventHandler.HandleItemPickedUp(UIManager.instance.textUI.objectInfo);
                UIManager.instance.textUI.gameObject.SetActive(false);
            }
        }
    }
}
