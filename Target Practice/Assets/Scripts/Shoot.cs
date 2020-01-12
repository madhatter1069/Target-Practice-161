using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //public GameObject projectile;
    public Rigidbody projectile;
    public int bulletSpeed = 10;
    private float timer = 0f;
    public int shootTime = 2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (timer>shootTime){
                Rigidbody clone;
            
                clone = Instantiate(projectile, transform.position+ Vector3.up, transform.rotation);
                timer = 0;
                clone.velocity = transform.TransformDirection(Vector3.forward * bulletSpeed);
            }

            

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
