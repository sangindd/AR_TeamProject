using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleEvent : MonoBehaviour
{
    [SerializeField] GameObject brokenBottlePrefab;
    public GameObject bottle;

    void Update() // just for testing
    {
        //if (Input.GetKeyDown(KeyCode.K))
        //{
        //    Explode();
        //}
    }

    public void Explode()
    {
        GameObject brokenBottle = Instantiate(brokenBottlePrefab, bottle.transform.position, Quaternion.identity);
        brokenBottle.GetComponent<BrokenBottle>().RandomVelocities();
        Destroy(bottle);
        UIManager.instance.textUI.gameObject.SetActive(false);
    }
}
