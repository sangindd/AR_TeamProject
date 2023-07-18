using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIObjectWindow : MonoBehaviour
{
    public GameObject objectText; //������Ʈ ��ġ������ ������ ����â
    public GameObject getItemBtn; //ȹ���ϱ� ��ưâ

    private void OnEnable()
    {
        StartCoroutine(ToggleUIOnOff());
    }

    public void ToggleUI(bool set)
    {
        objectText.SetActive(set);
    }

    IEnumerator ToggleUIOnOff()
    {
        ToggleUI(true);
        yield return new WaitForSeconds(0.1f);
        ToggleUI(false);
    }
}
