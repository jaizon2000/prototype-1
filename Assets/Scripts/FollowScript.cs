using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public GameObject player;
    public Vector3 currentCameraPos;
    
    // Start is called before the first frame update
    void Start()
    {
        currentCameraPos = transform.position;
    }

// Update is called once per frame
    void Update()
    {
        // Camera follows vehicle
        transform.position = player.transform.position + currentCameraPos;
    }
}