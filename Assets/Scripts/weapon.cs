using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject AmmoPrefab;
    public GameObject PowerAmmoPrefab;
    public bool usingPowerAmmo = false;
    public Animator animator;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
      
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PowerUP"))
        {
            usingPowerAmmo = true;
           
        }
    }

    void shoot()
    {
        if (usingPowerAmmo)
        {
            Instantiate(PowerAmmoPrefab, FirePoint.position, FirePoint.rotation);
        }
        else
        {
            Instantiate(AmmoPrefab, FirePoint.position, FirePoint.rotation);
       
        }
    }


}
