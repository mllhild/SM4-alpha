using System.Collections;
using System.Collections.Generic;
using System.Resources;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class UIControler : MonoBehaviour
{
    public static UIControler instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            ErrorLogger.LogErrorInFile("Error in UIControler");
            Destroy(gameObject);   
        }
    }
    
    
    
    public void ShowUiGeneralEvent()
    {
        HideAllUi();
        UIElementsGeneral.instance.ShowBaseUI();
        
    }

    public void ShowUiHouse()
    {
        HideAllUi();
        UIElementsHouse.instance.ShowBaseUi();
    }

    public void ShowMap()
    {
        HideAllUi();
        UIElementsMap.instance.mardukane.SetActive(true);
    }
    
    public void HideAllUi()
    {
        UIElementsGeneral.instance.HideUI();
        UIElementsHouse.instance.HideUi();
        UIElementsMap.instance.HideUI();
    }
    
    
}
