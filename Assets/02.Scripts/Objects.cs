using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    public enum Type { Object, Key };
    public Type objectType;

    public string objectname; //이름
    public string[] objectExp; //설명

    public bool interaction; //상호작용됐나? 한번체크되면 영구적으로 true고정


    public void Interaction() //상호작용
    {
        interaction = true;
    }
}
