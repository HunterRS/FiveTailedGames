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
    Vector3 currentEulerAngles;
    // Start is called before the first frame update
    void Start()
    {
        Playerrigidbody = GameObject.Find("Player").GetComponent<Rigidbody>();
        BattleCamera = GameManager.instance.BattleCamera;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
        EnemyInst = Instantiate(Enemy, SpawnPoint.position, SpawnPoint.rotation);
        EnemyInst.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
        GameManager.instance.Enemy = EnemyInst;
        //GameManager.instance.EnemySpawner = this.gameObject;
        GameManager.instance.EnemyStats = EnemyInst.GetComponent<EnemyStats>();
        Playerrigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        BattleCamera.SetActive(true);
        Destroy(this.gameObject);
        GameManager.instance.CameraGimbal.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        CardManager.instance.CreateBattleDeck();
        CardManager.instance.DrawCard(3);
        /* 
        if (Gamemanager.instance.TutorialFight == true)
        {
            GameManager.instance.RunFirstFight();
            
        }
        
        
        */
        }
    }
}
//(SpawnPoint.transform.position.x, SpawnPoint.transform.position.y, SpawnPoint.transform.position.z)
