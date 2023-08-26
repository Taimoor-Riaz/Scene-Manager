using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayUI : UIScreen
{
    public UIManager uIManager;


    public void Pause()
    {
        uIManager.ShowScreen(Screens.Pause);
    }
    public void GameOver()
    {
        uIManager.ShowScreen(Screens.GameOver);
    }
}
