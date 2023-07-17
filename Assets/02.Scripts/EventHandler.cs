using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    #region 오브젝트 설명 텍스트변경용
    public delegate void TextUiHandler(string name, string[] exp, GameObject obj);
    public static event TextUiHandler OnTextChange;
    public static void RaiseTextChangeEvent(string name, string[] exp, GameObject obj)
    {
        if (OnTextChange != null)
        {
            OnTextChange(name, exp, obj);
        }
    }
    #endregion

    //아이템 주웠을때
    public delegate void GetItemHandler(GameObject item);
    public static event GetItemHandler OnItemPickedUp;
    public static void HandleItemPickedUp(GameObject item)
    {
        if (OnItemPickedUp != null)
        {
            OnItemPickedUp(item);
        }
    }
}
