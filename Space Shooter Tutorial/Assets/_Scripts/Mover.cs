using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float Speed;
	// Use this for initialization
	void Start () {
        this.GetComponent<Rigidbody>().velocity = transform.forward * Speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
