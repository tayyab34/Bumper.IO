using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    private float offset;
    //private float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Vector3 offset = new Vector3(transform.position.x, 10, -20);
            transform.position = Player.transform.position + offset;
        }
        else if(Input.GetKeyDown(KeyCode.F))
        {
            transform.position = Player.transform.position;
        }
        

    }
}
