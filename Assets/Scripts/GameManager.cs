using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Player Stats")]
    public GameObject Player;
    public int PlayerHealth;
    public int PlayerBlock;
    public int playerCorruption = 0;
    public int Anima;

    [Header("UI Elements")]
    public ParticleSystem corruptFrame;
    public Image corruptVignette;
    public GameObject HBar;
    //public GameObject phaseDetector;
    //public Material phase_Material;
    public GameObject AnimaPlaque;
    public GameObject DeckObject;
    public GameObject helpButton;
    public GameObject[] ShieldArray;
    public GameObject[] AmuletArrayC;
    public GameObject[] AmuletArray;

    [Header("Enemy Stats")]
    public int EnemyHealth;
    public int EnemyBlock;
    public string enemyPhase;
    public GameObject Enemy;
    public EnemyStats EnemyStats;

    [Header("Camp")]
    public GameObject CampUI;
    public bool reinforcingCards;
    public Transform ReinforceUI;
    public Transform StartDeck;

    [Header("Misc")]
    public Rigidbody Playerrigidbody;
    public GameObject PlayerMesh;
    public GameObject BattleCamera;
    public GameObject cameraAnchor;
    public Animator playerAnim;
    public string gameState;


    public Vector3 camBattleOffset;
    private Vector3 camMainOffset;
    private float difAngle;
    private float difAngleP;


    public bool TutorialFight;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateBlock();
        gameState = "move";
        camMainOffset = cameraAnchor.transform.GetChild(0).transform.localPosition;
        CardManager.instance.DeckCreate();
        //phase_Material = phaseDetector.GetComponent<Renderer>().material;
        //phase_Material.color = new Color(1f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        updateCorruption();
        updateHP();
        if(gameState != "move" && Enemy.GetComponent<Rigidbody>().velocity.magnitude > 1)
            CVUpdate();
    }

    public void updateCorruption()
    {
        for(int x = 0; x < 10; x++){
            if((int)Mathf.Floor(playerCorruption/10) > x){
                AmuletArray[x].SetActive(false);
                AmuletArrayC[x].SetActive(true);
            }
            else{
                AmuletArray[x].SetActive(true);
                AmuletArrayC[x].SetActive(false);
            }
        }
        if (playerCorruption < 10)
        {
            corruptFrame.gameObject.SetActive(false);
            corruptVignette.color = new Color(1, 1, 1, 0);
        }
        else
        {
            corruptFrame.gameObject.SetActive(true);
            corruptFrame.startLifetime = ((float)playerCorruption/2) / 100 * 9;
            corruptVignette.color = new Color(1, 1, 1, (float)playerCorruption/100);
        }
        if (playerCorruption >= 100)
        {
            Camera.main.GetComponent<Animator>().enabled = true;
        }


    }

    private void updateHP()
    {
        HBar.transform.localScale = Vector3.MoveTowards(HBar.transform.localScale, new Vector3((float)PlayerHealth/30,.8f,.8f), .001f);
        if (PlayerHealth <= 0)
        {
            Camera.main.GetComponent<Animator>().enabled = true;
        }
        UIManager.instance.PlayerHealthTxT.text = GameManager.instance.PlayerHealth.ToString();
    }
    public void UpdateBlock(){
        foreach(GameObject x in ShieldArray){
            if(System.Array.IndexOf(ShieldArray, x) < PlayerBlock)
                x.SetActive(true);
            else
                x.SetActive(false);
        }
    }

    public void endTurn()
    {
        GameManager.instance.EnemyBlock = 0;
        if (EnemyStats.MovePattern[EnemyStats.MoveNum] == "attack")
        {
            if (GameManager.instance.PlayerBlock > 0)
            {
                int tempvalue = 3 - GameManager.instance.PlayerBlock;
                if (tempvalue > 0)
                {
                    GameManager.instance.PlayerHealth = GameManager.instance.PlayerHealth - tempvalue;
                    GameManager.instance.PlayerBlock = 0;
                }
                else if (tempvalue < 0)
                {
                    GameManager.instance.PlayerBlock = GameManager.instance.PlayerBlock - 3;
                }
                else
                {
                    GameManager.instance.PlayerBlock = 0;
                }
                Debug.Log("Test");
            }
            
            else if (GameManager.instance.PlayerBlock == 0)
            {
                GameManager.instance.PlayerHealth = GameManager.instance.PlayerHealth - 3;
            }
            UpdateBlock();
        }
        
        if (EnemyStats.MovePattern[EnemyStats.MoveNum] == "block")
        {
            GameManager.instance.EnemyBlock = GameManager.instance.EnemyBlock + 3;
            //phase_Material.color = new Color(1f, 0f, 0f);
            enemyPhase = "attack";
        }
        
        if (EnemyStats.MoveNum == EnemyStats.MovePattern.Count - 1)
        {
            EnemyStats.MoveNum = 0;
        }
        else { EnemyStats.MoveNum++; }

        CardManager.instance.DrawCard(3);
        //PlayerBlock = 0;
        UIManager.instance.EnemyBlockTxT.text = GameManager.instance.EnemyBlock.ToString();
        UIManager.instance.PlayerBlockTxT.text = GameManager.instance.PlayerBlock.ToString();
    }


    public void HideUI(){
        AnimaPlaque.SetActive(false);
        DeckObject.SetActive(false);
        helpButton.SetActive(false);
    }
    public void ShowUI(){
        AnimaPlaque.SetActive(true);
        DeckObject.SetActive(true);
        helpButton.SetActive(true);
    }
    public void SetIdle(){
        playerAnim.SetBool("Run",false);
    }

    public void CVUpdate(){
        cameraAnchor.transform.position = Player.transform.position + .5f*(Enemy.transform.position - Player.transform.position);
        cameraAnchor.transform.GetChild(0).transform.localPosition = camBattleOffset + new Vector3((Player.transform.position + .5f*(Enemy.transform.position - Player.transform.position)).magnitude * -.0005f,camBattleOffset.y,camBattleOffset.z);
    }
    public void CombatView(bool x){
        if(x){
            //Sets Camera Anchor to centrpoint
            cameraAnchor.transform.position = Player.transform.position + .5f*(Enemy.transform.position - Player.transform.position);
            
            //Rotates and Positions Camera
            cameraAnchor.transform.GetChild(0).transform.localPosition = camBattleOffset;
            cameraAnchor.transform.GetChild(0).transform.LookAt(cameraAnchor.transform.position);
            // cameraAnchor.transform.GetChild(0).transform.rotation = Quaternion.Euler(12,0,0);
            // cameraAnchor.transform.GetChild(0).transform.Rotate(28,0,0);
            
            // difAngle = Vector3.Angle(new Vector3((Enemy.transform.position - Player.transform.position).x, 0, (Enemy.transform.position - Player.transform.position).z), new Vector3(cameraAnchor.transform.forward.x,0,cameraAnchor.transform.forward.z));

            // cameraAnchor.transform.Rotate(0,difAngle,0);

            PlayerMesh.gameObject.transform.LookAt(GameManager.instance.Enemy.transform);
            GameManager.instance.Enemy.transform.LookAt(Player.transform);
        }
        else{
            cameraAnchor.transform.localPosition = Vector3.zero;
            cameraAnchor.transform.Rotate(0,180 - difAngle,0);
            cameraAnchor.transform.GetChild(0).transform.localPosition = camMainOffset;
            cameraAnchor.transform.GetChild(0).transform.Rotate(-28,0,0);    
        }
    }
    public void CampHeal()
    {
        PlayerHealth += 15;
        if (PlayerHealth > 30)
        {
            PlayerHealth = 30;
        }
        CampUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void CampCleanse()
    {
        playerCorruption = playerCorruption - 30;
        if (playerCorruption < 0)
        {
            playerCorruption = 0;
        }
        CampUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void CampReinforce()
    {
        reinforcingCards = true;
        CampUI.SetActive(false);
        ReinforceUI.gameObject.SetActive(true);
        while (StartDeck.childCount > 0)
        {
            Transform child = StartDeck.GetChild(0);
            child.SetParent(ReinforceUI);
            child.localRotation = Quaternion.Euler(0, -180, 0);
            child.localPosition = new Vector3 (child.localPosition.x, child.localPosition.y, 0);
            child.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        }
    }
    public void CardsReinforced()
    {
        reinforcingCards = false;
        while (ReinforceUI.childCount > 0)
        {
            Transform child = ReinforceUI.GetChild(0);
            child.SetParent(StartDeck);
            child.localPosition = new Vector3(0, 0, 0);
            child.localScale = new Vector3(0, 0, 0);
        }
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
