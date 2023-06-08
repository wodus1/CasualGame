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


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Vector3 force = (transform.position - collision.transform.position) * 4;
            rigid.AddForce(force, ForceMode.Impulse);
            audio.PlayOneShot(collide);
            ResetRigid();
        }

        if (collision.gameObject.CompareTag("ground"))
        {
            audio.PlayOneShot(falling);
        }
    }

    void ResetRigid()
    {
        rigid.velocity = Vector3.zero;
        rigid.angularVelocity = Vector3.zero;
    }
}
