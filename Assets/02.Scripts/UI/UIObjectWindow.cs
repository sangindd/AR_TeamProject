using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIObjectWindow : MonoBehaviour
{
    public GameObject objectText; //������Ʈ ��ġ������ ������ ����â
    public void ToggleUI(bool set)
    {
        objectText.SetActive(set);
    }
}
