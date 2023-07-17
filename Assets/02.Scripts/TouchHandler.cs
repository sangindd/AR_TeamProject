using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHandler : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPosition = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(clickPosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject clickedObject = hit.collider.gameObject;
                if (clickedObject.CompareTag("Object"))
                {
                    UIManager.instance.uIObjectWindow.ToggleUI(true);
                    EventHandler.RaiseTextChangeEvent(clickedObject.GetComponent<Objects>()
                        .objectname, clickedObject.GetComponent<Objects>().objectExp);
                    clickedObject.GetComponent<Objects>().Interaction();
                }
                else
                {
                    //UIManager.instance.uIObjectWindow.ToggleUI(false);
                }
            }
        }
    }
}
