using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 

public class selectLevel : MonoBehaviour
{
    public Button level1;
    public Button level2;
    public Button level3;

    Color32 disabledButtonColor = new Color32(255, 255, 255, 72);
    Color32 enabledButtonColor = new Color32(255, 255, 255, 255);

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll(); 
        int highestLevel = PlayerPrefs.GetInt("highestLevel", 1);
        if (PlayerPrefs.GetInt("highestLevel") == 0)
        {
            PlayerPrefs.SetInt("highestLevel", 1); 
        }


        Button[] levelButtons = { level1, level2, level3 };
        Debug.Log(PlayerPrefs.GetInt("highestLevel"));

        for (int i = 0; i < 3; i++)
        {
            if (i < PlayerPrefs.GetInt("highestLevel"))
            {
                levelButtons[i].interactable = true;
                levelButtons[i].GetComponent<Image>().color = enabledButtonColor; 
            }
            else
            {
                levelButtons[i].interactable = false;
                levelButtons[i].GetComponent<Image>().color = disabledButtonColor;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
