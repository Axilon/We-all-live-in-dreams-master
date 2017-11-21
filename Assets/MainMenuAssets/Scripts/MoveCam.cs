using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour {

    public float speed = 10f;

	void Start ()
    {
		
	}
	
	void FixedUpdate ()
    {
        Vector3 acs = Input.acceleration;
        transform.Rotate(new Vector3(0, 0, acs.x) * Time.deltaTime *speed);
	}
}
