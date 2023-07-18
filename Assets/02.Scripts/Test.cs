using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject prefab;
    private void Start()
    {
        
    }

    public void insTest()
    {
        GameObject obj = Instantiate(prefab, transform.position,
              Quaternion.identity);
    }
}
