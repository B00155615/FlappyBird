using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    Rigidbody BirdRb;
    public TextMeshProUGUI Gems;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI ReplayText; 
    public int GemsScore;
    public bool isGameActive;
    public int health;
    public AudioSource music;
    public AudioSource gemSound;

    // Start is called before the first frame update
    void Start()
    {
        BirdRb = GetComponent<Rigidbody>();
        BirdRb.freezeRotation = true;
        health=3;
        isGameActive = true;
        music.Play();
        //ReplayText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
 

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys

        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space)){
            BirdRb.AddForce(Vector3.up* 7f, ForceMode.Impulse);     
        }
       
    }

    private void OnCollisionEnter(Collision other)
    {

        Debug.Log(other.gameObject);
        if (other.gameObject.CompareTag("GemPrefab")){
            gemSound.Play();
            GemsScore++;
            Gems.text = "Gems:" + GemsScore;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            health--;
            healthText.text = "health:" + health;
            if(health==0){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
        }
    }


    public void Replay()
    {

    
    //ReplayText.gameObject.SetActive(true);
    isGameActive = false;
    } 

}
