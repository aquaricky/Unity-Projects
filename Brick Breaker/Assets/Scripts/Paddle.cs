using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    Vector3 paddlePosition;
    float mousePosInBlocks;

    // Use this for initialization
    void Start () {
        paddlePosition = new Vector3(0.5f, this.transform.position.y, 0f);
    }
	
	// Update is called once per frame
	void Update () {
        mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        paddlePosition.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);
        this.transform.position = paddlePosition;
    }
}
