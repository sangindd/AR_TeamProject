using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundList : MonoBehaviour
{
    static public SoundList soundList;
    [Header("������� ")]
    public AudioClip bgm1; //������ ����� ���ξ��׿�
    [Header("ȿ����")]
    public AudioClip uiTouchSound; //ȭ�� ��ġ�Ҷ����� �鸮��ȿ����
    public AudioClip crackingSound; //�� ������ �鸮�� ȿ����
    private void Awake()
    {
        if (soundList == null)
        {
            soundList = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


}
