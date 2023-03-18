using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 50f;
    public Rigidbody2D rb;
    public int damage = 40;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnBecameInvisible()
    {
       Destroy(gameObject);
    }

    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        if (hitInfo.gameObject.CompareTag("Enemy") || hitInfo.gameObject.CompareTag("Ground"))
        {
            Enemy enemy = hitInfo.GetComponent<Enemy>();
           
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

           

            GameObject impact = Instantiate(impactEffect, transform.position, transform.rotation);

            Destroy(impact, 0.3f);
            Destroy(gameObject);

        }

    }


}
