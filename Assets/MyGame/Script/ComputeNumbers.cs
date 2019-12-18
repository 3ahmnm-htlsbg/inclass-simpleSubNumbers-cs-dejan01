using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public Text result;
    public InputField varA;
    public InputField varB;
    public Button Button_reset;
    public Button Button_SubNumbers;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private int SubNumbers()
    {
        int a = int.Parse(varA.text);
        int b = int.Parse(varB.text);
        Debug.Log("result" + (a-b));
        return a - b;
    }

    public void SetResult(){
        result.text = SubNumbers().ToString();
        varA.interactable = false;
        varB.interactable = false;
        Button_SubNumbers.interactable = false;
        Button_reset.interactable = true;
    }

    public void ResetGui(){
        result.text = "Result";   
        varA.text = "0";
        varB.text = "0";
        varA.interactable = true;
        varB.interactable = true;
        Button_SubNumbers.interactable = true;
        Button_reset.interactable = false;
    }
}
