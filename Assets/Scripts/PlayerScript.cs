using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float charSpeed;
    public float maxSpeed;
    public GameObject playerMeshObj;

    public Rigidbody RB;
    private bool running;
    private Animator playerAnim;

    private Vector3 runDirection;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = playerMeshObj.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        running = false;
        if(RB.velocity.magnitude <= maxSpeed){
            if(Input.GetKey("a")){
            RB.velocity += gameObject.transform.forward * charSpeed;
            running = true;
            runDirection = new Vector3(RB.velocity.x, 0, RB.velocity.z);

        }
        if(Input.GetKey("d")){
            RB.velocity += gameObject.transform.forward * -charSpeed;
            running = true;
            runDirection = new Vector3(RB.velocity.x, 0, RB.velocity.z);

        }
        if(Input.GetKey("w")){
            RB.velocity += gameObject.transform.right * charSpeed;
            running = true;
            runDirection = new Vector3(RB.velocity.x, 0, RB.velocity.z);

        }
        if(Input.GetKey("s")){
            RB.velocity += gameObject.transform.right * -charSpeed;
            running = true;
            runDirection = new Vector3(RB.velocity.x, 0, RB.velocity.z);
        }
        if(running)
            playerAnim.SetBool("Run",true);
        else
            playerAnim.SetBool("Run",false);

        playerMeshObj.transform.LookAt(playerMeshObj.transform.position + runDirection);
        }
        if(Input.GetKeyDown("space")){
            RB.AddForce(gameObject.transform.up * charSpeed * 2000);
        }      


        //RB.velocity = RB.velocity.normalized * charSpeed;

    }

    
}