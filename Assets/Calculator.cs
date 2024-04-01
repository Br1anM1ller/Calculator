using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Calculator : MonoBehaviour
{
    public InputField FirstNumberInputField;
    public InputField TwoNumberInputField;
    public Text result;


    public void Plus()
    {
        int a, b, c;
        a = int.Parse(FirstNumberInputField.text);
        b = int.Parse(TwoNumberInputField.text);
        c = a + b;


        result.text = c.ToString();

    }

    public void Minus()
    {
        int a, b, c;
        a = int.Parse(FirstNumberInputField.text);
        b = int.Parse(TwoNumberInputField.text);
        c = a - b;

        result.text = c.ToString();
    }

    public void Multiplication()
    {
        int a, b, c;
        a = int.Parse(FirstNumberInputField.text);
        b = int.Parse(TwoNumberInputField.text);
        c = a * b;

        result.text = c.ToString();
    }

    public void Division()
    {
        int a, b, c;

        if (int.TryParse(FirstNumberInputField.text, out a) && int.TryParse(TwoNumberInputField.text, out b))
        {
            if (b != 0)
            {
                c = a / b;
                result.text = c.ToString();
            }
            else
            {
                result.text = "Ошибка";
            }
        }
        else
        {
            result.text = "Ошибка";
        }
    }


}
