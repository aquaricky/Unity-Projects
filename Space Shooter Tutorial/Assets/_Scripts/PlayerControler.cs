using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bounds
{
    public float xMin, xMax, zMin, zMax;
    public float tilt;
}

public class PlayerControler : MonoBehaviour {
    public float Speed;
    public Bounds bounds = new Bounds();
    public  Transform Spawn;
    public GameObject Shot;
    private float nextFire;
    public float fireRate;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void FixedUpdate () {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 motion = new Vector3(moveHorizontal, 0.0f, moveVertical);

        this.GetComponent<Rigidbody>().velocity = motion*Speed;
        this.GetComponent<Rigidbody>().position = new Vector3(
            Mathf.Clamp(this.GetComponent<Rigidbody>().position.x, bounds.xMin, bounds.xMax),
            0.0f,
            Mathf.Clamp(this.GetComponent<Rigidbody>().position.z, bounds.zMin, bounds.zMax)
            );
        this.GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f , 0.0f, this.GetComponent<Rigidbody>().velocity.x * -(bounds.tilt));
	}

    public void Update ()
    {
        if (Input.GetButton("Fire1")&&Time.time>nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Shot, Spawn.position, Spawn.rotation);
            audioSource.Play();
        }
    }
}
