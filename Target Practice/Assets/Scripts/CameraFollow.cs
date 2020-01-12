using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerObject;
    public float distfromObj= 10f;
    public int camHeight = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 lookOnObject= playerObject.position - transform.position;
        //transform.forward = lookOnObject.normalized;
        transform.position=playerObject.position-playerObject.forward * distfromObj;
        transform.LookAt(playerObject.position);
        transform.position= new Vector3 (transform.position.x,
                                        transform.position.y + camHeight,
                                        transform.position.z);

        
    }
}
