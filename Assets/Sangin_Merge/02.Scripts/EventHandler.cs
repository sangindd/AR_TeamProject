using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    #region ������Ʈ ���� �ؽ�Ʈ�����
    public delegate void TextUiHandler(string name, List<string> exp, GameObject obj);
    public static event TextUiHandler OnTextChange;
    public static void RaiseTextChangeEvent(string name, List<string> exp, GameObject obj)
    {
        if (OnTextChange != null)
        {
            OnTextChange(name, exp, obj);
        }
    }
    #endregion

    //������ �ֿ�����
    public delegate void GetItemHandler(GameObject item);
    public static event GetItemHandler OnItemPickedUp;
    public static void HandleItemPickedUp(GameObject item)
    {
        if (OnItemPickedUp != null)
        {
            OnItemPickedUp(item);
        }
    }
    //������ ��ȣ�ۿ��Ҷ�
    public delegate void OnObjectInteractionHandler(string name, GameObject obj);
    public static event OnObjectInteractionHandler OnObjectInteraction;
    public static void HandleObjectInteraction(string name, GameObject obj)
    {
        if (OnObjectInteraction != null && obj != null)
        {
            OnObjectInteraction(name, obj);
        }
    }
}
