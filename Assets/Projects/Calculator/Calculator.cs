using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculator : MonoBehaviour
{
    [SerializeField] private TMP_Text resultText;
    [SerializeField] private TMP_InputField firstNumberInput;
    [SerializeField] private TMP_InputField secondNumberInput;

    public void Add()
    {
        float.TryParse(firstNumberInput.text, out float firstNumber);
        float.TryParse(secondNumberInput.text, out float secondNumber);
        float result = firstNumber + secondNumber;
        resultText.text = "Result = " + result;
    }

    public void Subtract()
    {
        float.TryParse(firstNumberInput.text, out float firstNumber);
        float.TryParse(secondNumberInput.text, out float secondNumber);
        float result = firstNumber - secondNumber;
        resultText.text = "Result = " + result;
    }

    public void Multiply()
    {
        float.TryParse(firstNumberInput.text, out float firstNumber);
        float.TryParse(secondNumberInput.text, out float secondNumber);
        float result = firstNumber * secondNumber;
        resultText.text = "Result = " + result;
    }

    public void Divide()
    {
        float.TryParse(firstNumberInput.text, out float firstNumber);
        float.TryParse(secondNumberInput.text, out float secondNumber);
        float result = firstNumber / secondNumber;
        resultText.text = "Result = " + result;
    }
}
