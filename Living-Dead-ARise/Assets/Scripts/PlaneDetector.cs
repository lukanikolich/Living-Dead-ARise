using System;
using System.Collections;
using System.Collections.Generic;
using Niantic.ARDK.AR.Anchors;
using Niantic.ARDK.AR.ARSessionEventArgs;
using Niantic.ARDK.Extensions;
using Niantic.ARDK.Utilities;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlaneDetector : MonoBehaviour
{
    private ARSessionManager _arSessionManager;
    private Camera camera;
    private bool sessionAdded = false;

    /// The object we will place when anchor is detected
    public List<GameObject> spawnies;
    public float spawnTime;
    public float spawnDelay;

    private List<float> spawnY;


    // Start is called before the first frame update
    void Start()
    {
        _arSessionManager = GetComponent<ARSessionManager>();
        camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        spawnY = new List<float>();

        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }


    // Update is called once per frame
    void Update()
    {
        if (_arSessionManager.ARSession != null && !sessionAdded)
        {
            _arSessionManager.ARSession.AnchorsAdded += OnAnchorsAdded;
            sessionAdded = true;
        }
    }

    public void SpawnObject()
    {
        if (spawnY.Count > 0)
        {
            float spawnDistance = Random.Range(6, 8);
            float spawnX = Random.Range(camera.transform.position.x - spawnDistance, camera.transform.position.x + spawnDistance);
            float spawnToCameraX = Math.Abs(spawnX - camera.transform.position.x);
            float spawnZ = (float)Math.Sqrt(spawnDistance * spawnDistance - spawnToCameraX * spawnToCameraX);
            if (Random.value >= 0.5)
            {
                spawnZ = -spawnZ;
            }
            Vector3 position = new Vector3(spawnX, spawnY[0], spawnZ);
            int spawneeIndex = Random.Range(0, spawnies.Count);
            //Debug.Log(spawneeIndex);
            GameObject spawnedObject = Instantiate(spawnies[spawneeIndex], position, transform.rotation);
            spawnedObject.transform.LookAt(new Vector3(camera.transform.position.x, spawnedObject.transform.position.y, camera.transform.position.z));
        }
    }

    void OnAnchorsAdded(AnchorsArgs args)
    {
        foreach (var anchor in args.Anchors)
        {
            // If the anchor isn't a plane, don't instantiate a GameObject
            if (anchor.AnchorType != AnchorType.Plane)
                continue;

            // Remember this anchor and its GameObject so we can update its position
            // if we receive an update.
            //planeLookup.Add(anchor.Identifier, Instantiate(PlanePrefab));
            //var gameObject = planeLookup[anchor.Identifier];

            // Display the plane GameObject in the same position, orientation, and scale as the detected plane
            //gameObject.transform.position = anchor.Transform.ToPosition();
            //gameObject.transform.rotation = anchor.Transform.ToRotation();
            //gameObject.transform.localScale = anchor.Extent;
            //Debug.Log(anchor.Transform.ToPosition());
            spawnY.Add(anchor.Transform.ToPosition().y);
            //Instantiate(PlacementObjectPf, anchor.Transform.ToPosition(), Quaternion.identity);
        }
    }
}
