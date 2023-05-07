using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    public Rigidbody rb { get; private set; }
    public static Vector3 diceVelocity;
    public Vector3 initialPosition;
    public Quaternion initialRotation;

    public DiceNumberTextScript diceText;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetupDice();
        
    }

    private void Update()
    {
        diceVelocity = rb.velocity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
        }
    }

    public void SetupDice()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = initialPosition;
        transform.rotation = initialRotation;
    }

    public void RollDice()
    {
        
        diceText.diceNumber = 0;
        float dirX = Random.Range(0, 500);
        float dirY = Random.Range(0, 500);
        float dirZ = Random.Range(0, 500);
        rb.AddForce(transform.up * 500);
        rb.AddTorque(dirX, dirY, dirZ);
    }

    
}
