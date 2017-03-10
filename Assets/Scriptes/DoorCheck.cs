using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCheck : MonoBehaviour {
    public SpriteRenderer spriteRenderer;
    public Collider2D coll;
    public bool isTriggered;
    public DoorCheck1 doorCheck1;
    void Start()
    {
        

    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Key" && doorCheck1.isTriggered == true)
        {

            spriteRenderer.enabled = false;
            coll.isTrigger = true;
            isTriggered = true;

        }

    }

}
