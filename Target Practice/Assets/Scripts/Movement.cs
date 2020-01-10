using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody body= GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))   
            //body.AddForce(Vector3.left);
            body.velocity=new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.W))   
            //body.AddForce(Vector3.forward);
            body.velocity=new Vector3(0, 0, 1) * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.S))   
            //body.AddForce(Vector3.back);
            body.velocity=new Vector3(0, 0, -1) * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.D))   
            //body.AddForce(Vector3.right);
            body.velocity=new Vector3(1, 0, 0) * speed * Time.deltaTime;
        
    }
}
