using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class currentScoreText : MonoBehaviour
{
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            score.text = SwingData.score.ToString();
        }

        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            score.text = BumberCarsData.score.ToString();
        }
    }
}
