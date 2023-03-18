using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameBtn : MonoBehaviour
{
    public void RestartGame()
    {
        // Reset the score to 0
        PlayerPrefs.SetInt("Score", 0);

        // Get the name of the scene where the player died
        string sceneName = PlayerPrefs.GetString("LastScene");

        // Load the scene where the player died
        SceneManager.LoadScene(sceneName);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
