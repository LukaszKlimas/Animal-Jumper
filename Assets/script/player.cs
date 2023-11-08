using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class player : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to control the movement speed.
    private Rigidbody2D rb;
    public int a, b;

    private int punkty=0;
    public TextMeshProUGUI punktyTxt;
    //private int wiśnie
    // Start is called before the first frame update

    void Start()
    {
        Witam();

         rb = GetComponent<Rigidbody2D>();
        Debug.Log (Suma(a,b)); 
        punktyTxt.text=punkty.ToString();
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
    public int Suma(int a, int b)
    {
        return a+b;
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wisienka")) // Zderzenie z obiektem o tagu "ObiektDoZderzenia".
        {
            punkty++; // Zwiększ ilość punktów gracza o 1.
            Debug.Log("Zdobyto punkt! Aktualna ilość punktów: " + punkty);
            punktyTxt.text=punkty.ToString();

            // Opcjonalnie, możesz tutaj dodać kod do obsługi dźwięku lub efektów wizualnych.
            // Na przykład: collision.gameObject.GetComponent<AudioSource>().Play();
            // Lub: Instantiate(efektZdobytegoPunktu, transform.position, transform.rotation);

            Destroy(collision.gameObject); // Usuń obiekt, z którym zderzył się gracz.
        }
    }


}