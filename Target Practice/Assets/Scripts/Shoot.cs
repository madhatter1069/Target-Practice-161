using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //public GameObject projectile;
    public Rigidbody projectile;
    public int bulletSpeed= 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Rigidbody clone;
            
            clone = Instantiate(projectile, transform.position+ Vector3.up, transform.rotation);
            clone.transform.parent= gameObject.transform;
            clone.AddForce(transform.forward * bulletSpeed);

            //clone.transform.Translate(Vector3.forward * bulletSpeed);
            //clone.velocity = transform.TransformDirection(Vector3.forward * bulletSpeed);
            /*
            Rigidbody body= GetComponent<Rigidbody>();
            GameObject bullet= Instantiate(projectile) as GameObject;
            bullet.transform.position=transform.position+Vector3.forward;

            
            
            /*GameObject bullet = Instantiate(projectile, 
                                            new Vector3(body.position.x,
                                            body.position.y+3,
                                            body.position.z) , 
                                            Quaternion.identity); 
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
            */
        }
        
    }
}
