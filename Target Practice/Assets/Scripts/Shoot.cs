using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //public GameObject projectile;
    public Rigidbody projectile;
    public int bulletSpeed = 10;
    private float timer = 0f;
    [SerializeField] private float shootTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        timer=shootTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (timer>shootTime){
                Rigidbody clone;
            
                clone = Instantiate(projectile, 
                                    transform.position + (5*transform.forward) + transform.up,
                                    transform.rotation);
                timer = 0;
                clone.velocity = transform.TransformDirection(Vector3.forward * bulletSpeed);
            }

        }
        
    }
}
