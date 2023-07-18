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
                // 터치 위치로 레이캐스트 수행
                if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
                {
                    // 첫 번째 평면에 충돌하면 해당 위치에 오브젝트 생성
                    Pose hitPose = hits[0].pose;
                    objCheck = Instantiate(objectPrefab, hitPose.position, hitPose.rotation);

                }
            }
        }
    }
}