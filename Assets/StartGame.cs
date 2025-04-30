using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Animator startButton;
    public Animator settingsButton;

    public void OpenSettings()
    {
        startButton.SetBool("IsHidden", true);
        settingsButton.SetBool("IsHidden", false);
    }
    // Start is called before the first frame update
    public void StartRocketMouseGame()
    {
        SceneManager.LoadScene("RocketMouse");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
