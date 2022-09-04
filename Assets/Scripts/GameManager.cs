using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public int cardsDrawn;
    public int cardsToDraw = 11;
    public int cardsOnDiscard;
    public Player[] players;
    public int turn;

    public Text turnText;
    private void Start()
    {
        players = FindObjectsOfType<Player>();
        if (turn == 0)
        {
            startGame();
        }
    }
    private void Update()
    {
        turnText.text = ("Turns: " + turn).ToString();
    }
    private void startGame()
    {
        //Lets draw 11 cards for all players
        for (int i = 0; i < players.Length; i++)
        {
            for (int x = 0; x < cardsToDraw; x++)
            {
                players[i].DrawCards();
            }
        }
        turn++;
    }
}
