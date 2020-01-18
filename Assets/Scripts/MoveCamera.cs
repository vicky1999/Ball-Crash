using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
	public float speed=0.0001f;
    // Start is called before the first frame update
    void Start()
    {
   		
    }
    // Update is called once per frame
    void Update()
    {
        if(!Pause.ispaused)
		    transform.position=new Vector3(this.transform.position.x,this.transform.position.y+speed,-10f);
    }
}
