using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
  public void StartButton()
    {
        SceneManager.LoadScene("RocketMouse");
    }
    public Animator startButton;
    public Animator settingsButton;
    public Animator dialog;
    public void SettingsButton()
    { startButton.SetBool("IsHidden", true);
    settingsButton.SetBool("IsHidden",true);
        dialog.SetBool("IsHidden", false);
    }
    public void CloseSettings()
    { startButton.SetBool("Ishidden", false);
        settingsButton.SetBool("IsHidden", false);
        dialog.SetBool("IsHidden", true);
    }
}
