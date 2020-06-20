using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SM4EventListsContainer : MonoBehaviour
{
    public static SM4EventListsContainer instance = null;
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
    
    public List<SM4Region> regions = new List<SM4Region>();
    
    // need to merge the resulting multiple from several files? 
    
}

public class SM4Region // Ex: 
{
    public List<SM4Area> areas = new List<SM4Area>();
    public string regionName = "error";
}
public class SM4Area // Ex: Marducane
{
    public List<SM4Location> locations = new List<SM4Location>();
    public string areaName = "error";
}
public class SM4Location // Ex: Palace
{
    public SM4EventList eventList = new SM4EventList();
    public string locationName = "error";
}
