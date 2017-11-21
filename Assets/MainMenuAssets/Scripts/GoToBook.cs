using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToBook : MonoBehaviour {

    public float speed = -0.1f;

	void Start ()
    {
        
	}
	
	void Update ()
    {
        transform.Translate(new Vector3(1,0,0));
	}
}
