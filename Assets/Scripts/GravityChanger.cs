using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GravityChanger : MonoBehaviour
{
    private Vector3 _sensorValue;
    // Start is called before the first frame update
    void Start()
    {
        InputSystem.EnableDevice(GravitySensor.current);
        if (GravitySensor.current.enabled)
            Debug.Log("Gravity Sensor is enabled");
        Debug.Log(GravitySensor.current.samplingFrequency);
        GravitySensor.current.samplingFrequency = 50;
    }

    /*private void OnMouseDrag()
    {
        _sensorValue = GravitySensor.current.gravity.value;
        Physics.gravity = new Vector3(_sensorValue.x, _sensorValue.y, _sensorValue.z);
    }*/

    // Update is called once per frame
    void Update()
    {
        //_sensorValue = GravitySensor.current.gravity.value;
        Physics.gravity = GravitySensor.current.gravity.value;
    }
}
