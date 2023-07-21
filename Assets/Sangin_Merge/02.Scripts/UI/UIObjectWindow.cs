using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIObjectWindow : MonoBehaviour
{
    public GameObject objectText; //������Ʈ ��ġ������ ������ ����â
    public GameObject getItemBtn; //ȹ���ϱ� ��ưâ

    public float timer;
    public float maxTextTime = 3f; //�ؽ�Ʈ�� ������ 3���Ŀ� ������ ����

    private void OnEnable()
    {
        StartCoroutine(ToggleUIOnOff());
    }

    private void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                timer = 0;
                ToggleUI(false);
            }
        }
    }

    public void ToggleUI(bool set)
    {
        objectText.SetActive(set);
        if (set)
        {
            timer = maxTextTime;
        }
    }

    IEnumerator ToggleUIOnOff()
    {
        ToggleUI(true);
        yield return new WaitForSeconds(0.1f);
        ToggleUI(false);
    }
}
