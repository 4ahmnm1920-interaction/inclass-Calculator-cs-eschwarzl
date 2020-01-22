using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class excersiseReturnValue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        float floatvariableA = 5;
        float floatvariableB = 6;

        float floatvariableC = FloatOutput(floatvariableA, floatvariableB);

        Debug.Log("Float = " + floatvariableC);

        int intvariableA = 5;
        int intvariableB = 6;

        int intvariableC = IntOutput(intvariableA, intvariableB);

        Debug.Log("Int = " + intvariableC);



        Int(4, 5);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Random.Range(3f,20f) + Random.Range(2f,50f));
    }

    public void Int(int A, int B)
    {
        int NumberA = A;
        int NumberB = B;

        Debug.Log("Ohne = " + A * B);
    }


    private int IntOutput(int varIntA, int varIntB)
    {
        int IntReturn = varIntA + varIntB;

        return (IntReturn);
  
    }

    private float FloatOutput(float varFloatA, float varFloatB)
    {
        float FloatReturn = varFloatA / varFloatB;

        return (FloatReturn);

    }

}
