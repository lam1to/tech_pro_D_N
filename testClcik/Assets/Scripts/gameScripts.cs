using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameScripts : MonoBehaviour
{
    public int click;
    private int clickup = 1;

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
        click += clickup;
    }
    /*
    public void onClickUpgrade()
    {
        if(check == true)
        {
            upgrade.SetActive(true);
            check = false;
        }
    }
    */
    public void OnclickBuyKeykaps()
    {
        if(click >= 10)
        {
            clickup *= 2;
            click -= 10;
        }
    }
}
