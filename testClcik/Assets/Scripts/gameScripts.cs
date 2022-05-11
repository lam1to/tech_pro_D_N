using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameScripts : MonoBehaviour
{
    public int click;
    public int clickup = 1;
    public Text countClick;

    
    void Start()
    {
        if (PlayerPrefs.GetInt("first2") == 0)
        {
            PlayerPrefs.SetInt("first2", 1);
            PlayerPrefs.SetInt("click", PlayerPrefs.GetInt("click"));
        }
        //PlayerPrefs.SetInt("clickup", clickup);
        countClick.text = PlayerPrefs.GetInt("click") + " click";
    }


    // Update is called once per frame
    void Update()
    {
        countClick.text =  PlayerPrefs.GetInt("click") + " click";
    }

    public void OnClickButton()
    {
        PlayerPrefs.SetInt("scor", PlayerPrefs.GetInt("click") + PlayerPrefs.GetInt("clickup"));
        PlayerPrefs.SetInt("click", PlayerPrefs.GetInt("scor"));
    }



   
}
