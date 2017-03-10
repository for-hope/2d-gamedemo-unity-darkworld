using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCheck : MonoBehaviour
{

    private Player player;
    
    void Start()
    {
        player = gameObject.GetComponentInParent<Player>();
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "razor")
        {
            
            player.isDead = true;
            player.change = true;
            player.res = true;

        }
        if (col.tag == "Key")
        {
            player.isKey = true;
        }

    }



}
