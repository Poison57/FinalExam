using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{

    bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }

        }
        
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
    }
    public void ResumeGame() 
    {
        Time.timeScale = 1;
        isPaused = false;
    }
}
