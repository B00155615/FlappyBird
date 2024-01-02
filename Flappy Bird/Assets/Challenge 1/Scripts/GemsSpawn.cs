using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemsSpawn : MonoBehaviour
{
    public GameObject GemsPrefab;
    private float GemsRepeatRate= 2;
    private float startDelay = 1;
    private Vector3 spawnPosition;
    public Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
      InvokeRepeating("SpawnGems",startDelay,GemsRepeatRate); 
    }

    // Update is called once per frame
    void Update()
    {
        spawnPosition = new Vector3(0,Random.Range(playerRb.position.y - 10,playerRb.position.y + 10), playerRb.position.z + 5);
    }

    void SpawnGems(){
      GameObject gem = Instantiate(GemsPrefab,spawnPosition,GemsPrefab.transform.rotation);
      gem.AddComponent<BoxCollider>();

    }
}
