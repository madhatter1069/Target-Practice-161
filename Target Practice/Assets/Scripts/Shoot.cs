using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public int bulletSpeed = 10;
    private float timer = 0f;
    [SerializeField] private float shootTime = 1.0f;
    [SerializeField] private string shoot="Return";
    // Start is called before the first frame update
    void Start()
    {
        timer=shootTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if (Input.GetKeyUp(shoot))
        {
            if (timer>shootTime){
                GameObject clone;
                clone = Instantiate(projectile, 
                                    transform.position + (5*transform.forward) + transform.up,
                                    transform.rotation);
                if (gameObject.tag == "player1")
                    clone.gameObject.tag = "bullet1";
                else
                    clone.gameObject.tag = "bullet2";
                timer = 0;
                Rigidbody body = clone.GetComponent<Rigidbody>(); 
                body.velocity = transform.TransformDirection(Vector3.forward * bulletSpeed);
            }

        }
        
    }
}
