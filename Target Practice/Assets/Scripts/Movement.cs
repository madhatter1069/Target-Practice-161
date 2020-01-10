using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody body= GetComponent<Rigidbody>();
        
        if (Input.GetKey(KeyCode.A))
        {   
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(Vector3.left);
        }

        else if (Input.GetKey(KeyCode.W))  
        { 
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(Vector3.forward);
        }

        else if (Input.GetKey(KeyCode.S)) 
        {  
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(Vector3.back);
        }

        else if (Input.GetKey(KeyCode.D)) 
        {  
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(Vector3.right);
        }

    }
}
