using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Shop: MonoBehaviour
{
    
    int switchCost = 100;
    int LubricationCost = 10;
    int KeyboardCost = 1000;

    public TextMeshProUGUI SwitchCostText;
    public TextMeshProUGUI LubricationCostText;
    public TextMeshProUGUI KeyboardCostText;

    void Start()
    {
        //PlayerPrefs.SetInt("switchCost", 100);
        //PlayerPrefs.SetInt("LubricationCost", 10);
        //PlayerPrefs.SetInt("KeyboardCost", 1000);
        if (PlayerPrefs.GetInt("first") == 0)
        {
            PlayerPrefs.SetInt("first", 1);
            PlayerPrefs.SetInt("switchCost", PlayerPrefs.GetInt("switchCost"));
            PlayerPrefs.SetInt("LubricationCost", PlayerPrefs.GetInt("LubricationCost"));
            PlayerPrefs.SetInt("KeyboardCost", PlayerPrefs.GetInt("KeyboardCost"));
        }
        
        SwitchCostText.text = PlayerPrefs.GetInt("switchCost") + " click";
        LubricationCostText.text = PlayerPrefs.GetInt("LubricationCost") + " click";
        KeyboardCostText.text = PlayerPrefs.GetInt("KeyboardCost") + " click";
    }


    public void Switch()
    {
        if (PlayerPrefs.GetInt("scor") >= PlayerPrefs.GetInt("switchCost"))
        {
            PlayerPrefs.SetInt("click", PlayerPrefs.GetInt("click") - PlayerPrefs.GetInt("switchCost"));
            PlayerPrefs.SetInt("scor", PlayerPrefs.GetInt("scor") - PlayerPrefs.GetInt("switchCost"));
            PlayerPrefs.SetInt("switchCost", (int)(PlayerPrefs.GetInt("switchCost") * 2f));
            PlayerPrefs.SetInt("clickup", PlayerPrefs.GetInt("clickup") + 5);
            SwitchCostText.text = PlayerPrefs.GetInt("switchCost") + " click";
        }

    }
    public void Lubrication()
    {
        if (PlayerPrefs.GetInt("scor") >= PlayerPrefs.GetInt("LubricationCost"))
        {
            PlayerPrefs.SetInt("click", PlayerPrefs.GetInt("click") - PlayerPrefs.GetInt("LubricationCost"));
            PlayerPrefs.SetInt("scor", PlayerPrefs.GetInt("scor") - PlayerPrefs.GetInt("LubricationCost"));
            PlayerPrefs.SetInt("LubricationCost", (int)(PlayerPrefs.GetInt("LubricationCost") * 1.5f));
            PlayerPrefs.SetInt("clickup", PlayerPrefs.GetInt("clickup") + 1);
            LubricationCostText.text = PlayerPrefs.GetInt("LubricationCost") + " click";
        }
    }
    public void Keyboard()
    {
        if (PlayerPrefs.GetInt("scor") >= PlayerPrefs.GetInt("KeyboardCost"))
        {
            PlayerPrefs.SetInt("click", PlayerPrefs.GetInt("click") - PlayerPrefs.GetInt("KeyboardCost"));
            PlayerPrefs.SetInt("scor", PlayerPrefs.GetInt("scor") - PlayerPrefs.GetInt("KeyboardCost"));
            PlayerPrefs.SetInt("KeyboardCost", (int)(PlayerPrefs.GetInt("KeyboardCost") * 2.5f));
            PlayerPrefs.SetInt("clickup", PlayerPrefs.GetInt("clickup") * 3);
            KeyboardCostText.text = PlayerPrefs.GetInt("KeyboardCost") + " click";
        }

    }







}
