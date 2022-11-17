using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveGen : MonoBehaviour
{
    public GameObject Cave1;
    public GameObject Cave2;
    public GameObject Cave3;

    // Start is called before the first frame update
    void Start()
    {
        int randCave1 = Random.Range(0, 3);
        int randCave2 = Random.Range(0, 3);
        int randCave3 = Random.Range(0, 3);
        int randCave4 = Random.Range(0, 3);

        if (randCave1 == 0) {
            GameObject newCave1 = Instantiate(Cave1, new Vector3(347,24,-7461), Quaternion.identity);
        } else if (randCave1 == 1) {
            GameObject newCave2 = Instantiate(Cave2, new Vector3(144,-348,-2108), Quaternion.identity);
        } else if (randCave1 == 2) {
            GameObject newCave3 = Instantiate(Cave3, new Vector3(452,-342,-2805), Quaternion.identity);
        }

        if (randCave2 == 0) {
            GameObject newCave1 = Instantiate(Cave1, new Vector3(3509,-36,-6152), Quaternion.identity);
        } else if (randCave2 == 1) {
            GameObject newCave2 = Instantiate(Cave2, new Vector3(205,-363,-3470), Quaternion.identity);
        } else if (randCave2 == 2) {
            GameObject newCave3 = Instantiate(Cave3, new Vector3(512,-361,-4164), Quaternion.identity);
        }

        if (randCave3 == 0) {
            GameObject newCave1 = Instantiate(Cave1, new Vector3(458,-3,-10248), Quaternion.identity);
        } else if (randCave3 == 1) {
            GameObject newCave2 = Instantiate(Cave2, new Vector3(195,-348,-4180), Quaternion.identity);
        } else if (randCave3 == 2) {
            GameObject newCave3 = Instantiate(Cave3, new Vector3(558,-371,-5626), Quaternion.identity);
        }

        if (randCave4 == 0) {
            GameObject newCave1 = Instantiate(Cave1, new Vector3(516,-17,-11630), Quaternion.identity);
        } else if (randCave4 == 1) {
            GameObject newCave2 = Instantiate(Cave2, new Vector3(305,-394,-6399), Quaternion.identity);
        } else if (randCave4 == 2) {
            GameObject newCave3 = Instantiate(Cave3, new Vector3(619,-389,-6953), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
