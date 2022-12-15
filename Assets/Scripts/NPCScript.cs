using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public AudioSource narration;

    public void OnTriggerEnter(){
        narration.Play();
        Destroy(gameObject.GetComponent<Collider>());
    }
}
