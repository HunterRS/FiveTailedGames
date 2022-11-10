using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Rigidbody Playerrigidbody;
    public GameObject BattleCamera;

    private GameObject EnemyInst = new GameObject();

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
        GameManager.instance.EnemyStats = EnemyInst.GetComponent<EnemyStats>();
        Playerrigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        BattleCamera.SetActive(true);
        GameManager.instance.AnimaPlaque.SetActive(true);
        
        UIManager.instance.EnemyHealthTxT.text = GameManager.instance.EnemyStats.Health.ToString();
        UIManager.instance.EnemyBlockTxT.text = GameManager.instance.EnemyStats.Block.ToString();
        CardManager.instance.DrawCard(3);
        }
    }
}
//(SpawnPoint.transform.position.x, SpawnPoint.transform.position.y, SpawnPoint.transform.position.z)
