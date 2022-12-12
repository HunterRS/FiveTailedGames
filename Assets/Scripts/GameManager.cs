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
    public GameObject phaseDetector;
    public Material phase_Material;
    public GameObject AnimaPlaque;
    public GameObject DeckObject;
    public GameObject[] ShieldArray;
    public GameObject[] AmuletArrayC;
    public GameObject[] AmuletArray;

    [Header("Enemy Stats")]
    public int EnemyHealth;
    public int EnemyBlock;
    public string enemyPhase;
    public GameObject Enemy;
    public EnemyStats EnemyStats;

    [Header("Misc")]
    public Rigidbody Playerrigidbody;
    public GameObject BattleCamera;
    public GameObject cameraAnchor;
    public Animator playerAnim;
    public string gameState;

    public Vector3 camBattleOffset;
    private Vector3 camMainOffset;
    private float difAngle;


    public bool TutorialFight;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        CardManager.instance.DeckCreate();
        phase_Material = phaseDetector.GetComponent<Renderer>().material;
        phase_Material.color = new Color(1f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        updateCorruption();
        updateHP();
    }

    private void updateCorruption()
    {
        if (playerCorruption < 10)
        {
            corruptFrame.gameObject.SetActive(false);
            corruptVignette.color = new Color(1, 1, 1, 0);
        }
        else
        {
            corruptFrame.gameObject.SetActive(true);
            corruptFrame.startLifetime = (float)playerCorruption / 100 * 9;
            corruptVignette.color = new Color(1, 1, 1, (float)playerCorruption/100);
        }
    }

    private void updateHP()
    {
        HBar.transform.localScale = Vector3.MoveTowards(HBar.transform.localScale, new Vector3((float)PlayerHealth/30,.8f,.8f), .0005f);
    }

    public void endTurn()
    {
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
                UIManager.instance.PlayerBlockTxT.text = GameManager.instance.PlayerBlock.ToString();
                UIManager.instance.PlayerHealthTxT.text = GameManager.instance.PlayerHealth.ToString();
                Debug.Log("Test");
            }
            else if (GameManager.instance.PlayerBlock == 0)
            {
                GameManager.instance.PlayerHealth = GameManager.instance.PlayerHealth - 3;
                UIManager.instance.PlayerHealthTxT.text = GameManager.instance.PlayerHealth.ToString();
            }
        }
        if (EnemyStats.MovePattern[EnemyStats.MoveNum] == "block")
        {
            GameManager.instance.EnemyBlock = GameManager.instance.EnemyBlock + 3;
            UIManager.instance.EnemyBlockTxT.text = GameManager.instance.EnemyBlock.ToString();
            phase_Material.color = new Color(1f, 0f, 0f);
            enemyPhase = "attack";
        }
        
        CardManager.instance.DrawCard(3);
        if (EnemyStats.MoveNum == EnemyStats.MovePattern.Count - 1)
        {
            EnemyStats.MoveNum = 0;
        }
        else { EnemyStats.MoveNum++; }
    }

    public void HideUI(){
        AnimaPlaque.SetActive(false);
        DeckObject.SetActive(false);
    }
    public void SetIdle(){
        playerAnim.SetBool("Run",false);
    }
    public void CombatView(bool x){
        if(x){
            cameraAnchor.transform.position = Player.transform.position + .5f*(Enemy.transform.position - Player.transform.position);
            cameraAnchor.transform.GetChild(0).transform.localPosition = camBattleOffset;
            cameraAnchor.transform.GetChild(0).transform.Rotate(28,0,0);
            difAngle = Vector3.Angle(new Vector3((Enemy.transform.position - Player.transform.position).x, 0, (Enemy.transform.position - Player.transform.position).z), new Vector3(cameraAnchor.transform.forward.x,0,cameraAnchor.transform.forward.z));
            cameraAnchor.transform.Rotate(0,-(180 - difAngle),0);
        }
        else{
            cameraAnchor.transform.localPosition = Vector3.zero;
            cameraAnchor.transform.Rotate(0,180 - difAngle,0);
            cameraAnchor.transform.GetChild(0).transform.localPosition = camMainOffset;
            cameraAnchor.transform.GetChild(0).transform.Rotate(-28,0,0);
            
        }
    }
}
