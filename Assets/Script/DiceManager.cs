using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DiceManager : MonoBehaviour
{
    public List<DiceScript> dices;
    public DiceNumberTextScript diceNumberText;
    public Button rollButton;

    private bool diceRolled = false;

    private void Start()
    {
        // Add listener to roll button
        //rollButton.onClick.AddListener(RollDices);
    }

    public void RollDices()
    {
        //if (!diceRolled)
        //{
            // Reset dice number
            dices[0].diceText.diceNumber = 0;
            dices[1].diceText.diceNumber = 0;
            dices[2].diceText.diceNumber = 0;

        // Roll each dice in the list
        foreach (DiceScript dice in dices)
        {
            float dirX = Random.Range(-1000, 1000);
            float dirY = Random.Range(-1000, 1000);
            float dirZ = Random.Range(-1000, 1000);

            float forceMagnitude = Random.Range(250, 500);
            Vector3 forceDirection = new Vector3(Random.Range(-1f, 1f), 1, Random.Range(-1f, 1f)).normalized;
            Vector3 force = forceDirection * forceMagnitude;

            Vector3 startPos = new Vector3(Random.Range(-1f, 1f), 2, Random.Range(-1f, 1f)) * 5f;
            dice.transform.position = startPos;
            dice.transform.rotation = Quaternion.identity;

            dice.rb.AddForce(force);
            dice.rb.AddTorque(dirX, dirY, dirZ);
        }

        // Set the flag to true after the dice is rolled
        diceRolled = true;
            diceNumberText.SetDiceRolled(diceRolled);
        //}
    }
}