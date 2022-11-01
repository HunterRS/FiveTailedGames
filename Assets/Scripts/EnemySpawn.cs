using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    [SerializeField] private GameObject Enemy;
    [SerializeField] private Transform SpawnPoint;

    [SerializeField] private List<GameObject> AnimaList = new List<GameObject>();

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
        GameManager.instance.Playerrigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        GameManager.instance.BattleCamera.SetActive(true);
        foreach (GameObject Anima in AnimaList)
        {
            Anima.SetActive(true);
            Anima.SetActive(false);
        }
        }
    }
}
//(SpawnPoint.transform.position.x, SpawnPoint.transform.position.y, SpawnPoint.transform.position.z)
