using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (collision.gameObject.CompareTag("Player"))
        {
            // Save the name of the current scene as the last scene
            PlayerPrefs.SetString("LastScene", SceneManager.GetActiveScene().name);

            // Load the Death Menu scene
            SceneManager.LoadScene("Death Menu");
        }

    }
}
