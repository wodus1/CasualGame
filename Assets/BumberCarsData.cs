using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BumberCarsData : MonoBehaviour
{
    public static int score;
    public static int BumberCarsBest;
    // Start is called before the first frame update

    void Start()
    {
        BumberCarsBest = PlayerPrefs.GetInt("Bumperbest_score");
    }

    // Update is called once per frame
    void Update()
    {
        if (score > BumberCarsBest)
        {
            BumberCarsBest = score;
            PlayerPrefs.SetInt("Bumperbest_score", BumberCarsBest);
        }
    }
}