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
    [SerializeField] private int playerID = 0;
    private Transform SpawnPosition;
    
    void Start()
    {
        
    }
    public int PlayerIDNum(){
        return playerID;
    }
    public void UpdateSpawnPosition(Transform newPosition)
    {
        SpawnPosition = newPosition;
        SpawnPosition.rotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
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
        if(collision.gameObject.tag.Length>5 
            && collision.gameObject.tag.Substring(0,6) == "bullet" 
            && collision.gameObject.tag[6] != playerID){
            
            GameOver();
        }
    }
    public void GameOver()
    {
        StartCoroutine(RestartGame());
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(.5f);
        gameObject.SetActive(true);
        transform.position = SpawnPosition.position;
        transform.rotation = SpawnPosition.rotation;
    }
    
}
