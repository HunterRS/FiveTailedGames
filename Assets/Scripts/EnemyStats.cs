using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [Header("Enenmy Stats")]
    public int Health;
    public int Block;
    public GameObject HBar;
    public int MaxHealth;

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
        updateHP();
    }
    private void updateHP()
    {
        HBar.transform.localScale = Vector3.MoveTowards(HBar.transform.localScale, new Vector3((float)Health / MaxHealth, .8f, .8f), .0005f);
    }

}
