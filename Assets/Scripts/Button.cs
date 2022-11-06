using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{   
    public void OnMouseDown()
    {
        GameManager.instance.endTurn();
    }
}
