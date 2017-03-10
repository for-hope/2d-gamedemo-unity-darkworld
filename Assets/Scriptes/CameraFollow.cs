using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float speed = 1f;
    public DoorCheck check;

    public void Start()
    {
        target = GameObject.FindGameObjectsWithTag("Player")[0].transform;

    }

    public void Update()
     
    {
        if (check.isTriggered == true) { 
        transform.position = Vector3.Lerp(transform.position, new Vector3(-18f, 0, -10), speed * Time.deltaTime);
        }
    }
}
