using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider collider){
        if (collider.tag == "player1"){
            gameManager.UpdateSpawnPosition(gameObject.transform,1);
        }
        if (collider.tag == "player2"){
            gameManager.UpdateSpawnPosition(gameObject.transform,2);
        }
            
    }
    /*void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "player1"){
            Debug.Log("Hello1");
            gameManager.UpdateSpawnPosition(gameObject.transform,1);
        }
        if (collision.gameObject.tag == "player2"){
            Debug.Log("Hello2");
            gameManager.UpdateSpawnPosition(gameObject.transform,2);
        }
            
    }*/

}
