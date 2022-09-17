using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public static CardManager instance;

    public Card Card;                   // Card Variable to 
    public static Card[] cardArray;     // Array of all cards
    public int CardNum;                 // Number of cards (Increase when we add more)
    private Card placeholder;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        cardArray = new Card[CardNum]; // creates Arrays with number of entries equal to cardNum
        placeholder = (Card)Instantiate(Card, new Vector2(1.0f, 1.0f), Quaternion.identity);    // creates card, attaching it to placeholder.
        cardArray[0] = placeholder;         // pushes placeholder into array
        Card.Destroy(placeholder);           // deletes placeholder, so card data is still stored in cardArray
    }

    // Update is called once per frame
        void Update()
    {
        
    }
}
