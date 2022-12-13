using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float charSpeed;
    public float maxSpeed;
    public GameObject playerMeshObj;

    public Rigidbody RB;
    public Camera PlayerCam;
    private float camRotateOffset = 12;
    
    
    private bool running;
    private Animator playerAnim;

    private Vector3 tempDirection = new Vector3(1,0,0);
    private Vector3 runDirection;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = playerMeshObj.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(GameManager.instance.gameState == "move"){
            Cursor.visible = false;
            gameObject.transform.Rotate(0,Input.GetAxis("Mouse X")*1.2f,0);
            if(camRotateOffset > -10 && Input.GetAxis("Mouse Y") < 0){
                PlayerCam.transform.Rotate(-Input.GetAxis("Mouse Y"),0,0);
                camRotateOffset += Input.GetAxis("Mouse Y");
            }
            if(camRotateOffset < 30 && Input.GetAxis("Mouse Y") > 0){
                PlayerCam.transform.Rotate(-Input.GetAxis("Mouse Y"),0,0);
                camRotateOffset += Input.GetAxis("Mouse Y");
            }
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
                
                tempDirection = Vector3.RotateTowards(playerMeshObj.transform.forward,runDirection,(float)maxSpeed*Time.deltaTime,0.0f);
                playerMeshObj.transform.rotation = Quaternion.LookRotation(tempDirection);

                if(running)
                    playerAnim.SetBool("Run",true);
                else
                    playerAnim.SetBool("Run",false);
            }
            if(Input.GetKeyDown("space") && RB.velocity.y < 20 && RB.velocity.y > -20)
                RB.AddForce(gameObject.transform.up * charSpeed * 40000);
        }
        else{
            RB.velocity = Vector3.zero;
            Cursor.visible = true;
        }
    }

    
}