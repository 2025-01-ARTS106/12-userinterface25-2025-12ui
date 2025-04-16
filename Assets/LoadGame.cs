using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{

    public Animator startAnimator;
    public Animator settingsAnimator;

    public void StartRocketMouseGame()
    {
        SceneManager.LoadScene("RocketMouse");
    }

    public void OpenSettings()
    {
        startAnimator.SetBool("isHidden", true);
        settingsAnimator.SetBool("isHidden", true);
    }
    
}
