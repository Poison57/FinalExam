using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    GameObject name;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton(){
        SceneManager.LoadScene("Game");
    }

    public void StopButton(){
        SceneManager.LoadScene("Exit");
    }

    public void PlayAgain(){
        SceneManager.LoadScene("Intro");
    }


    public void Exit(){
        UnityEditor.EditorApplication.ExitPlaymode();
    }





}