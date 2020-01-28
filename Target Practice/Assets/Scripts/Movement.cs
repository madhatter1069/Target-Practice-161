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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody body= GetComponent<Rigidbody>();
        
        if (Input.GetKey(left))
        {   
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(Vector3.left);
        }

        else if (Input.GetKey(forward))  
        { 
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(Vector3.forward);
        }

        else if (Input.GetKey(back)) 
        {  
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(Vector3.back);
        }

        else if (Input.GetKey(right)) 
        {  
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(Vector3.right);
        }

    }
}
