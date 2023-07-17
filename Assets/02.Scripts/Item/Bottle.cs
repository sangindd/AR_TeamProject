using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    private void Start()
    {
        GameManager.instance.bottleEvent.bottle = this.gameObject;
    }
}
