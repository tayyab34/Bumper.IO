using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float speed = 1;
    private Rigidbody EnemyRb;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        EnemyRb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            EnemyRb.AddForce((Player.transform.position - transform.position).normalized * speed);
        }
        
    }
}
