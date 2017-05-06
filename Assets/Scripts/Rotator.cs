using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour {

    public Text winText, loseText;
    public GameObject whiteBall;
    private Vector3 startPosition;
    private float savedTimeScale;

    void Start()
    {
        winText.text = "";
        loseText.text = "";
        startPosition = whiteBall.transform.position;
    }

    // Update is called once per frame
    void Update () {
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("SpotBall"))
        {
            other.gameObject.SetActive(false);
            ScoreManager.GetScore("SpotBall");
        }

        if (other.gameObject.CompareTag("StripeBall"))
        {
            other.gameObject.SetActive(false);
            ScoreManager.GetScore("StripeBall");
        }

        if (other.gameObject.CompareTag("BlackBall"))
        {
            other.gameObject.SetActive(false);
            ScoreManager.GetScore("BlackBall");
        }

        if (other.gameObject.CompareTag("BlackBall"))
        {
            if (ScoreManager.spots > 6)
            {
                other.gameObject.SetActive(false);
                ScoreManager.GetScore("SpotBall");
                WinText();
                savedTimeScale = Time.timeScale;
                Time.timeScale = 0;
            }
            else if(other.gameObject.CompareTag("BlackBall") && ScoreManager.spots < 7)
            {
                LoseText();
                savedTimeScale = Time.timeScale;
                Time.timeScale = 0;
            }

            if (ScoreManager.stripes > 6)
            {
                other.gameObject.SetActive(false);
                ScoreManager.GetScore("StripeBall");
                WinText();
                savedTimeScale = Time.timeScale;
                Time.timeScale = 0;
            }
            else if(other.gameObject.CompareTag("BlackBall") && ScoreManager.stripes < 7)
            {
                LoseText();
                savedTimeScale = Time.timeScale;
                Time.timeScale = 0;
            }
        }

        if (other.gameObject.CompareTag("WhiteBall"))
        {
            whiteBall.GetComponent<PlayerController>().speed = 0;
            whiteBall.transform.position = startPosition;
             
        }
    }

    void WinText()
    {
        winText.text = "You Win!!!";
        loseText.enabled = false;
    }

    void LoseText()
    {
        loseText.text = "You Lose :(";
    }

}
