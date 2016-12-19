using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //used to destroy any object that exits the game view.
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
