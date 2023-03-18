using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiaScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player collided with diamond");
            score++;
            scoreText.text = "Score: " + score.ToString();
            Debug.Log("Score: " + score.ToString());

            // Save the score
            PlayerPrefs.SetInt("Score", score);
            PlayerPrefs.Save();
            Debug.Log("Score saved: " + score.ToString());
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = "Score: " + score.ToString();
        Debug.Log("Score: " + score.ToString() + " loaded.");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
