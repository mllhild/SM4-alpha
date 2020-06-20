using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SM4NextEventButton : MonoBehaviour
{
    
    public static SM4NextEventButton instance = null;
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
    
    
    public Button button;
    public TextMeshProUGUI label;
    public SM4Event sm4Event;

    public void StoreNextEvent(SM4Event nextSm4Event)
    {
        sm4Event = nextSm4Event;
    }

    public void DoStoredEvent()
    {
        if (sm4Event != null)
        {
            SM4EventExecute.instance.ExecuteEvent(sm4Event);
            sm4Event = null;
        }
        else
        {
            World.instance.Turn();
        }
            
        
    }

    public void SetLabel(string newLabel)
    {
        label.text = newLabel;
    }
    public void HideButton()
    {
        this.gameObject.SetActive(false);
    }

    public void ChangeOnClickFunctionTo(string newFunction)
    {
        newFunction = newFunction.ToLower();
        button.onClick.RemoveAllListeners();
        switch (newFunction)
        {
            case "event":
                button.onClick.AddListener(UIControler.instance.ShowUiGeneralEvent);
                break;
            case "house":
                button.onClick.AddListener(UIControler.instance.ShowUiHouse);
                break;
            case "map":
                button.onClick.AddListener(UIControler.instance.ShowMap);
                break;
            case "next":
                button.onClick.AddListener(DoStoredEvent);
                break;
            default:
                button.onClick.AddListener(DoStoredEvent);
                break;
            
        }
    }
    


}
