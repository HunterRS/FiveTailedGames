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
    public Transform canvas;
    public GameObject[] animaArrayTemp;
    public static GameObject[] animaArray;

    [SerializeField] private GameObject HandArea;

    [SerializeField] private Transform DiscardParent;
    [SerializeField] private Transform HandParent;
    [SerializeField] private Transform DeckParent;

    [SerializeField]    private List<Card> StartDeckList = new List<Card>();
    [SerializeField]    private List<Card> CardList = new List<Card>();

    public List<Card> CurrentDeckList = new List<Card>();

    public List<Card> DrawDeckList = new List<Card>();
    public List<Card> HandList = new List<Card>();
    public List<Card> Discard = new List<Card>();
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
    public void DrawCard(int CardAmount)
    {
        for (int i = 0; i < CardAmount; i++)
        {
            if (CurrentDeckList.Count == 0)
            {
                ReshuffleDeck();
            }
            NewCard = CurrentDeckList[Random.Range(1, CurrentDeckList.Count)];
            NewCard.transform.SetParent(HandParent);
            CurrentDeckList.Remove(NewCard);
            HandList.Add(NewCard);
            NewCard.transform.localRotation = Quaternion.Euler(0, 180, 0);
            NewCard.transform.localPosition = new Vector3(0, 0, 0);
        }
    }
    public void MoveToDiscard(Card DiscardCard)
    {
        HandList.Remove(DiscardCard);
        Discard.Add(DiscardCard);
        DiscardCard.transform.SetParent(DiscardParent);
        DiscardCard.transform.localPosition = new Vector3(0, 0, 0);
    }
    public void ReshuffleDeck()
    {
        foreach (Card DiscardedCard in Discard)
        {
            CurrentDeckList.Add(DiscardedCard);
            DiscardedCard.transform.SetParent(DeckParent);
            DiscardedCard.transform.localPosition = new Vector3(0, 0, 0);
        }
        Discard.Clear();
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
