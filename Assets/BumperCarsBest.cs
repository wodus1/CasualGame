using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BumperCarsBest : MonoBehaviour
{
    Text best;
    // Start is called before the first frame update
    void Start()
    {
        best = GetComponent<Text>();
        best.text = BumberCarsData.BumberCarsBest.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
