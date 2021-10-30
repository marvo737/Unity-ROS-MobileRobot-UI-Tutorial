using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCanvas : MonoBehaviour
{
    public GameObject canvas;
    private Vector3 lastPosition;

    void Start()
    {
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        canvas.transform.localPosition = lastPosition;
        lastPosition = transform.position;
    }
}