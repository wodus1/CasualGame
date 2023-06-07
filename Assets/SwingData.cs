using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SwingData : MonoBehaviour
{
    public static int score;
    public static int SwingBest;
    // Start is called before the first frame update

    void Start()
    {
        SwingBest = PlayerPrefs.GetInt("best_score");
    }

    // Update is called once per frame
    void Update()
    {
        if (score > SwingBest)
        {
            SwingBest = score;
            PlayerPrefs.SetInt("best_score", SwingBest);
        }
    }
}