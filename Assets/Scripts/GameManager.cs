using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int playerCorruption = 0;

    public ParticleSystem corruptFrame;
    public Image corruptVignette;
    public int Anima;
    public int PlayerHealth;
    public int EnemyHealth;
    public int PlayerBlock;
    public int EnemyBlock;
    public string enemyPhase;
    public GameObject phaseDetector;
    public Material phase_Material;
    public GameObject Enemy;
    public EnemyStats EnemyStats;

    public Rigidbody Playerrigidbody;
    public GameObject BattleCamera;

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
    public void endTurn()
    {
        if (EnemyStats.MovePattern[EnemyStats.MoveNum] == "attack")
        {
            if (GameManager.instance.PlayerBlock > 1)
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
        }
        if (EnemyStats.MovePattern[EnemyStats.MoveNum] == "block")
        {
            GameManager.instance.EnemyBlock = GameManager.instance.EnemyBlock + 3;
            UIManager.instance.EnemyBlockTxT.text = GameManager.instance.EnemyBlock.ToString();
            phase_Material.color = new Color(1f, 0f, 0f);
            enemyPhase = "attack";
        }
        CardManager.instance.DrawCard(3);
        if (EnemyStats.MoveNum == EnemyStats.MovePattern.Count - 1) {
            EnemyStats.MoveNum = 0;
        } else {EnemyStats.MoveNum++;}
    }
}
