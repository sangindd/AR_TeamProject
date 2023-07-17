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
    public GameObject getBtn; //������ȹ���ư
    public GameObject destroyBtn; //�� �μ��¹�ư
    public GameObject objectInfo; //���� ���� �ؽ�Ʈ�� ���ӿ�����Ʈ ����.

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
        if (GameManager.instance.getItem.ItemHammerCheck() && nameText.text == "��")
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
    public void SetTextExp(string text) //���� ����
    {
        expText.text = text;
    }

    public void NextBtnSet(bool set) //�ؽ�Ʈ�迭�� �������̸� ��ư�� ������.
    {
        nextBtn.SetActive(set);
    }

    public void BtnTextEvent() //��ưŬ���� ȣ��
    {
        SetTextExp(expTexts[++textCnt]);
        if (expTexts.Length - 1 == textCnt)
        {
            NextBtnSet(false);
        }
    }

}
