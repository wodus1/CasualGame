using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestoryScript : MonoBehaviour
{
    Transform ObjectPos;
    // Start is called before the first frame update
    void Start()
    {
        ObjectPos = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            BumperDestoryOb();
        }

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            SwingDestoryOb();
        }
    }
    public void BumperDestoryOb()
    {
        if (ObjectPos.position.y < -9)
        {
            Destroy(gameObject);
        }
        if(ObjectPos.position.y < -9 && CompareTag("enemy"))
        {
            BumberCarsData.score++;
        }
    }

    public void SwingDestoryOb()
    {
        if (ObjectPos.position.y < -14)
        {
            Destroy(gameObject);
        }
        if(ObjectPos.position.y < -14 && CompareTag("enemy"))
        {
            SwingData.score++;
        }
    }
}
