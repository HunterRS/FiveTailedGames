using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Rigidbody Playerrigidbody;
    public GameObject BattleCamera;

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
        GameManager.instance.Enemy = Instantiate(Enemy, SpawnPoint.position, transform.rotation);
        GameManager.instance.EnemyStats = Enemy.GetComponent<EnemyStats>();
        Debug.Log(other);
        Playerrigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        BattleCamera.SetActive(true);
        }
    }
}
//(SpawnPoint.transform.position.x, SpawnPoint.transform.position.y, SpawnPoint.transform.position.z)
