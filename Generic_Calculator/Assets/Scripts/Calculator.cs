using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] GameObject textGameObject;
    Text textComponent;

    [SerializeField] private float num1 = 0;
    [SerializeField] private float num2 = 0;
    [SerializeField] private char operationSign = 'n';
    [SerializeField] private bool isProcessed = false;
    private bool getPercentage = false;

    private void Awake()
    {
        textComponent = textGameObject.GetComponent<Text>();
    }

    private void Start()
    {
        textComponent.text = num1.ToString();
    }

    // Button Methods Section
    public void ButtonC()
    {
        num1 = 0;
        num2 = 0;
        textComponent.text = num1.ToString();
        isProcessed = false;
        getPercentage = false;
        operationSign = 'n';
    }

    //Basic Operations
    private void GetFirstNumber()
    {
        num1 = float.Parse(textComponent.text);
    }

    private void GetSecondNumber()
    {
        if (!getPercentage)
        {
            num2 = float.Parse(textComponent.text);
        }
        else
        {
            num2 = float.Parse(textComponent.text) / 100;
            getPercentage = false;
        }
    }

    private void Calculate(float operation)
    {
        num1 = operation;
        num2 = 0;
        textComponent.text = num1.ToString();
        isProcessed = true;
        operationSign = 'n';
    }

    public void ButtonEquals()
    {
        GetSecondNumber();
        
        switch (operationSign)
        {
            case 'n':
                break;

            case '+':
                Calculate(num1 + num2);
                break;

            case '-':
                Calculate(num1 - num2);
                break;

            case '*':
                Calculate(num1 * num2);
                break;

            case '/':
                Calculate(num1 / num2);
                break;
        }
    }

    private void BasicOperation(char sign)
    {
        if (operationSign == 'n')
        {
            GetFirstNumber();
            operationSign = sign;
            isProcessed = true;
        }
        else
        {
            ButtonEquals();
            operationSign = sign;
        }
    }

    public void ButtonPlus()
    {
        BasicOperation('+');
    }

    public void ButtonMinus()
    {
        BasicOperation('-');        
    }

    public void ButtonDivide()
    {
        BasicOperation('/');        
    }

    public void ButtonMultiply()
    {
        BasicOperation('*');        
    }

    //Special Operations   
    private void SpecialOperation(float operation)
    {
        num1 = operation;
        textComponent.text = num1.ToString();
        isProcessed = true;
    }

    public void ButtonX2()
    {
        GetFirstNumber();
        SpecialOperation(num1 * num1);
    }

    public void ButtonSqrt()
    {
        GetFirstNumber();
        SpecialOperation(Mathf.Sqrt(num1));
    }

    public void ButtonReverseNumber()
    {
        GetFirstNumber();
        SpecialOperation(1 / num1);
    }

    public void ButtonPercentage()
    {
        if (num1 == 0)
        {
            ButtonC();
        }
        else
        {
            getPercentage = true;
            ButtonEquals();
        }
    }

    // Symbols
    public void ButtonDot()
    {
        if (!textComponent.text.Contains("."))
        {
            textComponent.text += ".";
            isProcessed = false;
        }        
    }

    public void ButtonPlusMinus()
    {
        if (textComponent.text == "0") { return; }

        if (!textComponent.text.Contains("-"))
        {
            textComponent.text = "-" + textComponent.text;
            isProcessed = false;
        }        
        else
        {
            textComponent.text = textComponent.text.Substring(1);
            isProcessed = false;
        }
    }

    public void ButtonBackspace()
    {
        if (textComponent.text == "0") { return; }

        if (textComponent.text.Length > 1)
        {
            textComponent.text = textComponent.text.Substring(0, textComponent.text.Length - 1);
            isProcessed = false;
        }
        else
        {
            textComponent.text = "0";
            isProcessed = false;
        }
    }

    // Numbers
    private void PrintNumber(string number)
    {
        if (textComponent.text != "0" && !isProcessed)
        {
            textComponent.text += number;
        }
        else
        {
            textComponent.text = number;
            isProcessed = false;
        }
    }

    public void Button0()
    {
        PrintNumber("0");
    }

    public void Button1()
    {
        PrintNumber("1");
    }

    public void Button2()
    {
        PrintNumber("2");
    }

    public void Button3()
    {
        PrintNumber("3");
    }

    public void Button4()
    {
        PrintNumber("4");
    }

    public void Button5()
    {
        PrintNumber("5");
    }

    public void Button6()
    {
        PrintNumber("6");
    }

    public void Button7()
    {
        PrintNumber("7");
    }

    public void Button8()
    {
        PrintNumber("8");
    }

    public void Button9()
    {
        PrintNumber("9");
    }
}
