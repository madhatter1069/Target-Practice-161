using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Movement movement;

    void OnTriggerEnter(Collider collider){
        movement.UpdateSpawnPosition(gameObject.transform);
            
    }

}
