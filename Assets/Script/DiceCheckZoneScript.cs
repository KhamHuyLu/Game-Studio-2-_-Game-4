using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZoneScript : MonoBehaviour
{

	Vector3 diceVelocity;

	// Update is called once per frame
	void FixedUpdate()
	{
		diceVelocity = DiceScript.diceVelocity;
	}

	void OnTriggerStay(Collider col)
	{
		DiceScript colliderDice = col.transform.parent.GetComponent<DiceScript>();
		if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
		{
			switch (col.gameObject.name)
			{
				case "Side1":
					colliderDice.diceText.tmpText.text = "Cat";
					colliderDice.diceText.diceNumber = 6;
					break;
				case "Side2":
					colliderDice.diceText.tmpText.text = "Shrimp";
					colliderDice.diceText.diceNumber = 5;
					break;
				case "Side3":
					colliderDice.diceText.tmpText.text = "Fish";
					colliderDice.diceText.diceNumber = 4;
					break;
				case "Side4":
					colliderDice.diceText.tmpText.text = "Gourd";
					colliderDice.diceText.diceNumber = 3;
					break;
				case "Side5":
					colliderDice.diceText.tmpText.text = "Crab";
					colliderDice.diceText.diceNumber = 2;
					break;
				case "Side6":
					colliderDice.diceText.tmpText.text = "Deer";
					colliderDice.diceText.diceNumber = 1;
					break;
			}
		}
	}
}




