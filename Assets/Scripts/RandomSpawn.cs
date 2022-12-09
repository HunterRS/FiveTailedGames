using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [Header("Player and UI Aspects")]
    public Rigidbody Playerrigidbody;
    public GameObject BattleCamera;
    private GameObject DeckObject;
    private GameObject Plaque;

    [Header("Forced Combat Check")]
    public bool combatForecdSpawn;

    [Header("Game Instance RNG")]
    [SerializeField] private int RNGNum;
    private string eventType;

    [Header("Enemy Instances")]
    private GameObject EnemyInst;
    [SerializeField] private GameObject Enemy;
    [SerializeField] private Transform SpawnPoint;

    [Header("Not Enemey Instances")]

    [Header("Misc")]
    Vector3 currentEulerAngles;
    // Start is called before the first frame update
    void Start()
    {
        DeckObject = GameObject.Find("GameManager/UICamera/3DCanvas/EndTurnButton");
        Plaque = GameObject.Find("GameManager/UICamera/3DCanvas/AnimaPlaque");
        
        if (combatForecdSpawn == true)
        {
            SpawnMoper();
        }
        else
        {
            RNGNum = Random.Range(1,3);
            Debug.Log(RNGNum);
            if (RNGNum == 1)
            {
                SpawnMoper();
            }
            else if (RNGNum == 2)
            {
                // SpawnAnima();
            }
            else
            {

            }
        }
        Playerrigidbody = GameManager.instance.Player.GetComponent<Rigidbody>();
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
            GameManager.instance.gameState = "combat";
            GameManager.instance.SetIdle();
            Playerrigidbody.velocity = Vector3.zero;
            if (combatForecdSpawn == true)
            {
                Plaque.SetActive(true);
                DeckObject.SetActive(true);
                StartCombat();
                GameManager.instance.CombatView(true);
            }
            else
            {

            }
        /* 
        if (Gamemanager.instance.TutorialFight == true)
        {
            GameManager.instance.RunFirstFight();
            
        }
        
        
        */
        }
    }

    private void StartCombat()
    {
        GameManager.instance.Enemy = EnemyInst;
        GameManager.instance.EnemyStats = EnemyInst.GetComponent<EnemyStats>();
        BattleCamera.SetActive(true);
        Destroy(this.gameObject);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        CardManager.instance.CreateBattleDeck();
        CardManager.instance.DrawCard(3);
    }
    private void SpawnMoper()
    {
        EnemyInst = Instantiate(Enemy, SpawnPoint.position, Quaternion.Euler(0,0,0), SpawnPoint.transform);
        EnemyInst.transform.parent = this.gameObject.transform.parent;
    }
    private void SpawnAnima()
    {

    }

}
