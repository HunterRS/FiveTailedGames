using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float charSpeed;
    public float maxSpeed;
    private Rigidbody RB;
    private bool running;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(RB.velocity.magnitude <= maxSpeed){
            if(Input.GetKey("a")){
            RB.velocity += gameObject.transform.forward * charSpeed;
            running = true;
        }
            if(Input.GetKey("d")){
            RB.velocity += gameObject.transform.forward * -charSpeed;
            running = true;
        }
        if(Input.GetKey("w")){
            RB.velocity += gameObject.transform.right * charSpeed;
            running = true;
        }
            if(Input.GetKey("s")){
            RB.velocity += gameObject.transform.right * -charSpeed;
            running = true;
        }

        
        }
        if(Input.GetKeyDown("space")){
            RB.AddForce(gameObject.transform.up * charSpeed * 2000);
        }      


        //RB.velocity = RB.velocity.normalized * charSpeed;

    }
}