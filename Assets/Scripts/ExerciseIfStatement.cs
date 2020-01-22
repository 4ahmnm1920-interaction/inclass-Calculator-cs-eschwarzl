using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseIfStatement : MonoBehaviour
{

    public bool condition;
    // Start is called before the first frame update
    void Start()
    {
        if (condition)
        {
            Debug.Log("Diese Bedingung stimmt.");
        }
        else
        {
            Debug.Log("Diese Bedingung ist falsch");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
