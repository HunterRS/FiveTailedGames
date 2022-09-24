using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardManager : MonoBehaviour
{
    public static CardManager instance;

    public static Card[] cardArray;     // Array of all cards
    public Card[] cardArrayTemp;     // Array of all cards
    private Card placeholder;
    private Card NewCard;
    public Transform canvas;
    public GameObject[] animaArrayTemp;
    public static GameObject[] animaArray;
    public int Anima;
    public int PlayerHealth;
    public int EnemyHealth;
    public int PlayerBlock;
    public int EnemyBlock;
    public TextMeshProUGUI PlayerHealthTxT;
    public TextMeshProUGUI EnemyHealthTxT;
    public TextMeshProUGUI PlayerBlockTxT;
    public TextMeshProUGUI EnemyBlockTxT;
    public string enemyPhase;
    public GameObject phaseDetector;
    public Material phase_Material;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        phase_Material = phaseDetector.GetComponent<Renderer>().material;
        phase_Material.color = new Color(1f, 0f, 0f);
        animaArray = new GameObject[animaArrayTemp.Length]; // creates Arrays with number of entries equal to cardNum
        for (int i = 0; i < animaArrayTemp.Length; i++)
        {
            animaArray[i] = animaArrayTemp[i];
            animaArray[i].SetActive(false);
        }
        cardArray = new Card[cardArrayTemp.Length]; // creates Arrays with number of entries equal to cardNum
        for (int i = 0; i < cardArrayTemp.Length; i++)
        {
            cardArray[i] = cardArrayTemp[i];
        }

        for (int i = 0; i < cardArray.Length; i++)
        {
            NewCard = cardArray[Random.Range(0, cardArray.Length)];
            Instantiate(NewCard, new Vector3(canvas.position.x+.3f - (i* .3f), canvas.position.y-.3f, canvas.position.z), Quaternion.identity, canvas.transform);    // creates card, attaching it to placeholder.
        }
    }

    // Update is called once per frame
        void Update()
    {
        
    }
    public static void AnimaChange()
    {
        for (int i = 0; i < animaArray.Length; i++)
        {
            if (CardManager.instance.Anima >= i)
            {
                animaArray[i].SetActive(true);
            }
            if (CardManager.instance.Anima <= i)
            {
                animaArray[i].SetActive(false);
            }
        }

    }
    public void endTurn()
    {
        if (enemyPhase == "attack")
        {
            if (CardManager.instance.PlayerBlock > 1)
            {
                int tempvalue = 3 - CardManager.instance.PlayerBlock;
                if (tempvalue > 0)
                {
                    CardManager.instance.PlayerHealth = CardManager.instance.PlayerHealth - tempvalue;
                    CardManager.instance.PlayerHealthTxT.text = CardManager.instance.PlayerHealth.ToString();
                    CardManager.instance.PlayerBlock = 0;
                    CardManager.instance.PlayerBlockTxT.text = CardManager.instance.PlayerBlock.ToString();
                }
                else if (tempvalue < 0)
                {
                    CardManager.instance.PlayerBlock = CardManager.instance.PlayerBlock - 3;
                    CardManager.instance.PlayerBlockTxT.text = CardManager.instance.PlayerBlock.ToString();
                }
                else
                {
                    CardManager.instance.PlayerBlock = 0;
                    CardManager.instance.PlayerBlockTxT.text = CardManager.instance.PlayerBlock.ToString();
                }
            }
            else
            {
                CardManager.instance.PlayerHealth = CardManager.instance.PlayerHealth - 3;
                CardManager.instance.PlayerHealthTxT.text = CardManager.instance.PlayerHealth.ToString();
            }

            phase_Material.color = new Color(0f, 0f, 1f);
            enemyPhase = "block";
        }
        else
        {
            CardManager.instance.EnemyBlock = CardManager.instance.EnemyBlock + 3;
            CardManager.instance.EnemyBlockTxT.text = CardManager.instance.EnemyBlock.ToString();
            phase_Material.color = new Color(1f, 0f, 0f);
            enemyPhase = "attack";
        }
    }
}
