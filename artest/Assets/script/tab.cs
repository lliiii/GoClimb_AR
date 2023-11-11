using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.InputSystem;

using UnityEngine.EventSystems;

[RequireComponent(typeof(ARRaycastManager))]

public class tab : MonoBehaviour
{
    
    [SerializeField]
    private GameObject placementIndicator;

    [SerializeField]
    private GameObject prefab;

    //private GameObject spawnObject;

    [SerializeField]
    InputAction touchInput;

    private ARRaycastManager aRRaycastManager;
    //private ARPlaneManager aRPlaneManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    private List<GameObject> spawnedObjects = new List<GameObject>();

    public GameObject FindUI;

    private void Awake()
    {

        aRRaycastManager = GetComponent<ARRaycastManager>();

        touchInput.performed += _ => {
            PlaceObject();
        };

        placementIndicator.SetActive(false);
        FindUI.SetActive(true);

    }

    private void OnEnable()
    {
        touchInput.Enable();
    }

    private void OnDisable()
    {
        touchInput.Disable();
    }

    public void Clean()
    {
        foreach (var obj in spawnedObjects)
        {
            Destroy(obj);
        }
        spawnedObjects.Clear();
    }

    private void Update()
    {

       if (!IsPointerOverUIObject())
        {
            OnEnable();
        }
        else
        {
            OnDisable();
        }

        if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.PlaneWithinPolygon))
        {
            var hitPose = hits[0].pose;
            placementIndicator.transform.SetPositionAndRotation(hitPose.position, hitPose.rotation);

            if (!placementIndicator.activeInHierarchy)
            {
                placementIndicator.SetActive(true);
                FindUI.SetActive(false);
            }
                
        }
        else
        {
            placementIndicator.SetActive(false);
            FindUI.SetActive(true);
        }

    }

    void PlaceObject()
    {
        if (!placementIndicator.activeInHierarchy) return;

        GameObject newObj = Instantiate(prefab, placementIndicator.transform.position, placementIndicator.transform.rotation);
        spawnedObjects.Add(newObj);
    }

    private bool IsPointerOverUIObject()
    {

        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }
}