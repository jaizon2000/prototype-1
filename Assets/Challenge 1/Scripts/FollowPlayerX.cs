using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 currentCameraPos;

    // Start is called before the first frame update
    void Start()
    {
        // make current pos of camera == currentCameraPos
        currentCameraPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Camera follows vehicle
        transform.position = plane.transform.position + currentCameraPos;
    }
}
