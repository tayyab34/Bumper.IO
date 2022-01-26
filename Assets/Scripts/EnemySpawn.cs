using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyprefab;
    public int enemies;
    // Start is called before the first frame update
    void Start()
    {
        Spawnenemy(enemies);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void Spawnenemy(int amount)
    {
        for(int i = 0; i< amount; i++)
        {
            Vector3 position = new Vector3(Random.Range(-9, 9), 0.8f, Random.Range(-9, 9));
            Instantiate(enemyprefab, position, enemyprefab.transform.rotation);
        }
    }
       
}
