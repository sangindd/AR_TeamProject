using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    public enum Type { Object, Key, Item };
    public Type objectType;
    public enum SpawnPositionType { Fixed, NotFixed };
    public SpawnPositionType positionType;

    public string objectname; //�̸�
    public List<string> objectExp; //����

    public bool ignore; //��ȣ�ۿ��� �������� �Է��������ʴ´�
    public float spawnRange = 2f; // ������ ���� �ݰ�
    private float raycastDistance = 1f; // ����ĳ��Ʈ�� �� �Ÿ�
    //private void Start()
    //{
    //    if (positionType == SpawnPositionType.NotFixed)
    //    {
    //        Vector3 randomOffset = new Vector3(Random.Range(-spawnRange, spawnRange), 0f, Random.Range(-spawnRange, spawnRange));
    //        Vector3 spawnPosition = ARObjectSpawner.instance.pos.position + randomOffset;
    //        transform.position = spawnPosition;

    //        // ��� ��ü�� �����Ͽ� �浹 ���θ� Ȯ��
    //        Collider[] colliders = Physics.OverlapSphere(transform.position, raycastDistance, LayerMask.GetMask("Parent"));

    //        // ������ ��ü����� �浹�� Ȯ���Ͽ� ��ġ�� ����
    //        foreach (Collider collider in colliders)
    //        {
    //            if (collider.gameObject != gameObject)
    //            {
    //                Vector3 direction = collider.gameObject.transform.position - transform.position;
    //                float overlapDistance = raycastDistance - direction.magnitude;

    //                if (overlapDistance > 0)
    //                {
    //                    transform.position -= direction.normalized * overlapDistance;
    //                }
    //            }
    //        }

    //    }
    //}

    public void IgnoreObject() //���콺�Է¾ȹް�
    {
        ignore = true;
    }
    public void TextChange(string[] text)
    {
        objectExp.Clear();
        for (int i = 0; i < text.Length; i++)
        {
            objectExp.Add(text[i]);
        }
    }
}
