using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    public enum Type { Object, Key , Item};
    public Type objectType;

    public string objectname; //�̸�
    public string[] objectExp; //����

    public bool ignore; //��ȣ�ۿ��� �������� �Է��������ʴ´�


    public void IgnoreObject() //���콺�Է¾ȹް�
    {
        ignore = true;
    }
    public void TextChange(string[] text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            objectExp[i] = text[i];
        }
    }
}
