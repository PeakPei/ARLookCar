using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
    public Transform rotateMent;
    float timer= 0;
	void Start () {
       // transform.Rotate(rotateMent.up, 30);
	}
	
	// Update is called once per frame
	void Update () {

        timer+=0.2f;
        //Debug.Log(timer);
        if (Input.GetKey(KeyCode.A)) {
            if(timer<30)
            transform.RotateAround(rotateMent.position, Vector3.up, 20 * Time.deltaTime);
        }
                         //  transform.RotateAround(rotateMent.position, Vector3.up, -20 * Time.deltaTime);
        
   
    }
}
