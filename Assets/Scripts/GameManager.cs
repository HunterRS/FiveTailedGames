using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Player Stats")]
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

    [Header("Enemy Stats")]
    public int EnemyHealth;
    public int EnemyBlock;
    public string enemyPhase;
    public GameObject Enemy;
    public EnemyStats EnemyStats;

    [Header("Misc")]
    public Rigidbody Playerrigidbody;
    public GameObject BattleCamera;

    public bool TutorialFight;

    public GameObject CameraGimbal;
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

    public void updateCorruption()
    {
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
        HBar.transform.localScale = Vector3.MoveTowards(HBar.transform.localScale, new Vector3((float)PlayerHealth/30,.8f,.8f), .0005f);
        if (PlayerHealth <= 0)
        {
            Camera.main.GetComponent<Animator>().enabled = true;
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
        }
        if (EnemyStats.MovePattern[EnemyStats.MoveNum] == "block")
        {
            GameManager.instance.EnemyBlock = GameManager.instance.EnemyBlock + 3;
            phase_Material.color = new Color(1f, 0f, 0f);
            enemyPhase = "attack";
        }
        
        if (EnemyStats.MoveNum == EnemyStats.MovePattern.Count - 1)
        {
            EnemyStats.MoveNum = 0;
        }
        else { EnemyStats.MoveNum++; }

        CardManager.instance.DrawCard(3);
        PlayerBlock = 0;
        UIManager.instance.EnemyBlockTxT.text = GameManager.instance.EnemyBlock.ToString();
        UIManager.instance.PlayerBlockTxT.text = GameManager.instance.PlayerBlock.ToString();
        UIManager.instance.PlayerHealthTxT.text = GameManager.instance.PlayerHealth.ToString();
    }
}
