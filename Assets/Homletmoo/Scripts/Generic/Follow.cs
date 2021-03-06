﻿using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour
{
    public Transform parent;
    public Vector3 offset;
    public bool relative = true;

    public bool moveX = true;
    public bool moveY = true;
    public bool moveZ = true;

    void Update()
    {
        if (parent != null)
        {
            Vector3 tempPosition = parent.position;
            if (relative)
                tempPosition += parent.TransformDirection(offset);
            else
                tempPosition += offset;
            if (!moveX) { tempPosition.x = transform.position.x; }
            if (!moveY) { tempPosition.y = transform.position.y; }
            if (!moveZ) { tempPosition.z = transform.position.z; }
            transform.position = tempPosition;
        }
    }
}
