﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedCheck1 : MonoBehaviour {

    private Player1 player;
    void Start()
    {
        player = gameObject.GetComponentInParent<Player1>();
       
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        
        player.grounded = true;
       


    }
    private void OnTriggerStay2D(Collider2D col)
    {
        player.grounded = true;
       

    }
    void OnTriggerExit2D(Collider2D col)
    {
        player.grounded = false;
        

    }

}
