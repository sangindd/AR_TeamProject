using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public static Quest instance;

    public bool stepOneCheck; //���� Ŭ���߳�?
    public bool stepTwoCheck; //��ġ�� ȹ���߳�?
    public bool stepThreeCheck; //���� ���߷ȳ�?
    public bool stepFourCheck; //���������̸� �Ծ���?
    public bool stepFiveCheck; //������ �ϼ��߳�?
    public bool EndCheck;//���� ���ڿ��� ���踦 �Ծ���?

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
