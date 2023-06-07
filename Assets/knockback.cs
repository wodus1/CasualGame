using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class knockback1 : MonoBehaviour
{
    Rigidbody rigid;
    [SerializeField]
    AudioClip collide;
    [SerializeField]
    AudioClip falling;

    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            rigid.velocity = (transform.position - collision.transform.position) * 10;
            audio.PlayOneShot(collide);
        }

        if (collision.gameObject.CompareTag("ground"))
        {
            audio.PlayOneShot(falling);
        }
    }

}
