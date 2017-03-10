using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCheck1 : MonoBehaviour {
public bool isTriggered = false;
	void Start () {
		
	}
	
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Key")
        {

            isTriggered = true;


        }

    }
}
