using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int spots;
    public static int stripes;

    public Text spotCount, stripeCount;

	// Use this for initialization
	void Start () {
        spots = 0;
        stripes = 0;
        spotCount.text = spots.ToString();
        stripeCount.text = stripes.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        UpdateScore();
	}

    public static void GetScore(string type)
    {
        if(type == "StripeBall")
        {
            stripes++;
        }

        if(type == "SpotBall")
        {
            spots++;
        }  
    }

    public void UpdateScore()
    {
        stripeCount.text = "Stripes Score: " + stripes.ToString();
        spotCount.text = "Spots Score: " + spots.ToString();
    }
}
