using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    // Declares an array of buttons
    public Button[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        // Sets levelAt to the level selection screen within position 2 of build settings
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        // loops through all of the indexes untill the end of the button array
        for (int i = 0; i < buttons.Length; i++)
        {
            // If position within build is above the required amount then it becomes unusable
            if (i + 2 > levelAt)
            {
                buttons[i].interactable = false;
            }
        }
       
    }

    public void Level1()
    {        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Level2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
   