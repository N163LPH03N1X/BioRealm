﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBallOrbit : MonoBehaviour
{
    public Transform target;
    public Transform center;
    public float DistanceX = 0.0f;
    public float DistanceY = 0.0f;
    public float DistanceZ = 0.0f;
    public Vector3 distance;
    public float degreesPerSecond = 0.0f;

    void Start()
    {
        distance = transform.position - center.position;
        distance.x = DistanceX;
        distance.y = DistanceY;
        distance.z = DistanceZ;
    }
    public void MoveSpiderBall()
    {
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(90, 180, 0), Space.Self);
        distance = Quaternion.AngleAxis(degreesPerSecond * Time.deltaTime, Vector3.forward) * distance;
        transform.position = center.position + distance;
    }

}
