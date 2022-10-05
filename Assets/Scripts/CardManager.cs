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
            if (GameManager.instance.Anima >= i && animaArray[i].active == false)
            {
                animaArray[i].GetComponent<AnimaScript>().Reset();
                animaArray[i].SetActive(true);
                animaArray[i].GetComponent<AnimaScript>().VelReset();


            }
            if (GameManager.instance.Anima <= i)
            {
                animaArray[i].SetActive(false);
            }
        }

    }
    public void endTurn()
    {
        if (enemyPhase == "attack")
        {
            if (GameManager.instance.PlayerBlock > 1)
            {
                int tempvalue = 3 - GameManager.instance.PlayerBlock;
                if (tempvalue > 0)
                {
                    GameManager.instance.PlayerHealth = GameManager.instance.PlayerHealth - tempvalue;
                    UIManager.instance.PlayerHealthTxT.text = GameManager.instance.PlayerHealth.ToString();
                    GameManager.instance.PlayerBlock = 0;
                    UIManager.instance.PlayerBlockTxT.text = GameManager.instance.PlayerBlock.ToString();
                }
                else if (tempvalue < 0)
                {
                    GameManager.instance.PlayerBlock = GameManager.instance.PlayerBlock - 3;
                    UIManager.instance.PlayerBlockTxT.text = GameManager.instance.PlayerBlock.ToString();
                }
                else
                {
                    GameManager.instance.PlayerBlock = 0;
                    UIManager.instance.PlayerBlockTxT.text = GameManager.instance.PlayerBlock.ToString();
                }
            }
            else
            {
                GameManager.instance.PlayerHealth = GameManager.instance.PlayerHealth - 3;
                UIManager.instance.PlayerHealthTxT.text = GameManager.instance.PlayerHealth.ToString();
            }

            phase_Material.color = new Color(0f, 0f, 1f);
            enemyPhase = "block";
        }
        else
        {
            GameManager.instance.EnemyBlock = GameManager.instance.EnemyBlock + 3;
            UIManager.instance.EnemyBlockTxT.text = GameManager.instance.EnemyBlock.ToString();
            phase_Material.color = new Color(1f, 0f, 0f);
            enemyPhase = "attack";
        }
    }
}
