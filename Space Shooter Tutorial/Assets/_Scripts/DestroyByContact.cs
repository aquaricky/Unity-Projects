using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject Playerexplosion;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        var exeplosionClone = Instantiate(explosion,transform.position,transform.rotation);
        if(other.tag == "Player")
        {
            var PlayerexeplosionClone = Instantiate(Playerexplosion, other.transform.position, other.transform.rotation);
            Destroy(PlayerexeplosionClone, 1);
        }
        Destroy(exeplosionClone, 2);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}