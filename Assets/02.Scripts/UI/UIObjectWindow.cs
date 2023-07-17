using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIObjectWindow : MonoBehaviour
{
    public GameObject objectText; //오브젝트 터치했을때 나오는 설명창
    public void ToggleUI(bool set)
    {
        objectText.SetActive(set);
    }
}
