﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFolow : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f;

    Vector3 offset;
    // Use this for initialization
    void Start()
    {
        offset = transform.position - target.position;
    }


    void FixedUpdate()
    {
        Vector3 targetCampPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCampPos, smoothing * Time.deltaTime);
    }
}