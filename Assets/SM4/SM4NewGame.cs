using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SM4NewGame : MonoBehaviour
{
    public Image overlay;
    public SM4CharacterPortrait portrait;
    public SM4PrefabButtonSimple01 buttonSimple;
    void Start()
    {
        
        SM4SlaveMakerControler.instance.AutoSaveLoad();
      
        
    }

    public void StartATestGamePart1()
    {
        UIControler.instance.HideAllUi();
        UIControler.instance.ShowUiHouse();
        StartATestGamePart2();
    }

    public void StartATestGamePart2()
    {
        SM4SlaveMakerControler.instance.slaveMaker = new SM4SlaveMaker();
        SM4SlaveMakerControler.instance.AutoSaveSave();
        SM4SlaveMakerControler.instance.AutoSaveLoad();

        StartATestGamePart3();
    }

    public void StartATestGamePart3()
    {
        // Load Slaves
        StartATestGamePart4();
    }
    
    public void StartATestGamePart4()
    {
        // Load Events
        FindObjectOfType<SM4XMLintoGame>().GetXMLEventFiles();
        
        /*
        foreach (var region in SM4EventListsContainer.instance.regions)
        {
            Debug.Log(region.regionName);
            foreach (var area in region.areas)
            {
                Debug.Log(area.areaName);
                foreach (var location in area.locations)
                {
                    Debug.Log(location.locationName);
                    foreach (var sm4Event in location.eventList.eventList)
                    {
                        Debug.Log(sm4Event.eventName);
                    }
                }
            }
        }
        
        Debug.Log("---------------------------------");

        Debug.Log(SM4FindEvent.instance.FindEventByName("NoLolsGiven").eventName);
        SM4EventExecute.instance.ExecuteEvent(SM4FindEvent.instance.FindEventByName("NoLolsGiven"));
        */
        
        
        
        
        
        
        StartATestGamePart5();
    }

    public void StartATestGamePart5()
    {
        // start the world
        World.instance.BigBang(1);
        
        //World.instance.Turn();
        
    }
}
