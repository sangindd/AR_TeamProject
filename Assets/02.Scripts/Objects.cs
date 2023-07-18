using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    public enum Type { Object, Key , Item};
    public Type objectType;

    public string objectname; //이름
    public string[] objectExp; //설명

    public bool ignore; //상호작용이 끝났으면 입력을받지않는다


    public void IgnoreObject() //마우스입력안받게
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
