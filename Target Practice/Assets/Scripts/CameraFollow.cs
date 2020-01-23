using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerObject;
    public float distfromObj= 20f;
    public int camHeight = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position=playerObject.position-playerObject.forward * distfromObj;
        transform.LookAt(playerObject.position);
        transform.position= new Vector3 (transform.position.x,
                                        transform.position.y + camHeight,
                                        transform.position.z);

        
    }
}
