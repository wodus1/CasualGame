using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmAudio : MonoBehaviour
{
    [SerializeField]
    AudioClip[] bgm;

    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        var a = bgm[Random.Range(0, 3)];
        audio.PlayOneShot(a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
