using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnter : MonoBehaviour {

    public GameObject Player;
    private GoToBook GoToBook;

	void Start ()
     {
        GoToBook = Player.GetComponent<GoToBook>();
	 }
	
	void Update ()
    {
		
	}

     void OnTriggerEnter(Collider other)
    {
        Destroy(GoToBook);
    }
}
