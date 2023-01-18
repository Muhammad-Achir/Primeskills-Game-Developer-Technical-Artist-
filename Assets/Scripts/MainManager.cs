using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public Animator anim;

    public GameObject tutorialPanel_1;
    public GameObject tutorialPanel_2;

    public GameObject danceBtn;

    public CameraMove cameraMove;

    public void NextPanel()
    {
        tutorialPanel_1.SetActive(false);
        tutorialPanel_2.SetActive(true);
    }

    public void BackPanel()
    {
        tutorialPanel_1.SetActive(true);
        tutorialPanel_2.SetActive(false);
    }

    public void ClosePanel()
    {
        tutorialPanel_2.SetActive(false);
        danceBtn.SetActive(true);
        cameraMove.enabled = true;
    }

    public void Dance()
    {
        anim.SetBool("Dancing", true);
    }
}
