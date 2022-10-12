using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float charSpeed;
    public float maxSpeed;
    private Rigidbody RB;
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
        }
            if(Input.GetKey("d")){
            RB.velocity += gameObject.transform.forward * -charSpeed;
        }
        if(Input.GetKey("w")){
            RB.velocity += gameObject.transform.right * charSpeed;
        }
            if(Input.GetKey("s")){
            RB.velocity += gameObject.transform.right * -charSpeed;
        }

        
        }
        if(Input.GetKeyDown("space")){
            RB.AddForce(gameObject.transform.up * charSpeed * 10000);
        }      


        //RB.velocity = RB.velocity.normalized * charSpeed;

    }
}