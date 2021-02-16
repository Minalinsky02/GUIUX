using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject UpgradeMenuUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        UpgradeMenuUI.SetActive(false);
        GameIsPaused = false;
    }
    void Pause()
    {
        UpgradeMenuUI.SetActive(true);
        GameIsPaused = true; 

        
    }
}
