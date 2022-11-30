using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Rigidbody Playerrigidbody;
    public GameObject BattleCamera;

    private GameObject EnemyInst;

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
        EnemyInst = Instantiate(Enemy, SpawnPoint.position, transform.rotation);
        GameManager.instance.Enemy = EnemyInst;
       // GameManager.instance.EnemySpawner = this.gameObject;
        GameManager.instance.EnemyStats = EnemyInst.GetComponent<EnemyStats>();
        Playerrigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        BattleCamera.SetActive(true);
        Destroy(this.gameObject);
        CardManager.instance.CreateBattleDeck();
        }
    }
}
//(SpawnPoint.transform.position.x, SpawnPoint.transform.position.y, SpawnPoint.transform.position.z)
