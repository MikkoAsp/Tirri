using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform[] cardTransforms;
    public bool[] cardSlots;
    public bool canPlay;
    public int cards;
    private GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }
    public void DrawCards()
    {
        //Card randomCard = gm.deck[2] for example
        Card randomCard = gm.deck[Random.Range(0, gm.deck.Count)];
        for (int i = 0; i < cardSlots.Length; i++)
        {
            if (cardSlots[i])
            {
                randomCard.gameObject.SetActive(true);
                randomCard.handIndex = i;

                //Assigning cards to their of slot placements
                randomCard.transform.position = cardTransforms[i].position;
                randomCard.transform.rotation = cardTransforms[i].rotation;

                //Making the slot unavailable
                cardSlots[i] = false;
                //Removing the card from deck aka the list of cards
                gm.deck.Remove(randomCard);
                //Incrementing total cards in the board and players cards
                gm.cardsDrawn++;
                cards++;
                return;
            }
        }
    }
}
