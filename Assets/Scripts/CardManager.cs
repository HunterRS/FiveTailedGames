using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardManager : MonoBehaviour
{
    public static CardManager instance;

    private Card placeholder;
    private Card NewCard;

    [Header("UI Elements")]
    public Transform canvas;
    public GameObject[] animaArrayTemp;
    public static GameObject[] animaArray;

    [Header("UI Parents")]
    [SerializeField] private GameObject HandArea;
    [SerializeField] private Transform DiscardParent;
    [SerializeField] private Transform HandParent;
    [SerializeField] private Transform DeckParent;
    [SerializeField] private Transform SelectionParent;
    [SerializeField] public Transform startDeckParent;

    [Header("Card Lists")]
    [SerializeField]    private List<Card> StartDeckList = new List<Card>();
    [SerializeField]    private List<Card> CardList = new List<Card>();
    public List<Card> CurrentDeckList = new List<Card>();
    public List<Card> battleDeckList = new List<Card>();
    public List<Card> HandList = new List<Card>();
    public List<Card> Discard = new List<Card>();

    [Header("Post Battle UI")]
    [SerializeField] private GameObject selectionUI;
    public Card[] selectionCards;
    public bool selection = false;
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
        for (int i = 0; i < StartDeckList.Count; i++)
        {
            CurrentDeckList.Add(StartDeckList[i]);
        }

    }
    public void CreateBattleDeck()
    {
        for (int i = 0; i < CurrentDeckList.Count; i++)
        {
            NewCard = Instantiate(CurrentDeckList[i], new Vector3(0, 0, 0), Quaternion.identity);
            NewCard.transform.SetParent(DeckParent);
            battleDeckList.Add(NewCard);

        }
    }
    public void DrawCard(int CardAmount)
    {
        Debug.Log(battleDeckList.Count);
        for (int i = 0; i < CardAmount; i++)
        {
            if (battleDeckList.Count == 0)
            {
                ReshuffleDeck();
                if (battleDeckList.Count == 0 && Discard.Count == 0 && HandList.Count == 0)
                {
                    Camera.main.GetComponent<Animator>().enabled = true;
                }
                else
                {
                    return;
                }
            }
            NewCard = battleDeckList[Random.Range(0, battleDeckList.Count)];
            NewCard.transform.SetParent(HandParent);
            battleDeckList.Remove(NewCard);
            HandList.Add(NewCard);
            NewCard.transform.localRotation = Quaternion.Euler(0, 180, 0);
            NewCard.transform.localPosition = new Vector3(0, 0, 0);
            NewCard.transform.localScale = new Vector3(.2f,.2f,.2f);
        }
    }

    public void MoveToDiscard(Card DiscardCard)
    {
        HandList.Remove(DiscardCard);
        Discard.Add(DiscardCard);
        DiscardCard.transform.SetParent(DiscardParent);
        DiscardCard.transform.localPosition = new Vector3(0, 0, 0);
    }
    public void DiscardHand()
    {
        foreach (Card HandCard in HandList)
        {
            Discard.Add(HandCard);
            HandCard.transform.SetParent(HandParent);
            HandCard.transform.localPosition = new Vector3(0, 0, 0);
        }
        HandList.Clear();
    }
    public void ReshuffleDeck()
    {
        Debug.Log(Discard.Count);
        foreach (Card DiscardedCard in Discard)
        {
            battleDeckList.Add(DiscardedCard);
            DiscardedCard.transform.SetParent(DeckParent);
            DiscardedCard.transform.localPosition = new Vector3(0, 0, 0);
        }
        Discard.Clear();
    }
    public static void AnimaChange()
    {
        for (int i = 0; i < animaArray.Length; i++)
        {
            if (GameManager.instance.Anima > i && animaArray[i].active == false)
            {
                animaArray[i].SetActive(true);
                animaArray[i].GetComponent<AnimaScript>().Reset();
                animaArray[i].GetComponent<AnimaScript>().VelReset();
            }
            if (GameManager.instance.Anima <= i)
            {
                animaArray[i].SetActive(false);
            }
        }

    }
    public void StartSelection()
    {
        GameManager.instance.BattleCamera.SetActive(false);
        selectionUI.SetActive(true);
        NewCard = Instantiate(CardList[Random.Range(0, CardList.Count)], new Vector3( 0,0,0), Quaternion.identity);
        NewCard.transform.SetParent(SelectionParent);
        NewCard.transform.localPosition = new Vector3(0, 0, 0);
        NewCard.transform.localScale = new Vector3(1f, 1f, 1f);
        NewCard.transform.localRotation = Quaternion.Euler(0, 180, 0);
        selectionCards[0] = NewCard;
        NewCard = CardList[Random.Range(0, CardList.Count)];
        while (NewCard.ID == selectionCards[0].ID)
        {
            NewCard = CardList[Random.Range(0, CardList.Count)];
        }
        NewCard = Instantiate(NewCard, new Vector3(0, 0, 0), Quaternion.identity);
        NewCard.transform.SetParent(SelectionParent);
        NewCard.transform.localPosition = new Vector3(0, 0, 0);
        NewCard.transform.localScale = new Vector3(1f, 1f, 1f);
        NewCard.transform.localRotation = Quaternion.Euler(0, 180, 0);
        selectionCards[1] = NewCard;
        NewCard = CardList[Random.Range(0, CardList.Count)];
        while (NewCard.ID == selectionCards[0].ID || NewCard.ID == selectionCards[1].ID)
        {
            NewCard = CardList[Random.Range(0, CardList.Count)];
        }
        NewCard = Instantiate(NewCard, new Vector3(0, 0, 0), Quaternion.identity);
        NewCard.transform.SetParent(SelectionParent);
        NewCard.transform.localPosition = new Vector3(0, 0, 0);
        NewCard.transform.localScale = new Vector3(1f, 1f, 1f);
        NewCard.transform.localRotation = Quaternion.Euler(0, 180, 0);
        selectionCards[2] = NewCard;

        selection = true;
    }
    public void EndSelection()
    {
        foreach (Transform child in HandParent)
        {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Transform child in DeckParent)
        {
            GameObject.Destroy(child.gameObject);
        }
        selectionUI.SetActive(false);
        GameManager.instance.gameState = "move";
    }
}
