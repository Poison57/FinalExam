using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public GameObject target;
    public float movement = 4.0f;
    public float speed = 1.0f;
    public Text scoreText;
    int score = 0;
    public GameObject scoreManage;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            MoveForward();
        }
        else if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            MoveBack();
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }
        
    }

     private void MoveLeft() 
    {
        this.transform.Translate(speed * movement * Time.deltaTime * Vector3.left);
    }

    public void MoveRight() 
    {
        this.transform.Translate(speed * movement * Time.deltaTime * Vector3.right);
    }

    public void MoveForward()
    {
        this.transform.Translate(speed * movement * Time.deltaTime * Vector3.forward);
    }

    private void MoveBack()
    {
        this.transform.Translate(speed * movement * Time.deltaTime * Vector3.back);
    }

    private void UpdateScoreText(){
        scoreText.text = score.ToString();
    }


    private void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("target")){
            score++;
            UpdateScoreText();
            Destroy(other.gameObject);
        }

        if(score == 5){
            
            SceneManager.LoadScene("Exit");
            scoreManage.GetComponent<ScoreControls>().SendScoreBtn();

        }
    }
}
