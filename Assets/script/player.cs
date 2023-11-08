using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to control the movement speed.
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Witam();

         rb = GetComponent<Rigidbody2D>();
         Debug.Log (Suma(2,3));
        
    }
   
    // Update is called once per frame
    void Update()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized;
        // normalizowanie wektora to sprowadzenie go do postaci takiej aby miał długość 1

        // Apply movement to the Rigidbody
        rb.velocity = movement * moveSpeed;
    }
 void Witam()
    {
        Debug.Log("witam");


          

    
    }
    //napisz publiczną metode typu int która przyjmuje parametry będące zmiennymi typu int A i B, oraz zwraca sume tych zmiennych
    //napisz metode która liczy sume A i B
    public int Suma(int A, int B)
    {
        return A+B;
        
        
    }
}