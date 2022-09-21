using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public static CardManager instance;

    public Card Card;                   // Card Variable to 
    public static Card[] cardArray;     // Array of all cards
    public Card[] cardArrayTemp;     // Array of all cards
    public int CardNum;                 // Number of cards (Increase when we add more)
    private Card placeholder;
    private Card NewCard;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        cardArray = new Card[CardNum]; // creates Arrays with number of entries equal to cardNum
        for (int i = 0; i < CardNum; i++)
        {
            Debug.Log(cardArray[i]);
            Debug.Log(cardArrayTemp[i]);
            cardArray[i] = cardArrayTemp[i];
        }

        for (int i = 0; i < 3; i++)
        {
            NewCard = cardArray[Random.Range(0, cardArray.Length)];
            Instantiate(NewCard, new Vector2(i* 40-40, 0), Quaternion.identity);    // creates card, attaching it to placeholder.
        }
    }

    // Update is called once per frame
        void Update()
    {
        
    }
}
