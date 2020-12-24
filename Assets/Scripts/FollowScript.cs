using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public GameObject player;
    private Vector3 initialPos;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
    }

// Update is called once per frame
    void Update()
    {
        // Camera follows vehicle
        // transform.position = player.transform.position + new Vector3(0, 5, -11);
        transform.position = player.transform.position + initialPos;
    }
}