using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{

#if UNITY_STANDALONE_OSX
    private void Awake()
    {
        Destroy(gameObject);
    }
#endif

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 180*Time.deltaTime, 0);
    }
}

