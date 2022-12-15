using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    public float charSpeed;
    public float maxSpeed;
    public GameObject playerMeshObj;
    public Transform portHack;

    public Rigidbody RB;
    public Camera PlayerCam;
    public TMP_Text centerText;

    private float camRotateOffset = 12;
    
    
    private bool running;
    private Animator playerAnim;
    private Rigidbody playerRB;

    private Vector3 tempDirection = new Vector3(1,0,0);
    private Vector3 runDirection;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = playerMeshObj.GetComponent<Animator>();
        playerRB = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        HelpCheck();
        if(GameManager.instance.gameState == "move"){
            Cursor.visible = false;
            if(Input.GetKey(KeyCode.Escape))
                gameObject.transform.position = portHack.position;
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
                
                tempDirection = Vector3.RotateTowards(playerMeshObj.transform.forward,runDirection,(float)maxSpeed/2*Time.deltaTime,0.0f);
                playerMeshObj.transform.rotation = Quaternion.LookRotation(tempDirection);

                if(running)
                    playerAnim.SetBool("Run",true);
                else
                    playerAnim.SetBool("Run",false);
            }
            if(Input.GetKeyDown("space") && RB.velocity.y < 20 && RB.velocity.y > -20)
                RB.AddForce(gameObject.transform.up * charSpeed * 50000);
        }
        else{
            RB.velocity = Vector3.zero;
            Cursor.visible = true;
        }
    }

    private void HelpCheck(){
        if(GameManager.instance.gameState == "move" && playerRB.velocity.magnitude < 2 && (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d")) ){
            centerText.text = "Spacebar to Jump";
        }
        else{
            centerText.text = "";
        }
    }

    
}