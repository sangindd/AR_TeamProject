using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARFoundation;
using System.Collections.Generic;

public class ARObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    private ARRaycastManager raycastManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    public GameObject objCheck;
    private void Start()
    {
        raycastManager = FindObjectOfType<ARRaycastManager>();
    }

    private void Update()
    {
        if (Input.touchCount > 0 && objCheck == null)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                // ��ġ ��ġ�� ����ĳ��Ʈ ����
                if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
                {
                    // ù ��° ��鿡 �浹�ϸ� �ش� ��ġ�� ������Ʈ ����
                    Pose hitPose = hits[0].pose;
                    objCheck = Instantiate(objectPrefab, hitPose.position, hitPose.rotation);

                }
            }
        }
    }
}