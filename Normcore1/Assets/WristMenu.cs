using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WristMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wristUI;
    public bool activeWristUI = true;
    
    void Start()
    {
        DisplayWirstUI();
    }

    // Update is called once per frame
    public void MenuPressed(InputAction.CallbackContext context)
    {

    }
    public void DisplayWirstUI()
    {
        if (activeWristUI)
        {
            wristUI.SetActive(false);
            activeWristUI = false;
        }
        else if(activeWristUI)
        {
            wristUI.SetActive(true);
            activeWristUI = true;
        }
    }
}
