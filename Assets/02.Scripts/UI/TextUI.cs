using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUI : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI expText;
    private string[] expTexts;//받아온 텍스트배열
    public GameObject nextBtn; //다음텍스트 버튼

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
    public void SetTextExp(string text) //설명 변경
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
