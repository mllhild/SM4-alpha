using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIElementsMap : MonoBehaviour
{
    public static UIElementsMap instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            ErrorLogger.LogErrorInFile("Error in " + this.name);
            Destroy(gameObject);   
        }
    }

    public GameObject mardukane;

    public void HideUI()
    {
        mardukane.SetActive(false);
    }
}
