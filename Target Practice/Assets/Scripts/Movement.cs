using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed=10;
    [SerializeField] private string forward="w";
    [SerializeField] private string left="a";
    [SerializeField] private string back="s";
    [SerializeField] private string right="d";
    public GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        //gameManager.UpdateSpawnPosition(gameObject.transform,1);
        //gameManager.UpdateSpawnPosition(gameObject.transform,2);
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody body= GetComponent<Rigidbody>();
        
        if (Input.GetKey(left))
        {   
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(Vector3.left);
        }

        else if (Input.GetKey(forward))  
        { 
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(Vector3.forward);
        }

        else if (Input.GetKey(back)) 
        {  
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(Vector3.back);
        }

        else if (Input.GetKey(right)) 
        {  
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(Vector3.right);
        }

    }
    void OnCollisionEnter(Collision collision){
        if(gameObject.tag == "player2" && collision.gameObject.tag == "bullet1"){
            gameManager.playerDeath(2);
            gameManager.GameOver(gameObject);
        }
        if(gameObject.tag == "player1" && collision.gameObject.tag == "bullet2"){
            gameManager.playerDeath(1);
            gameManager.GameOver(gameObject);
        }
    }
    
}
