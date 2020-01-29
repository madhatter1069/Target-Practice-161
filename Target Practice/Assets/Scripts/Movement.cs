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
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody body= GetComponent<Rigidbody>();
        
        if (Input.GetKey(left))
        {   
            body.velocity = new Vector3(speed*-1,0,0);
            transform.rotation = Quaternion.LookRotation(Vector3.left);
        }

        else if (Input.GetKey(forward))  
        { 
            body.velocity = new Vector3(0,0,speed);
            transform.rotation = Quaternion.LookRotation(Vector3.forward);
        }

        else if (Input.GetKey(back)) 
        {  
            body.velocity = new Vector3(0,0,speed*-1);
            transform.rotation = Quaternion.LookRotation(Vector3.back);
        }

        else if (Input.GetKey(right)) 
        {  
            body.velocity = new Vector3(speed,0,0);
            transform.rotation = Quaternion.LookRotation(Vector3.right);
        }
        else
            body.velocity = new Vector3(0,body.velocity.y,0);

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
