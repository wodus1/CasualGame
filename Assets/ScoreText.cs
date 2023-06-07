using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreText : MonoBehaviour
{
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 4)
        {
            score = GetComponent<Text>();
            score.text = SwingData.score.ToString();
            SwingData.score = 0;
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            score = GetComponent<Text>();
            score.text = BumberCarsData.score.ToString();
            BumberCarsData.score = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
