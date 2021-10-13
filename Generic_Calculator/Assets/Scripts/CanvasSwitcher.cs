using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject portraitCanvas;
    [SerializeField] private GameObject landscapeCanvas;
    private Calculator calculator;

    private float delayInSeconds = 1;    
    private bool isPortrait;

    private void Awake()
    {
        calculator = FindObjectOfType<Calculator>();
    }

    void Update()
    {
        if (Input.deviceOrientation == DeviceOrientation.Portrait || Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
        {
            isPortrait = true;
            StartCoroutine(SwitchCanvasWithDelay());
        }
        else if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        {
            isPortrait = false;
            StartCoroutine(SwitchCanvasWithDelay());
        }
    }

    private IEnumerator SwitchCanvasWithDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        if (isPortrait)
        {
            calculator.CacheCurrentText();
            landscapeCanvas.SetActive(false);
            portraitCanvas.SetActive(true);
            calculator.AccessTextPortrait();
        }
        else
        {
            calculator.CacheCurrentText();
            portraitCanvas.SetActive(false);
            landscapeCanvas.SetActive(true);
            calculator.AccessTextLandscape();
        }
    }   

}
