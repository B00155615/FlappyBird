using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatObstacle : MonoBehaviour
{
    public Rigidbody bird;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bird.position.z > transform.position.z + 100){
            Debug.Log(bird.position.z);
            Debug.Log(transform.position.z);
            transform.position = new Vector3(0, Random.Range(-20,20), transform.position.z + 200);
        }
    }
}
