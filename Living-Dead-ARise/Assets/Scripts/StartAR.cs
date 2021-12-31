using System.Collections;
using System.Collections.Generic;
using Niantic.ARDK.Extensions;
using UnityEngine;

public class StartAR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ARSessionManager arSessionManager = GetComponent<ARSessionManager>();
        arSessionManager.Initialize();
        arSessionManager.EnableFeatures();
    }
}
