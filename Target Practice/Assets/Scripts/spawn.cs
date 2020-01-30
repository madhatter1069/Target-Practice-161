using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    

    void OnTriggerEnter(Collider collider){
        Movement movement = collider.GetComponent<Movement>();
        movement.UpdateSpawnPosition(gameObject.transform);
        //Destroy(gameObject);
            
    }

}
