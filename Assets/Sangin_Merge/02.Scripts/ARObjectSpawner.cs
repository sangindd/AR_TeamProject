using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARFoundation;
using System.Collections.Generic;

public class ARObjectSpawner : MonoBehaviour
{
    public static ARObjectSpawner instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public GameObject objectPrefab;
    private ARRaycastManager raycastManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    public GameObject objCheck;
    public Pose pos;
    private bool groundDetected = false;
    public Vector2 groundSize;
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
                if (raycastManager.Raycast(touch.position, hits, TrackableType.Planes))
                {
                    // ù ��° ��鿡 �浹�ϸ� �ش� ��ġ�� ������Ʈ ����
                    pos = hits[0].pose;
                    objCheck = Instantiate(objectPrefab, pos.position, pos.rotation);
                    if (objCheck != null)
                        GetComponent<ARPlaneManager>().planePrefab = null;
                }
            }
        }
    }
}