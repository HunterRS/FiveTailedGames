using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [Header("Enenmy Stats")]
    public int Health;
    public int Block;

    [Header("Enenmy Moves")]
    public int MoveNum;
    public List<string> MovePattern = new List<string>();
    public List<int> MovePatternNum = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
