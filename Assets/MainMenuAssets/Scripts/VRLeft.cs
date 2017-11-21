using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLeft : MonoBehaviour {

    private Rect rect;
    public Camera cam;


    void Start ()
    {
        cam.rect = new Rect(0, 0, 0.5f, 1);
	}
}
