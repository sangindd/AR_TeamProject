using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    public enum Type { Object, Key };
    public Type objectType;

    public string objectname; //�̸�
    public string[] objectExp; //����

    public bool interaction; //��ȣ�ۿ�Ƴ�? �ѹ�üũ�Ǹ� ���������� true����


    public void Interaction() //��ȣ�ۿ�
    {
        interaction = true;
    }
}
