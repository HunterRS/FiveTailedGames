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

    [SerializeField] private GameObject HandArea;

    [SerializeField]    private List<Card> StartDeckList = new List<Card>();
    [SerializeField]    private List<Card> CardList = new List<Card>();
    [HideInInspector]   public List<Card> CurrentDeckList = new List<Card>();

    [HideInInspector] public List<Card> CurrentBattleDeckList = new List<Card>();
    [HideInInspector]   public List<Card> HandList = new List<Card>();
    [HideInInspector]   public List<Card> Discard = new List<Card>();
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
    }

    // Update is called once per frame
        void Update()
    {
        
    }

    public void DeckCreate()
    {
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


    }
    public void DrawCard(int CardAmount)
    {
        for (int i = 0; i < CardAmount; i++)
        {
            NewCard = cardArray[Random.Range(0, cardArray.Length)];
            NewCard = Instantiate(NewCard, new Vector3(canvas.position.x, canvas.position.y, canvas.position.z), Quaternion.identity, canvas.transform);
            NewCard.transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
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
}
