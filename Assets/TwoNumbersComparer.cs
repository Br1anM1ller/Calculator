using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TwoNumbersComparer : MonoBehaviour
{
    public InputField FirstNumberInputField;
    public InputField TwoNumberInputField;
    public Text result;

    public void Comparision()
    {
        int a = Convert.ToInt32(FirstNumberInputField.text.ToString());
        int b = Convert.ToInt32(TwoNumberInputField.text.ToString());
        bool numberWin = a > b;
        print(numberWin);

        if (a > b) result.text = $">";
        if (b > a) result.text = $"<";
        if (b == a) result.text = $"Равны";

    }
}