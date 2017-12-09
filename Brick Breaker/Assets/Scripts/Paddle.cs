using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    float mousePosInBlocks;
    public bool autoplay = false;
    private Ball ball;

    // Use this for initialization
    void Start () {
        ball = GameObject.FindObjectOfType<Ball>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (!autoplay)
        {
            MoveWithMouse();
        }
        else{
            AutoPlay();
        }
        
    }

    void AutoPlay()
    {
        Vector3 paddlePosition = new Vector3(0.5f, this.transform.position.y, 0f);
        Vector3 ballPos = ball.transform.position;
        paddlePosition.x = Mathf.Clamp(ballPos.x, 0.5f, 15.5f);
        this.transform.position = paddlePosition;
    }

    void MoveWithMouse()
    {
        Vector3 paddlePosition = new Vector3(0.5f, this.transform.position.y, 0f);
        mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        paddlePosition.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);
        this.transform.position = paddlePosition;
    }
}
