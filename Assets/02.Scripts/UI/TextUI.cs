using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUI : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI expText;
    private string[] expTexts;//�޾ƿ� �ؽ�Ʈ�迭
    public GameObject nextBtn; //�����ؽ�Ʈ ��ư

    public int textCnt = 0;

    void Start()
    {
        EventHandler.OnTextChange += TouchHandler_OnTextChange;
    }

    private void TouchHandler_OnTextChange(string name, string[] exp)
    {
        textCnt = 0;
        nameText.text = name;
        expTexts = exp;

        if (expTexts.Length > 1)
        {
            NextBtnSet(true);
            expText.text = expTexts[textCnt];
        }
        else if (expTexts.Length <= 1)
        {
            NextBtnSet(false);
            expText.text = expTexts[textCnt];
        }
    }
    public void SetTextExp(string text) //���� ����
    {
        expText.text = text;
    }

    public void NextBtnSet(bool set)
    {
        nextBtn.SetActive(set);
    }

    public void BtnTextEvent()
    {
        SetTextExp(expTexts[++textCnt]);
        if (expTexts.Length - 1 == textCnt)
        {
            NextBtnSet(false);
        }
    }

    //IEnumerator TextChangeWait()
    //{

    //}
}
