using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;

    //public GameObject healthBar;

    void Start()
    {
        curHealth = maxHealth;
    }

    void Update()
    {
    }

    // public void DamagePlayer( )
    // {
    //     curHealth -= 10;

    //     healthBar.SetHealth( curHealth );
    // }
}
