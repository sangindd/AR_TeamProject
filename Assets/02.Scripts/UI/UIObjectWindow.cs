using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIObjectWindow : MonoBehaviour
{
    public GameObject objectText; //오브젝트 터치했을때 나오는 설명창
    public GameObject getItemBtn; //획득하기 버튼창

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
