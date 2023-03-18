using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PowerUps : MonoBehaviour
{

    public GameObject pickupEffect;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Pickup();
        }
    }
    void Pickup()
    {

        Instantiate(pickupEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
