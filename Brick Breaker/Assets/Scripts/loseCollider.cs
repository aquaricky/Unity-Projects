using UnityEngine;
using System.Collections;

public class loseCollider : MonoBehaviour {

    public LevelManager lvlManager;

    // Use this for initialization
    void Start()
    {
        lvlManager = GameObject.FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        lvlManager.LoadLevel("Lose Screen");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }
}
