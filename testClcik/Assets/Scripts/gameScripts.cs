using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameScripts : MonoBehaviour
{
    public int click;
    public int clickup = 1;

    void Start()
    {
        PlayerPrefs.SetInt("clickup", clickup);
    }
    //private bool check = true;

    public Text countClick;
    //public GameObject upgrade;


    // Update is called once per frame
    void Update()
    {
        countClick.text = click + " click";
    }

    public void OnClickButton()
    {
        PlayerPrefs.SetInt("scor",click + PlayerPrefs.GetInt("clickup"));
        click = PlayerPrefs.GetInt("scor");
    }



   
}
