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
    public GameObject getBtn; //아이템획득버튼
    public GameObject destroyBtn; //병 부수는버튼
    public GameObject objectInfo; //현재 받은 텍스트의 게임오브젝트 정보.

    public int textCnt = 0;

    void Start()
    {
        EventHandler.OnTextChange += TouchHandler_OnTextChange;
    }

    private void TouchHandler_OnTextChange(string name, string[] exp, GameObject obj)
    {
        textCnt = 0;
        nameText.text = name;
        expTexts = exp;
        objectInfo = obj;

        UpdateExpText();
        UpdateDestroyButton();
        UpdateGetButton();
    }

    private void UpdateExpText()
    {
        if (expTexts.Length > 1)
        {
            NextBtnSet(true);
            expText.text = expTexts[textCnt];
        }
        else
        {
            NextBtnSet(false);
            expText.text = expTexts[textCnt];
        }
    }

    private void UpdateDestroyButton()
    {
        if (GameManager.instance.getItem.ItemHammerCheck() && nameText.text == "병")
        {
            destroyBtn.SetActive(true);
        }
        else
        {
            destroyBtn.SetActive(false);
        }
    }

    private void UpdateGetButton()
    {
        if (objectInfo.GetComponent<Objects>().objectType == Objects.Type.Item)
        {
            getBtn.SetActive(true);
        }
        else
        {
            getBtn.SetActive(false);
        }
    }
    public void SetTextExp(string text) //설명 변경
    {
        expText.text = text;
    }

    public void NextBtnSet(bool set) //텍스트배열의 마지막이면 버튼을 가린다.
    {
        nextBtn.SetActive(set);
    }

    public void BtnTextEvent() //버튼클릭시 호출
    {
        SetTextExp(expTexts[++textCnt]);
        if (expTexts.Length - 1 == textCnt)
        {
            NextBtnSet(false);
        }
    }

}
