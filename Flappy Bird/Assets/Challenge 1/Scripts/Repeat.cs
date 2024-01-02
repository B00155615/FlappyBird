using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeat : MonoBehaviour
{
    public Rigidbody BirdRb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BirdRb.position.z > transform.position.z )
            transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z );
    }
}
