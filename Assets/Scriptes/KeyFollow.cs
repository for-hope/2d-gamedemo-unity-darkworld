using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFollow : MonoBehaviour
{
    private Transform target;
    private Transform target2;
    public Player check;
    public Player1 check1;
    public void Start()
    {
        target = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        target2 = GameObject.FindGameObjectsWithTag("Player2")[0].transform;
    }

    public void Update()

    {
        if (check.isKey == true)
        {
            if (check.isLeft == true)
            {
                transform.position = new Vector3( target.position.x - 1, target.position.y, target.position.z);
            }
            else
            {
                transform.position = new Vector3(1 + target.position.x, target.position.y, target.position.z);
            }
            
            
        }
       if (check1.isKey == true)
        {
            if (check1.isLeft == true)
            {
                transform.position = new Vector3(target2.position.x - 1, target2.position.y, target2.position.z);
            }
            else
            {
                transform.position = new Vector3(1 + target2.position.x, target2.position.y, target2.position.z);
            }

        }
    }

}