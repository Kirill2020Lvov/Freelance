﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    playerController player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void Start()
    {
        player = GameManager.instance.player;
    }

    private void LateUpdate()
    {
        Vector3 desiredPosition = player.transform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}
