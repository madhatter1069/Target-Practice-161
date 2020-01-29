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

}
