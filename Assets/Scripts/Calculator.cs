using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{

    public Text Result;
    public Text Operation;
    public InputField ipfnumber1;
    public InputField ipfnumber2;
    public Button add;

    public float varA;
    public float varB;
    public float varC;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Addition ()
    {

        varA = float.Parse(ipfnumber1.text);
        varB = float.Parse(ipfnumber2.text);

        float varAdd = varA + varB;

        Operation.text = "+";
        Result.text = varAdd.ToString();
    }

    public void Subtraction()
    {

        varA = float.Parse(ipfnumber1.text);
        varB = float.Parse(ipfnumber2.text);

        float varSub = varA - varB;

        Debug.Log("Result= " + varSub.ToString());

        Operation.text = "-";
        Result.text = varSub.ToString();
    }

    public void Multiplication()
    {

        varA = float.Parse(ipfnumber1.text);
        varB = float.Parse(ipfnumber2.text);

        float varMul = varA * varB;

        Debug.Log("Result= " + varMul.ToString());

        Operation.text = "times";
        Result.text = varMul.ToString();
    }

    public void Division()
    {

        varA = float.Parse(ipfnumber1.text);
        varB = float.Parse(ipfnumber2.text);

        float varDiv = varA / varB;

        Debug.Log("Result= " + varDiv.ToString());

        Operation.text = "by";
        Result.text = varDiv.ToString();
    }

    public void PercentInput()
    {
        varA = float.Parse(ipfnumber1.text);
        varB = float.Parse(ipfnumber2.text);

        varC = PercentOutput(varA, varB);

        Operation.text = "is Percentage of";
        Result.text = varC.ToString() + "%";
    }

    private float PercentOutput(float varPerA,float varPerB)
    {
        float varPer = varPerB * 100 / varPerA;

        return(varPer);
    }


}
