using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject collidedobject=null;
    private float speed = 2;
    private Renderer render;
    public Texture[] texture;

    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        int index = Random.Range(0, texture.Length);
        if (transform.position.y < -2 && collidedobject != null)
        {
            render =collidedobject.GetComponent<MeshRenderer>();
            collidedobject.transform.localScale += new Vector3(1,1,1);
            collidedobject.GetComponent<Rigidbody>().mass += 1;
            render.material.SetTexture("_MainTex", texture[index]);
            Destroy(gameObject);
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (!collision.gameObject.CompareTag("Ground"))
        {
            collidedobject = collision.gameObject;
            collidedobject.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed, ForceMode.Impulse);
        }
        
    }
}
