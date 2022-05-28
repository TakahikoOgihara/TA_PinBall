using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;
    private GameObject scoreText;
    private float score = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("ScoreText");
        scoreText.GetComponent<Text>().text = "Score:" + score;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        if(Input.GetKeyDown(KeyCode.A))
        {

        }
    }

    //other.tag is not available, then this.tag is used.
    private void OnCollisionEnter(Collision other)
    {
        if (this.tag == "LargeCloudTag") { score += 20.0f; } 
        else if (this.tag == "SmallCloudTag") { score += 10.0f; }
        else if (this.tag == "LargeStarTag") { score += 40.0f; }
        else if (this.tag == "SmallStarTag") { score += 5.0f; }

        scoreText.GetComponent<Text>().text = "Score:" + score;
    }

   

}
