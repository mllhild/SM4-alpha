using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SM4UIDate : MonoBehaviour
{
    public TextMeshProUGUI date;
    public TextMeshProUGUI time;

    public Image moonfase;
    public Sprite[] moonfases;
    
    void Awake()
    {
        moonfases = Resources.LoadAll<Sprite>("UI/prealpha/IconsPlaceHolder/Moon");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetCurrentTime()
    {
        World.instance.UpdateDate();
        date.text = ((World.instance.week-1)*7+World.instance.weekday).ToString() +"/"+  World.instance.month.ToString() +"/"+ World.instance.year.ToString();
        time.text = (World.instance.time / 10).ToString() + ":" + ((World.instance.time % 10) * 6).ToString();
    }

    public void GetCurrentMoonfase()
    {
        moonfase.sprite = moonfases[(World.instance.day % 26)];
    }
    
}
