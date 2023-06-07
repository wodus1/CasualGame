using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemyScript : MonoBehaviour
{
    [SerializeField]
    GameObject enemy;
    float time;
    void Start()
    {
        InvokeRepeating("create", 1, 2f );
    }

    // Update is called once per frame

    void create()
    {
        GameObject NewEnemy = Instantiate(
            enemy,
            new Vector3(Random.Range(-5,5), 0, Random.Range(-5, 5)),
            Quaternion.identity);
    }
}
