using UnityEngine;

public class Deathfloorscript : MonoBehaviour
{
    private Vector3 playerRestartpos;

    void Start()
    {
        playerRestartpos = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = playerRestartpos;
            Debug.Log("Die");
        }
    }
}
