using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUI : UIScreen
{

    public UIManager uIManager;


    public void Restart()
    {
        uIManager.ShowScreen(Screens.GamePlay);
    }


    public void Home()
    {
        uIManager.ShowScreen(Screens.MainMenu);
    }
}
