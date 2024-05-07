using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostScores : MonoBehaviour
{
    public GameObject scorePost;
    void Start()
    {
        scorePost.GetComponent<ScoreControls>().GetScoreBtn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
