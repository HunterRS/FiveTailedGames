using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelpScript : MonoBehaviour
{
    private GameObject[] helpItems;
    
    public bool on = false;

    public void ShowHelp(){
        helpItems = GameObject.FindGameObjectsWithTag("Help");
        
        if(!on){
            foreach(GameObject x in helpItems){
                x.GetComponent<TMP_Text>().enabled = true;
            }
            on = true;
        }

        else{
            foreach(GameObject x in helpItems){
                x.GetComponent<TMP_Text>().enabled = false;
            }
            on = false;
        }
    }
}
