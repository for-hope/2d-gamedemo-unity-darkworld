using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCheck1 : MonoBehaviour
{
    public bool isSwitch;
    private Player1 player1;
    
    void Start()
    {
        player1 = gameObject.GetComponentInParent<Player1>();
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "razor")
        {
            
            player1.isDead1 = true;
            player1.res1 = true;
            

        }
        if(col.tag == "Key")
        {
            player1.isKey = true;
        }

    }
    
    

}
