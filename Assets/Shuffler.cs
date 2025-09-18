using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //PUSH TEST PUSH TEST

    //PUSH TEST PUSH TEST

    //PUSH TEST PUSH TEST

    //PUSH TEST PUSH TEST

    public int totalCards = 52;
    public int dealCards = 5;

    private List<int> deck = new List<int>();

    void Start()
    {
        Debug.Log("Welcome to the Deck Shuffler Game!\n");

        InitializeDeck();
        ShuffleDeck();
        DealCards(dealCards);
    }

    void InitializeDeck()
    {
        deck.Clear();
        for (int i = 1; i <= totalCards; i++)
        {
            deck.Add(i);
        }
        Debug.Log("Initialized a deck of " + totalCards + " cards.\n");
    }
    void ShuffleDeck()
    {
        System.Random rand = new System.Random();
        int num = deck.Count;

        while (num > 1)
        {
            num--;
            int j = rand.Next(num + 1);
            int temp = deck[j];
            deck[j] = deck[num];
            deck[num] = temp;
        }
        Debug.Log("Deck Shuffled.\n");
    }

    void DealCards(int cardNumDeal)
    {

        if (cardNumDeal > deck.Count)
        {
            Debug.LogWarning("Not enough cards to deal!");
            cardNumDeal = deck.Count;
        }

        List<int> hand = deck.GetRange(0, cardNumDeal);

        Debug.Log("Dealt " + cardNumDeal + " cards:");
        foreach (int card in hand)
        {
            Debug.Log("Card: " + card);
        }

        deck.RemoveRange(0, cardNumDeal);
        Debug.Log(cardNumDeal + " cards removed from the deck.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
