using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// The UI of the main menu screen
/// </summary>


public class MainMenuManager : UIScreen
{
    public UIManager uIManager;
    public RectTransform logo1;
    public  RectTransform logo2;

    public GameObject PlayButton;

    public void Play()
    {
        uIManager.ShowScreen(Screens.GamePlay);
    }

    /// <summary>
    /// Append is used to call the tween animation on the object
    /// Join is called as the above tween is calling the next tween should follow it.
    /// </summary>
  
    public override Tween ShowTweening()
    {
        PlayButton.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        PlayButton.transform.eulerAngles = new Vector3(0, 0, 90);
        logo1.anchoredPosition = new Vector2(-3401, 0);
        logo2.anchoredPosition = new Vector2(3401, 0);

        Sequence animSeq = DOTween.Sequence();
        animSeq.Append(logo1.DOAnchorPos(Vector3.zero, 1).SetEase(Ease.InOutElastic));
        animSeq.Join(logo2.DOAnchorPos(Vector3.zero, 1).SetEase(Ease.InOutElastic));
        animSeq.Append(PlayButton.transform.DOScale(1, 0.5f).SetEase(Ease.InQuart));
        animSeq.Join(PlayButton.transform.DORotate(Vector3.zero, 0.5f).SetEase(Ease.InQuart));

        return animSeq;
    }
}
