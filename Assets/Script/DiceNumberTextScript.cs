using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceNumberTextScript : MonoBehaviour
{
    private Text text;
    public TextMeshProUGUI tmpText;
    public int diceNumber;
    private bool diceRolled = false;

    private void Start()
    {
        text = GetComponent<Text>();
        tmpText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (diceRolled)
        {
            if (text != null)
            {
                text.text = diceNumber.ToString();
            }
            else if (tmpText != null)
            {
                tmpText.text = diceNumber.ToString();
            }
            else
            {
                Debug.LogError("No text component found on game object.");
            }
        }
    }

    public void SetDiceRolled(bool value)
    {
        diceRolled = value;
    }
}