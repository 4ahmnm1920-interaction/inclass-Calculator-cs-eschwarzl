using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseIfStatement : MonoBehaviour
{

    public bool condition;
    public string Text;
    public string Text2;
    public float KleineZahl;
    public string NewText;
    // Start is called before the first frame update
    void Start()
    {
       // if (condition)
        {
            Debug.Log("Diese Bedingung stimmt.");
        }
       // else
        {
            Debug.Log("Diese Bedingung ist falsch");
        }
    }

    // Update is called once per frame
    void Update()
    {

        // If Float Values
        var a = Random.Range(5f, 15f);

        if (a > 10)
        {
           // Debug.Log("Wert ist größer als 10");
        }
        else
        {
            //Debug.Log("Wert ist kleiner als 10");
        }

        // If Statement String Values
       if (Text == Text2)
        {
            //Debug.Log("Text1 entspricht Text2");
        }
       else
        {
           // Debug.Log("Text1 entspricht NICHT Text2");
        }

       // If statement mit mehreren Conditionen
       // Mit dem  && (und) Operator - Beide müssen Richtig sein

        if (Text == Text2 && condition)
        {
            //Debug.Log("Beide Konditionen sind richtig");
        }

        // Mit dem  || (oder) Operator - Einer der beiden muss Richtig sein
        if (Text == Text2 || condition)
        {
            //Debug.Log("Einer der beiden Konditionen ist richtig");
        }

       
        //Verschachtelte If Statements
        var b = Random.Range(5f, 15f);

        if (b > 10)
        {
            if (NewText == "Zehn")
            {
                Debug.Log("Zahl größer Zehn und Text Zehn");
            }
            Debug.Log("Zahl größer als 10");
        }

    }
}
