using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TexTCheck : MonoBehaviour {

    public DoorCheck1 check1;
    public DoorCheck check;
    private Animator anim;
    public bool doorTouchW = false;
    public bool doorTouchR = false;
    void Start () {
        anim = gameObject.GetComponent<Animator>();
    }
	
	
	void Update () {
		if (check1.isTriggered == true)
        {
            anim.SetBool("Wrong_Door", doorTouchW  = true);
        }
        if (check.isTriggered == true)
        {
         anim.SetBool("Right_Door", doorTouchR = true);
        }
	}
}
