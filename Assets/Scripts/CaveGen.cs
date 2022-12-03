using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveGen : MonoBehaviour
{
    [Header("Caves")]
    public GameObject Cave1;
    public GameObject Cave2;
    public GameObject Cave3;

    // Start is called before the first frame update
    void Start()
    {
        int randCave1 = Random.Range(0, 1);
        int randCave2 = Random.Range(0, 3);
        int randCave3 = Random.Range(0, 3);
        int randCave4 = Random.Range(0, 3);

        if (randCave1 == 0) {
            GameObject newCave1 = Instantiate(Cave1, new Vector3(327,25,-1816), Quaternion.identity);
            if (randCave2 == 0) {
                GameObject newCave2 = Instantiate(Cave1, new Vector3(382,10,-3102), Quaternion.identity);
                if (randCave3 == 0) {
                    GameObject newCave3 = Instantiate(Cave1, new Vector3(431,-5,-4377), Quaternion.identity);
                    if (randCave4 == 0) {GameObject newCave4 = Instantiate(Cave1, new Vector3(485,-18,-5661), Quaternion.identity);}
                    if (randCave4 == 1) {GameObject newCave4 = Instantiate(Cave2, new Vector3(174,-34,-5919), Quaternion.identity);}
                    if (randCave4 == 2) {GameObject newCave4 = Instantiate(Cave3, new Vector3(233,-19,-6299), Quaternion.identity);}
                }
                if (randCave3 == 1) {
                    GameObject newCave3 = Instantiate(Cave2, new Vector3(125,-20,-4645), Quaternion.identity);
                    if (randCave4 == 0) {GameObject newCave4 = Instantiate(Cave1, new Vector3(485,-18,-5909), Quaternion.identity);}
                    if (randCave4 == 1) {GameObject newCave4 = Instantiate(Cave2, new Vector3(183,-34,-6168), Quaternion.identity);}
                    if (randCave4 == 2) {GameObject newCave4 = Instantiate(Cave3, new Vector3(233,-19,-6550), Quaternion.identity);}
                    }
                if (randCave3 == 2) {
                    GameObject newCave3 = Instantiate(Cave3, new Vector3(185,-4,-5008), Quaternion.identity);
                    if (randCave4 == 0) {GameObject newCave4 = Instantiate(Cave1, new Vector3(491,-18,-5887), Quaternion.identity);}
                    if (randCave4 == 1) {GameObject newCave4 = Instantiate(Cave2, new Vector3(174,-34,-5919), Quaternion.identity);}
                    if (randCave4 == 2) {GameObject newCave4 = Instantiate(Cave3, new Vector3(241,-19,-6544), Quaternion.identity);}
                    }
            }
            if (randCave2 == 1) {
                GameObject newCave2 = Instantiate(Cave2, new Vector3(74,-6,-3361), Quaternion.identity);
                if (randCave3 == 0) {
                    GameObject newCave3 = Instantiate(Cave1, new Vector3(438,-6,-4642), Quaternion.identity);
                    if (randCave4 == 0) {GameObject newCave4 = Instantiate(Cave1, new Vector3(492,-19,-5926), Quaternion.identity);}
                    if (randCave4 == 1) {GameObject newCave4 = Instantiate(Cave2, new Vector3(182,-34,-6185), Quaternion.identity);}
                    if (randCave4 == 2) {GameObject newCave4 = Instantiate(Cave3, new Vector3(238,-21,-6563), Quaternion.identity);}
                }
                if (randCave3 == 1) {
                    GameObject newCave3 = Instantiate(Cave2, new Vector3(133,-21,-4903), Quaternion.identity);
                    if (randCave4 == 0) {GameObject newCave4 = Instantiate(Cave1, new Vector3(496,-20,-6163), Quaternion.identity);}
                    if (randCave4 == 1) {GameObject newCave4 = Instantiate(Cave2, new Vector3(189,-34,-6445), Quaternion.identity);}
                    if (randCave4 == 2) {GameObject newCave4 = Instantiate(Cave3, new Vector3(241,-21,-6789), Quaternion.identity);}
                    }
                if (randCave3 == 2) {
                    GameObject newCave3 = Instantiate(Cave3, new Vector3(186,-7,-5270), Quaternion.identity);
                    if (randCave4 == 0) {GameObject newCave4 = Instantiate(Cave1, new Vector3(496,-23,-6163), Quaternion.identity);}
                    if (randCave4 == 1) {GameObject newCave4 = Instantiate(Cave2, new Vector3(187,-34,-6420), Quaternion.identity);}
                    if (randCave4 == 2) {GameObject newCave4 = Instantiate(Cave3, new Vector3(242,-19,-6799), Quaternion.identity);}
                    }
                    }
            if (randCave2 == 2) {
                GameObject newCave2 = Instantiate(Cave3, new Vector3(127,10,-3715), Quaternion.identity);
                if (randCave3 == 0) {
                    GameObject newCave3 = Instantiate(Cave1, new Vector3(438,-5,-4631), Quaternion.identity);
                    if (randCave4 == 0) {GameObject newCave4 = Instantiate(Cave1, new Vector3(485,-18,-5661), Quaternion.identity);}
                    if (randCave4 == 1) {GameObject newCave4 = Instantiate(Cave2, new Vector3(181,-34,-6173), Quaternion.identity);}
                    if (randCave4 == 2) {GameObject newCave4 = Instantiate(Cave3, new Vector3(233,-19,-6299), Quaternion.identity);}
                }
                if (randCave3 == 1) {
                    GameObject newCave3 = Instantiate(Cave2, new Vector3(128,-19,-4879), Quaternion.identity);
                    if (randCave4 == 0) {GameObject newCave4 = Instantiate(Cave1, new Vector3(485,-18,-5661), Quaternion.identity);}
                    if (randCave4 == 1) {GameObject newCave4 = Instantiate(Cave2, new Vector3(187,-34,-6416), Quaternion.identity);}
                    if (randCave4 == 2) {GameObject newCave4 = Instantiate(Cave3, new Vector3(241,-19,-6788), Quaternion.identity);}
                    }
                if (randCave3 == 2) {
                    GameObject newCave3 = Instantiate(Cave3, new Vector3(187,-6,-5257), Quaternion.identity);
                    if (randCave4 == 0) {GameObject newCave4 = Instantiate(Cave1, new Vector3(498,-21,-6162), Quaternion.identity);}
                    if (randCave4 == 1) {GameObject newCave4 = Instantiate(Cave2, new Vector3(186,-34,-6420), Quaternion.identity);}
                    if (randCave4 == 2) {GameObject newCave4 = Instantiate(Cave3, new Vector3(244,-23,-6790), Quaternion.identity);}
                    }
                    }
        }

        if (randCave1 == 1) {
            GameObject newCave1 = Instantiate(Cave3, new Vector3(74,28,-2472), Quaternion.identity);
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
            GameObject newCave1 = Instantiate(Cave3, new Vector3(74,28,-2472), Quaternion.identity);
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
