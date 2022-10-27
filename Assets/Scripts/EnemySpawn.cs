using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    [SerializeField] private GameObject Enemy;
    [SerializeField] private Transform SpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
        Instantiate(Enemy, SpawnPoint.position, transform.rotation);
        Debug.Log(other);
        }
    }
}
//(SpawnPoint.transform.position.x, SpawnPoint.transform.position.y, SpawnPoint.transform.position.z)
