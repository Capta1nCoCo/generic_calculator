using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] GameObject textGameObject;
    Text textComponent;

    [SerializeField] float num1 = 0;
    [SerializeField] float num2 = 0;
    [SerializeField] char operationSign = 'n';
    [SerializeField] bool isProcessed = false;

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
        operationSign = 'n';
    }

    //Operations
    public void ButtonEquals()
    {
        num2 = float.Parse(textComponent.text);
        
        switch (operationSign)
        {
            case 'n':
                break;

            case '+':
                num1 += num2;
                num2 = 0;
                textComponent.text = num1.ToString();
                isProcessed = true;
                operationSign = 'n';
                break;

            case '-':
                num1 -= num2;
                num2 = 0;
                textComponent.text = num1.ToString();
                isProcessed = true;
                operationSign = 'n';
                break;

            case '*':
                num1 *= num2;
                num2 = 0;
                textComponent.text = num1.ToString();
                isProcessed = true;
                operationSign = 'n';
                break;

            case '/':
                num1 /= num2;
                num2 = 0;
                textComponent.text = num1.ToString();
                isProcessed = true;
                operationSign = 'n';
                break;
        }
    }

    public void ButtonPlus()
    {
        
        if (operationSign == 'n')
        {
            num1 = float.Parse(textComponent.text);
            operationSign = '+';
            isProcessed = true;
        }
        else
        {
            operationSign = '+';
            ButtonEquals();
        }
    }

    public void ButtonMinus()
    {
        if (operationSign == 'n')
        {
            num1 = float.Parse(textComponent.text);
            operationSign = '-';
            isProcessed = true;
        }
        else
        {
            operationSign = '-';
            ButtonEquals();
        }
    }

    public void ButtonDivide()
    {
        if (operationSign == 'n')
        {
            num1 = float.Parse(textComponent.text);
            operationSign = '/';
            isProcessed = true;
        }
        else
        {
            operationSign = '/';
            ButtonEquals();
        }
    }

    public void ButtonMultiply()
    {
        if (operationSign == 'n')
        {
            num1 = float.Parse(textComponent.text);
            operationSign = '*';
            isProcessed = true;
        }
        else
        {
            operationSign = '*';
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

    // Numbers
    public void Button0()
    {
        if (textComponent.text != "0" && !isProcessed)
        {
            textComponent.text += "0";
        }
        else
        {
            textComponent.text = "0";
            isProcessed = false;
        }

    }

    public void Button1()
    {
        if (textComponent.text != "0" && !isProcessed)
        {
            textComponent.text += "1";
        }
        else
        {
            textComponent.text = "1";
            isProcessed = false;
        }
        
    }

    public void Button2()
    {
        if (textComponent.text != "0" && !isProcessed)
        {
            textComponent.text += "2";
        }
        else
        {
            textComponent.text = "2";
            isProcessed = false;
        }

    }

    public void Button3()
    {
        if (textComponent.text != "0" && !isProcessed)
        {
            textComponent.text += "3";
        }
        else
        {
            textComponent.text = "3";
            isProcessed = false;
        }

    }

    public void Button4()
    {
        if (textComponent.text != "0" && !isProcessed)
        {
            textComponent.text += "4";
        }
        else
        {
            textComponent.text = "4";
            isProcessed = false;
        }

    }

    public void Button5()
    {
        if (textComponent.text != "0" && !isProcessed)
        {
            textComponent.text += "5";
        }
        else
        {
            textComponent.text = "5";
            isProcessed = false;
        }

    }

    public void Button6()
    {
        if (textComponent.text != "0" && !isProcessed)
        {
            textComponent.text += "6";
        }
        else
        {
            textComponent.text = "6";
            isProcessed = false;
        }

    }

    public void Button7()
    {
        if (textComponent.text != "0" && !isProcessed)
        {
            textComponent.text += "7";
        }
        else
        {
            textComponent.text = "7";
            isProcessed = false;
        }

    }

    public void Button8()
    {
        if (textComponent.text != "0" && !isProcessed)
        {
            textComponent.text += "8";
        }
        else
        {
            textComponent.text = "8";
            isProcessed = false;
        }

    }

    public void Button9()
    {
        if (textComponent.text != "0" && !isProcessed)
        {
            textComponent.text += "9";
        }
        else
        {
            textComponent.text = "9";
            isProcessed = false;
        }

    }
}
