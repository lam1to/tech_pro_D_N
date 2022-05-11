using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Shop: MonoBehaviour
{
    /*
    int switchCost= 100;
    int LubricationCost = 10;

    public TextMeshProUGUI SwitchCostText;
    public TextMeshProUGUI LubricationCostText;

    void Start()
    {
        if (PlayerPrefs.GetInt("first") == 0)
        {
            PlayerPrefs.SetInt("first", 1);
            PlayerPrefs.SetInt("switchCost", switchCost);
            PlayerPrefs.SetInt("LubricationCost", LubricationCost);
        }
        SwitchCostText.text = PlayerPrefs.GetInt("switchCost") + " click";
        LubricationCostText.text = PlayerPrefs.GetInt("LubricationCost") + " click";
    }


    public void Switch()
    {
        if (PlayerPrefs.GetInt("scor") >= PlayerPrefs.GetInt("switchCost"))
        {
            PlayerPrefs.SetInt("scor", PlayerPrefs.GetInt("scor") - PlayerPrefs.GetInt("switchCost"));
            PlayerPrefs.SetInt("switchCost", (int)(PlayerPrefs.GetInt("switchCost") * 1.5f));
            PlayerPrefs.SetInt("clickup", PlayerPrefs.GetInt("clickup") * 3);
            SwitchCostText.text = PlayerPrefs.GetInt("switchCost") + " click";
        }

    }

    public void Lubrication()
    {
        if (PlayerPrefs.GetInt("scor") >= PlayerPrefs.GetInt("LubricationCost"))
        {
            PlayerPrefs.SetInt("scor", PlayerPrefs.GetInt("scor") - PlayerPrefs.GetInt("LubricationCost"));
            PlayerPrefs.SetInt("LubricationCost", (int)(PlayerPrefs.GetInt("LubricationCost") * 1.5f));
            PlayerPrefs.SetInt("clickup", PlayerPrefs.GetInt("clickup") + 1);
            LubricationCostText.text = PlayerPrefs.GetInt("LubricationCost") + " click";
        }
    }
    */
    int switchCost = 100;
    int LubricationCost = 10;

    public TextMeshProUGUI SwitchCostText;
    public TextMeshProUGUI LubricationCostText;

    void Start()
    {
        if (PlayerPrefs.GetInt("first") == 0)
        {
            PlayerPrefs.SetInt("first", 1);
            PlayerPrefs.SetInt("switchCost", switchCost);
            PlayerPrefs.SetInt("LubricationCost", LubricationCost);
        }

        SwitchCostText.text = PlayerPrefs.GetInt("switchCost") + " click";
        LubricationCostText.text = PlayerPrefs.GetInt("LubricationCost") + " click";
    }


    public void Switch()
    {
        if (PlayerPrefs.GetInt("scor") >= PlayerPrefs.GetInt("switchCost"))
        {
            PlayerPrefs.SetInt("scor", PlayerPrefs.GetInt("scor") - PlayerPrefs.GetInt("switchCost"));
            PlayerPrefs.SetInt("switchCost", (int)(PlayerPrefs.GetInt("switchCost") * 1.5f));
            PlayerPrefs.SetInt("clickup", PlayerPrefs.GetInt("clickup") * 3);
            SwitchCostText.text = PlayerPrefs.GetInt("switchCost") + " click";
        }

    }
    public void Lubrication()
    {
        if (PlayerPrefs.GetInt("scor") >= PlayerPrefs.GetInt("LubricationCost"))
        {
            PlayerPrefs.SetInt("scor", PlayerPrefs.GetInt("scor") - PlayerPrefs.GetInt("LubricationCost"));
            PlayerPrefs.SetInt("LubricationCost", (int)(PlayerPrefs.GetInt("LubricationCost") * 1.5f));
            PlayerPrefs.SetInt("clickup", PlayerPrefs.GetInt("clickup") + 1);
            LubricationCostText.text = PlayerPrefs.GetInt("LubricationCost") + " click";
        }
    }







}
