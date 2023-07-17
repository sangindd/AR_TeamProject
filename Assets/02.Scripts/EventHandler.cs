using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    #region 오브젝트 설명 텍스트변경용
    public delegate void TextUiHandler(string name, string[] exp); 
    public static event TextUiHandler OnTextChange;
    public static void RaiseTextChangeEvent(string name, string[] exp)
    {
        if (OnTextChange != null)
        {
            OnTextChange(name, exp);
        }
    }
    #endregion

}
