using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveGen : MonoBehaviour
{
    [Header("Caves")]
    [SerializeField] private GameObject Cave1;
    [SerializeField] private GameObject Cave2;
    [SerializeField] private GameObject Cave3;
    [SerializeField] private GameObject Cave4;
    [SerializeField] private GameObject Cave5;

    public GameObject spawnedCave1;
    public GameObject spawnedCave2;
    public GameObject spawnedCave3;
    public GameObject spawnedCave4;
    public GameObject spawnedCave5;
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnPoint3;
    public GameObject spawnPoint4;
    public GameObject spawnPoint5;

    /* Coordinates for Spawn Points 
     Cave 1 -->  Cave 1 Vector3(0,-10,4); FIXED
     Cave 1 -->  Cave 2 Vector3(-22f, -12f, -692f); FIXED
     Cave 1 -->  Cave 3 Vector3(32f, 3f, -1059f); FIXED
     Cave 1 -->  Cave 4
     Cave 1 -->  Cave 5
     Cave 2 -->  Cave 1 Vector3(68,25,-1551); FIXED
     Cave 2 -->  Cave 2 Vector3(49,23,-2242) FIXED
     Cave 2 -->  Cave 3 Vector3(83,-2,-1809); FIXED
     Cave 2 -->  Cave 4
     Cave 2 -->  Cave 5         
     Cave 3 -->  Cave 1 Vector3(58,-38,-1527); FIXED
     Cave 3 -->  Cave 2 Vector3(40,-42,-2205); FIXED
     Cave 3 -->  Cave 3 Vector3(93,-26,-2594); FIXED
     Cave 3 -->  Cave 4 
     Cave 1 -->  Cave 5         
     Cave 4 -->  Cave 1
     Cave 4 -->  Cave 2 
     Cave 4 -->  Cave 3  
     Cave 4 -->  Cave 4 
     Cave 1 -->  Cave 5              
    */


    // Start is called before the first frame update
    void Start()
    {
        int randCave1 = Random.Range(0, 3);
        int randCave2 = Random.Range(0, 3);
        int randCave3 = Random.Range(0, 3);
        int randCave4 = Random.Range(0, 3);

        if (randCave1 == 0)
        {
            spawnedCave1 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity, spawnPoint1.transform);
            spawnedCave1.transform.localScale = new Vector3(.011f,.011f,.011f);
            spawnedCave1.transform.localPosition = new Vector3(-0.0410000011f, -0.0900000036f, -0.0810000002f);
            spawnPoint2 = spawnedCave1.transform.Find("SpawnPoint").gameObject;
            spawnPoint2.transform.parent = null;

            if (randCave2 == 0)
            {
                spawnedCave2 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                spawnedCave2.transform.parent = spawnPoint2.transform;
                spawnedCave2.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                spawnedCave2.transform.localPosition = new Vector3(0,-10,4);
                spawnPoint3 = spawnedCave2.transform.Find("SpawnPoint").gameObject;
                spawnPoint3.transform.parent = null;
                if (randCave3 == 0)
                {
                    spawnedCave3 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(0,-10,4);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0,-10,4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(-22f, -12f, -692f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(32f, 3f, -1059f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 1)
                {
                    spawnedCave3 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(-22f, -12f, -692f);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(68,25,-1551);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(49,23,-2242);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(102, 39, -2585);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 2)
                {
                    spawnedCave3 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(32f, 3f, -1059f);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(58,-38,-1527);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(40,-42,-2205);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(93, -26, -2594);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
            }
            if (randCave2 == 1)
            {
                spawnedCave2 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                spawnedCave2.transform.parent = spawnPoint2.transform;
                spawnedCave2.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                spawnedCave2.transform.localPosition = new Vector3(-22f, -12f, -692f);
                spawnPoint3 = spawnedCave2.transform.Find("SpawnPoint").gameObject;
                spawnPoint3.transform.parent = null;
                if (randCave3 == 0)
                {
                    spawnedCave3 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(68,25,-1551);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0,-10,4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(-22f, -12f, -692f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(32f, 3f, -1059f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 1)
                {
                    spawnedCave3 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(49,23,-2242);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0,-10,4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(49,23,-2242);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(102, 39, -2585);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 2)
                {
                    spawnedCave3 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(102, 39, -2585);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(58,-38,-1527);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(40,-42,-2205);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(93, -26, -2594);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
            }
            if (randCave2 == 2)
            {
                spawnedCave2 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                spawnedCave2.transform.parent = spawnPoint2.transform;
                spawnedCave2.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                spawnedCave2.transform.localPosition = new Vector3(32f, 3f, -1059f);
                spawnPoint3 = spawnedCave2.transform.Find("SpawnPoint").gameObject;
                spawnPoint3.transform.parent = null;
                if (randCave3 == 0)
                {
                    spawnedCave3 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(58,-38,-1527);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    Debug.Log("test");
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0,-10,4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(-22f, -12f, -692f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(32f, 3f, -1059f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 1)
                {
                    spawnedCave3 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(40,-42,-2205);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(68,25,-1551);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(49,23,-2242);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(102, 39, -2585);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 2)
                {
                    spawnedCave3 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(93, -26, -2594);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(58,-38,-1527);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(40,-42,-2205);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(93, -26, -2594);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
            }
        }
        if (randCave1 == 1)
        {
            spawnedCave1 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity, spawnPoint1.transform);
            spawnedCave1.transform.localScale = new Vector3(.011f,.011f,.011f);
            spawnedCave1.transform.localPosition = new Vector3(-0.115000002f, -0.0979999974f, -2.78600001f);
            spawnPoint2 = spawnedCave1.transform.Find("SpawnPoint").gameObject;
            spawnPoint2.transform.parent = null;

            if (randCave2 == 0)
            {
                spawnedCave2 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                spawnedCave2.transform.parent = spawnPoint2.transform;
                spawnedCave2.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                spawnedCave2.transform.localPosition = new Vector3(68,25,-1551);
                spawnPoint3 = spawnedCave2.transform.Find("SpawnPoint").gameObject;
                spawnPoint3.transform.parent = null;
                if (randCave3 == 0)
                {
                    spawnedCave3 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(0,-10,4);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0,-10,4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(-22f, -12f, -692f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(32f, 3f, -1059f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 1)
                {
                    spawnedCave3 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(-22f, -12f, -692f);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(68,25,-1551);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(49,23,-2242);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(102, 39, -2585);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 2)
                {
                    spawnedCave3 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(32f, 3f, -1059f);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(58,-38,-1527);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(40,-42,-2205);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(93, -26, -2594);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
            }
            if (randCave2 == 1)
            {
                spawnedCave2 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                spawnedCave2.transform.parent = spawnPoint2.transform;
                spawnedCave2.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                spawnedCave2.transform.localPosition = new Vector3(49,23,-2242);
                spawnPoint3 = spawnedCave2.transform.Find("SpawnPoint").gameObject;
                spawnPoint3.transform.parent = null;
                if (randCave3 == 0)
                {
                    spawnedCave3 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(68,25,-1551);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0,-10,4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(-22f, -12f, -692f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(32f, 3f, -1059f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 1)
                {
                    spawnedCave3 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(49,23,-2242);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0,-10,4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(49,23,-2242);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(102, 39, -2585);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 2)
                {
                    spawnedCave3 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(102, 39, -2585);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(58,-38,-1527);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(40,-42,-2205);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(93, -26, -2594);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
            }
            if (randCave2 == 2)
            {
                spawnedCave2 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                spawnedCave2.transform.parent = spawnPoint2.transform;
                spawnedCave2.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                spawnedCave2.transform.localPosition = new Vector3(102, 39, -2585);
                spawnPoint3 = spawnedCave2.transform.Find("SpawnPoint").gameObject;
                spawnPoint3.transform.parent = null;
                if (randCave3 == 0)
                {
                    spawnedCave3 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(58,-38,-1527);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0,-10,4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(-22f, -12f, -692f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(32f, 3f, -1059f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 1)
                {
                    spawnedCave3 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(40,-42,-2205);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(68,25,-1551);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(49,23,-2242);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(102, 39, -2585);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 2)
                {
                    spawnedCave3 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(93, -26, -2594);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(58,-38,-1527);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(40,-42,-2205);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(93, -26, -2594);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
            }

        }
        if (randCave1 == 2)
        {
            spawnedCave1 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity, spawnPoint1.transform);
            spawnedCave1.transform.localScale = new Vector3(.011f,.011f,.011f);
            spawnedCave1.transform.localPosition = new Vector3(0.101999998f, -0.0829999968f, -4.21700001f);
            spawnPoint2 = spawnedCave1.transform.Find("SpawnPoint").gameObject;
            spawnPoint2.transform.parent = null;
            if (randCave2 == 0)
            {
                spawnedCave2 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                spawnedCave2.transform.parent = spawnPoint2.transform;
                spawnedCave2.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                spawnedCave2.transform.localPosition = new Vector3(58,-38,-1527);;

                spawnPoint3 = spawnedCave2.transform.Find("SpawnPoint").gameObject;
                spawnPoint3.transform.parent = null;
                if (randCave3 == 0)
                {
                    spawnedCave3 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(0,-10,4);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0,-10,4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(-22f, -12f, -692f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(32f, 3f, -1059f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 1)
                {
                    spawnedCave3 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(-22f, -12f, -692f);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(68,25,-1551);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(49,23,-2242);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(102, 39, -2585);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 2)
                {
                    spawnedCave3 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(32f, 3f, -1059f);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(58,-38,-1527);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(40,-42,-2205);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(93, -26, -2594);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
            }
            if (randCave2 == 1)
            {
                spawnedCave2 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                spawnedCave2.transform.parent = spawnPoint2.transform;
                spawnedCave2.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                spawnedCave2.transform.localPosition = new Vector3(40,-42,-2205);;
                spawnPoint3 = spawnedCave2.transform.Find("SpawnPoint").gameObject;
                spawnPoint3.transform.parent = null;
                if (randCave3 == 0)
                {
                    spawnedCave3 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(68,25,-1551);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0,-10,4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(-22f, -12f, -692f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(32f, 3f, -1059f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 1)
                {
                    spawnedCave3 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(49,23,-2242);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0,-10,4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(49,23,-2242);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(102, 39, -2585);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 2)
                {
                    spawnedCave3 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(102, 39, -2585);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(58,-38,-1527);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(40,-42,-2205);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(93, -26, -2594);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
            }
            if (randCave2 == 2)
            {
                spawnedCave2 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                spawnedCave2.transform.parent = spawnPoint2.transform;
                spawnedCave2.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                spawnedCave2.transform.localPosition = new Vector3(93, -26, -2594);
                spawnPoint3 = spawnedCave2.transform.Find("SpawnPoint").gameObject;
                spawnPoint3.transform.parent = null;
                if (randCave3 == 0)
                {
                    spawnedCave3 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(58,-38,-1527);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0,-10,4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(-22f, -12f, -692f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(32f, 3f, -1059f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 1)
                {
                    spawnedCave3 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(40,-42,-2205);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(68,25,-1551);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(49,23,-2242);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(102, 39, -2585);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 2)
                {
                    spawnedCave3 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(93, -26, -2594);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(58,-38,-1527);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(40,-42,-2205);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(93, -26, -2594);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
            }
        }
        if (randCave1 == 3)
        {
            spawnedCave1 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity, spawnPoint1.transform);
            spawnedCave1.transform.localScale = new Vector3(.011f, .011f, .011f);
            spawnedCave1.transform.localPosition = new Vector3(0.101999998f, -0.0829999968f, -4.21700001f);
            spawnPoint2 = spawnedCave1.transform.Find("SpawnPoint").gameObject;
            spawnPoint2.transform.parent = null;
            if (randCave2 == 0)
            {
                spawnedCave2 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                spawnedCave2.transform.parent = spawnPoint2.transform;
                spawnedCave2.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                spawnedCave2.transform.localPosition = new Vector3(58, -38, -1527); ;

                spawnPoint3 = spawnedCave2.transform.Find("SpawnPoint").gameObject;
                spawnPoint3.transform.parent = null;
                if (randCave3 == 0)
                {
                    spawnedCave3 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(0, -10, 4);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0, -10, 4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(-22f, -12f, -692f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(32f, 3f, -1059f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 1)
                {
                    spawnedCave3 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(-22f, -12f, -692f);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(68, 25, -1551);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(49, 23, -2242);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(102, 39, -2585);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 2)
                {
                    spawnedCave3 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(32f, 3f, -1059f);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(58, -38, -1527);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(40, -42, -2205);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(93, -26, -2594);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
            }
            if (randCave2 == 1)
            {
                spawnedCave2 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                spawnedCave2.transform.parent = spawnPoint2.transform;
                spawnedCave2.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                spawnedCave2.transform.localPosition = new Vector3(40, -42, -2205); ;
                spawnPoint3 = spawnedCave2.transform.Find("SpawnPoint").gameObject;
                spawnPoint3.transform.parent = null;
                if (randCave3 == 0)
                {
                    spawnedCave3 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(68, 25, -1551);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0, -10, 4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(-22f, -12f, -692f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(32f, 3f, -1059f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 1)
                {
                    spawnedCave3 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(49, 23, -2242);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0, -10, 4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(49, 23, -2242);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(102, 39, -2585);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 2)
                {
                    spawnedCave3 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(102, 39, -2585);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(58, -38, -1527);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(40, -42, -2205);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(93, -26, -2594);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
            }
            if (randCave2 == 2)
            {
                spawnedCave2 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                spawnedCave2.transform.parent = spawnPoint2.transform;
                spawnedCave2.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                spawnedCave2.transform.localPosition = new Vector3(93, -26, -2594);
                spawnPoint3 = spawnedCave2.transform.Find("SpawnPoint").gameObject;
                spawnPoint3.transform.parent = null;
                if (randCave3 == 0)
                {
                    spawnedCave3 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(58, -38, -1527);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(0, -10, 4);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(-22f, -12f, -692f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(32f, 3f, -1059f);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 1)
                {
                    spawnedCave3 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(40, -42, -2205);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(68, 25, -1551);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(49, 23, -2242);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(102, 39, -2585);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
                if (randCave3 == 2)
                {
                    spawnedCave3 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnedCave3.transform.parent = spawnPoint3.transform;
                    spawnedCave3.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                    spawnedCave3.transform.localPosition = new Vector3(93, -26, -2594);
                    spawnPoint4 = spawnedCave3.transform.Find("SpawnPoint").gameObject;
                    spawnPoint4.transform.parent = null;
                    if (randCave4 == 0)
                    {
                        spawnedCave4 = Instantiate(Cave1, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(58, -38, -1527);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 1)
                    {
                        spawnedCave4 = Instantiate(Cave2, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(40, -42, -2205);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                    if (randCave4 == 2)
                    {
                        spawnedCave4 = Instantiate(Cave3, new Vector3(0, 0, 0), Quaternion.identity);
                        spawnedCave4.transform.parent = spawnPoint4.transform;
                        spawnedCave4.transform.localScale = new Vector3(2.75f, 2.75f, 2.75f);
                        spawnedCave4.transform.localPosition = new Vector3(93, -26, -2594);
                        spawnPoint5 = spawnedCave4.transform.Find("SpawnPoint").gameObject;
                        spawnPoint5.transform.parent = null;
                    }
                }
            }
        }

        CaveVariables c1v = spawnedCave1.GetComponent<CaveVariables>();
        c1v.caveOrderNum = 1;
        CaveVariables c2v = spawnedCave2.GetComponent<CaveVariables>();
        c2v.caveOrderNum = 2;
        CaveVariables c3v = spawnedCave3.GetComponent<CaveVariables>();
        c3v.caveOrderNum = 3;
        CaveVariables c4v = spawnedCave4.GetComponent<CaveVariables>();
        c4v.caveOrderNum = 4;
        CaveVariables c5v = spawnedCave5.GetComponent<CaveVariables>();
        c5v.caveOrderNum = 5;
    }
}



/*
                //  Vector3(15.8999996f, -0.600000024f, 0f)
                /*
                if (randCave1 == 0) {
                    spawnedCave1 = Instantiate(Cave1, new Vector3(327,25,-1816), Quaternion.identity);
                    if (randCave2 == 0) {
                        spawnedCave2 = Instantiate(Cave1, new Vector3(382,10,-3102), Quaternion.identity);
                        if (randCave3 == 0) {
                            spawnedCave3 = Instantiate(Cave1, new Vector3(431,-5,-4377), Quaternion.identity);
                            if (randCave4 == 0) {spawnedCave4 = Instantiate(Cave1, new Vector3(485,-18,-5661), Quaternion.identity);}
                            if (randCave4 == 1) {spawnedCave4 = Instantiate(Cave2, new Vector3(174,-34,-5919), Quaternion.identity);}
                            if (randCave4 == 2) {spawnedCave4 = Instantiate(Cave3, new Vector3(233,-19,-6299), Quaternion.identity);}
                        }
                        if (randCave3 == 1) {
                            spawnedCave3 = Instantiate(Cave2, new Vector3(125,-20,-4645), Quaternion.identity);
                            if (randCave4 == 0) {spawnedCave4 = Instantiate(Cave1, new Vector3(485,-18,-5909), Quaternion.identity);}
                            if (randCave4 == 1) {spawnedCave4 = Instantiate(Cave2, new Vector3(183,-34,-6168), Quaternion.identity);}
                            if (randCave4 == 2) {spawnedCave4 = Instantiate(Cave3, new Vector3(233,-19,-6550), Quaternion.identity);}
                            }
                        if (randCave3 == 2) {
                            spawnedCave3 = Instantiate(Cave3, new Vector3(185,-4,-5008), Quaternion.identity);
                            if (randCave4 == 0) {spawnedCave4 = Instantiate(Cave1, new Vector3(491,-18,-5887), Quaternion.identity);}
                            if (randCave4 == 1) {spawnedCave4 = Instantiate(Cave2, new Vector3(174,-34,-5919), Quaternion.identity);}
                            if (randCave4 == 2) {spawnedCave4 = Instantiate(Cave3, new Vector3(241,-19,-6544), Quaternion.identity);}
                            }
                    }
                    if (randCave2 == 1) {
                        spawnedCave2 = Instantiate(Cave2, new Vector3(74,-6,-3361), Quaternion.identity);
                        if (randCave3 == 0) {
                            spawnedCave3 = Instantiate(Cave1, new Vector3(438,-6,-4642), Quaternion.identity);
                            if (randCave4 == 0) {spawnedCave4 = Instantiate(Cave1, new Vector3(492,-19,-5926), Quaternion.identity);}
                            if (randCave4 == 1) {spawnedCave4 = Instantiate(Cave2, new Vector3(182,-34,-6185), Quaternion.identity);}
                            if (randCave4 == 2) {spawnedCave4 = Instantiate(Cave3, new Vector3(238,-21,-6563), Quaternion.identity);}
                        }
                        if (randCave3 == 1) {
                            spawnedCave3 = Instantiate(Cave2, new Vector3(133,-21,-4903), Quaternion.identity);
                            if (randCave4 == 0) {spawnedCave4 = Instantiate(Cave1, new Vector3(496,-20,-6163), Quaternion.identity);}
                            if (randCave4 == 1) {spawnedCave4 = Instantiate(Cave2, new Vector3(189,-34,-6445), Quaternion.identity);}
                            if (randCave4 == 2) {spawnedCave4 = Instantiate(Cave3, new Vector3(241,-21,-6789), Quaternion.identity);}
                            }
                        if (randCave3 == 2) {
                            spawnedCave3 = Instantiate(Cave3, new Vector3(186,-7,-5270), Quaternion.identity);
                            if (randCave4 == 0) {spawnedCave4 = Instantiate(Cave1, new Vector3(496,-23,-6163), Quaternion.identity);}
                            if (randCave4 == 1) {spawnedCave4 = Instantiate(Cave2, new Vector3(187,-34,-6420), Quaternion.identity);}
                            if (randCave4 == 2) {spawnedCave4 = Instantiate(Cave3, new Vector3(242,-19,-6799), Quaternion.identity);}
                            }
                            }
                    if (randCave2 == 2) {
                        spawnedCave2 = Instantiate(Cave3, new Vector3(127,10,-3715), Quaternion.identity);
                        if (randCave3 == 0) {
                            spawnedCave3 = Instantiate(Cave1, new Vector3(438,-5,-4631), Quaternion.identity);
                            if (randCave4 == 0) {spawnedCave4 = Instantiate(Cave1, new Vector3(485,-18,-5661), Quaternion.identity);}
                            if (randCave4 == 1) {spawnedCave4 = Instantiate(Cave2, new Vector3(181,-34,-6173), Quaternion.identity);}
                            if (randCave4 == 2) {spawnedCave4 = Instantiate(Cave3, new Vector3(233,-19,-6299), Quaternion.identity);}
                        }
                        if (randCave3 == 1) {
                            spawnedCave3 = Instantiate(Cave2, new Vector3(128,-19,-4879), Quaternion.identity);
                            if (randCave4 == 0) {spawnedCave4 = Instantiate(Cave1, new Vector3(485,-18,-5661), Quaternion.identity);}
                            if (randCave4 == 1) {spawnedCave4 = Instantiate(Cave2, new Vector3(187,-34,-6416), Quaternion.identity);}
                            if (randCave4 == 2) {spawnedCave4 = Instantiate(Cave3, new Vector3(241,-19,-6788), Quaternion.identity);}
                            }
                        if (randCave3 == 2) {
                            spawnedCave3 = Instantiate(Cave3, new Vector3(187,-6,-5257), Quaternion.identity);
                            if (randCave4 == 0) {spawnedCave4 = Instantiate(Cave1, new Vector3(498,-21,-6162), Quaternion.identity);}
                            if (randCave4 == 1) {spawnedCave4 = Instantiate(Cave2, new Vector3(186,-34,-6420), Quaternion.identity);}
                            if (randCave4 == 2) {spawnedCave4 = Instantiate(Cave3, new Vector3(244,-23,-6790), Quaternion.identity);}
                            }
                            }
                }

                if (randCave1 == 1) {
                    spawnedCave1 = Instantiate(Cave3, new Vector3(74,28,-2472), Quaternion.identity);
                    if (randCave2 == 0) {
                        if (randCave3 == 0) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                        }
                        if (randCave3 == 1) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                            }
                        if (randCave3 == 2) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                            }
                    }
                    if (randCave2 == 1) {
                        if (randCave3 == 0) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                        }
                        if (randCave3 == 1) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                            }
                        if (randCave3 == 2) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                            }
                            }
                    if (randCave2 == 2) {
                        if (randCave3 == 0) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                        }
                        if (randCave3 == 1) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                            }
                        if (randCave3 == 2) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                            }
                            }
                }

                if (randCave1 == 2) {
                    spawnedCave1 = Instantiate(Cave3, new Vector3(74,28,-2472), Quaternion.identity);
                    if (randCave2 == 0) {
                        if (randCave3 == 0) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                        }
                        if (randCave3 == 1) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                            }
                        if (randCave3 == 2) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                            }
                    }
                    if (randCave2 == 1) {
                        if (randCave3 == 0) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                        }
                        if (randCave3 == 1) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                            }
                        if (randCave3 == 2) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                            }
                            }
                    if (randCave2 == 2) {
                        if (randCave3 == 0) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                        }
                        if (randCave3 == 1) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                            }
                        if (randCave3 == 2) {
                            if (randCave4 == 0) {}
                            if (randCave4 == 1) {}
                            if (randCave4 == 2) {}
                            }
                            }
                }
*/