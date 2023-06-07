using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    Transform enemypos;
    GameObject target;
    Rigidbody rigid;
    bool move = true;
    [SerializeField]
    AudioClip collide;
    [SerializeField]
    AudioClip falling;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            target = GameObject.Find("Swingball");
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            target = GameObject.Find("Bumperball");
        }
        enemypos = gameObject.GetComponent<Transform>();
        rigid = gameObject.GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            enemypos.LookAt(target.transform);
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                rigid.AddForce(transform.forward * 1.6f);
            }

            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                rigid.AddForce(transform.forward * 4f);
            }

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rigid.velocity = (transform.position - collision.transform.position) * 15;
            audio.PlayOneShot(collide);
        }

        if (collision.gameObject.CompareTag("ground"))
        {
            audio.PlayOneShot(falling);
        }
    }
}
