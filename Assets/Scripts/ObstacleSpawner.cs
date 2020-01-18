using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject Player;
    public GameObject camera;
    public GameObject ground1;
    public GameObject ground2;
    bool isnass=false;
    int n=1;   
    float sp=0.08f;  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(camera.transform.position.y % 29f);
        //Debug.Log(isnass);
        if(camera.transform.position.y>60 && camera.transform.position.y % 70f >= 0f && camera.transform.position.y % 70f <=2f && isnass==false) {
            //Instantiate(ground,new Vector3(transform.position.x,88f*n,0f),transform.rotation);
            Debug.Log("Created...!");
            if(n%2!=0) ground1.transform.position = new Vector3(ground1.transform.position.x,ground1.transform.position.y+158f,0f);
            else ground2.transform.position = new Vector3(ground2.transform.position.x,ground2.transform.position.y+158f,0f);
            if(sp<0.16f) {
                GetComponent<MoveCamera>().speed+=0.02f;
                sp+=0.02f;
                Player.GetComponent<MoveCamera>().speed+=0.02f;
            }
            isnass=true;
            n++;
        }
        if(camera.transform.position.y>(n-1)*88f && n>1) {
            isnass=false;
            //Destroy(current);
            //current=ground;
        }
    }

}
