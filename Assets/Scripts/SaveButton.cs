using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Save the player's position when F2 is pressed
        if (Input.GetKeyDown(KeyCode.F2))
        {
            PlayerPrefs.SetFloat("PlayerX", transform.position.x);
            PlayerPrefs.SetFloat("PlayerY", transform.position.y);
            PlayerPrefs.SetFloat("PlayerZ", transform.position.z);
            PlayerPrefs.Save();
            Debug.Log("Player position saved.");
        }

        // Load the player's position when F3 is pressed
        if (Input.GetKeyDown(KeyCode.F3))
        {
            float x = PlayerPrefs.GetFloat("PlayerX");
            float y = PlayerPrefs.GetFloat("PlayerY");
            float z = PlayerPrefs.GetFloat("PlayerZ");
            transform.position = new Vector3(x, y, z);
            Debug.Log("Player position loaded.");
        }
    }
}
