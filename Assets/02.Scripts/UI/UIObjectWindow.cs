using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIObjectWindow : MonoBehaviour
{
    public GameObject objectText; //������Ʈ ��ġ������ ������ ����â
    public GameObject getItemBtn; //ȹ���ϱ� ��ưâ

    private void Start()
    {
        ToggleUI(false);
    }

    public void ToggleUI(bool set)
    {
        objectText.SetActive(set);
    }
}
