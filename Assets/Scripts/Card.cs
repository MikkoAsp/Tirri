using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public bool hasBeenPlayed;
    public int handIndex;
    public Transform discardPile;
    private SpriteRenderer spriteRenderer;

    private GameManager gm;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gm = FindObjectOfType<GameManager>();
    }
    void OnMouseDown()
    {
        if(hasBeenPlayed == false)
        {
            //Changing rendering order based on amount of cards in discard pile
            gm.cardsOnDiscard++;
            spriteRenderer.sortingOrder = gm.cardsOnDiscard;
            //Moving the card to discard pile
            transform.position = discardPile.transform.position;
            transform.rotation = discardPile.transform.rotation;
            hasBeenPlayed = true;
            //gm.players[x].cardSlots[handIndex] = true;
        }
     }
}
