﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroCamera : MonoBehaviour
{
    private Gyroscope gyro;
    private bool gyroSupported;
    private Quaternion rotfix;
    
    [SerializeField ]
    private Transform obj3d;
    private float startY;
    void Start()
    {
        gyroSupported = SystemInfo.supportsGyroscope;
        GameObject camParent = new GameObject ("camParent");
        camParent.transform.position = transform.position;
        transform.parent = camParent.transform;
        if (gyroSupported)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            camParent.transform.rotation = Quaternion.Euler(90f,180f,0);
            rotfix = new Quaternion(0,0,1,0);
        }
    }

    void Update()
    {
        if (gyroSupported && startY == 0)
            ResetGyroRotation ();
        transform.localRotation = gyro.attitude * rotfix;
    }

    void ResetGyroRotation ()
    {
        startY = transform.eulerAngles.y;
        obj3d.rotation = Quaternion.Euler (0f, startY, 0f);
    }
}
