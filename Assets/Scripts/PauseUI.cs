using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseUI : UIScreen
{
    public UIManager uIManager;


    public void Resume()
    {
        uIManager.ShowScreen(Screens.GamePlay);
    }


    public void Home()
    {
        uIManager.ShowScreen(Screens.MainMenu);
    }
}
