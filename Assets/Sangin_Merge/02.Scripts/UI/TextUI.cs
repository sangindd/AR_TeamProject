using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUI : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI expText;
    public List<string> expTexts = new List<string>();//�޾ƿ� �ؽ�Ʈ�迭
    public GameObject nextBtn; //�����ؽ�Ʈ ��ư
    public GameObject getBtn; //������ȹ���ư
    public GameObject destroyBtn; //�� �μ��¹�ư
    public GameObject fixingLeverBtn; //������ ��ġ�� ��ư
    public GameObject openBoxBtn; //���ڸ� ���� ��ư
    public GameObject objectInfo; //���� ���� �ؽ�Ʈ�� ���ӿ�����Ʈ ����.
    public float typingSpeed = 0.08f;
    public int textCnt = 0;


    void Start()
    {
        EventHandler.OnTextChange += TouchHandler_OnTextChange;
    }

    private void TouchHandler_OnTextChange(string name, List<string> exp, GameObject obj)
    {
        if (obj.GetComponent<Objects>().ignore)
            return;
        expTexts.Clear();
        textCnt = 0;
        nameText.text = name;
        expTexts.AddRange(exp);
        objectInfo = obj;
        UpdateExpText();
        UpdateDestroyButton();
        UpdateGetButton();
        UpdateOpenButton();
        UpdateFixingButton();
    }

    private void UpdateExpText()
    {

        StartCoroutine(TypeText(expTexts[textCnt]));

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
            if (objectInfo.GetComponent<Hammer>() && Quest.instance.stepOneCheck)
                getBtn.SetActive(true);
            if (objectInfo.GetComponent<LeverHandle>() && Quest.instance.stepThreeCheck)
                getBtn.SetActive(true);
        }
        else
        {
            getBtn.SetActive(false);
        }
    }

    private void UpdateFixingButton()
    {
        if (Quest.instance.stepFourCheck && !Quest.instance.stepFiveCheck && nameText.text == "����")
        {
            fixingLeverBtn.SetActive(true);
        }
        else
        {
            fixingLeverBtn.SetActive(false);
        }
    }

    private void UpdateOpenButton()
    {
        if (Quest.instance.stepFourCheck && !Quest.instance.EndCheck && nameText.text == "�ϼ��� ����")
        {
            openBoxBtn.SetActive(true);
        }
        else
        {
            openBoxBtn.SetActive(false);
        }
    }

    //public void SetTextExp(string text) //���� ����
    //{
    //    StartCoroutine(TypeText(text));
    //}

    public void NextBtnSet(bool set) //�ؽ�Ʈ�迭�� �������̸� ��ư�� ������.
    {
        nextBtn.SetActive(set);
    }

    public void BtnTextEvent() //�����ؽ�Ʈ ��ưŬ���� ȣ��
    {
        StartCoroutine(TypeText(expTexts[0]));
        //SetTextExp(expTexts[0]);
        //if (expTexts.Count - 1 == textCnt)
        //{
        //    NextBtnSet(false);
        //}
    }
    IEnumerator TypeText(string exp) //�ؽ�Ʈ�� �ѱ��ھ� �߰��ϴ°�
    {
        expText.text = "";
        NextBtnSet(false);
        foreach (char letter in exp)
        {
            expText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        if (expTexts.Count > 1)
        {
            expTexts.RemoveAt(0);
            NextBtnSet(true);
        }
        else
        {
            NextBtnSet(false);
        }
    }
}
