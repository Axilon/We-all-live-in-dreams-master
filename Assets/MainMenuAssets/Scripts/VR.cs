using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VR : MonoBehaviour {

    public Camera cam;
    private Rect rect;

	void Start ()
    {
        cam.rect = new Rect(0.5f, 0, 1, 1);
    }
}
