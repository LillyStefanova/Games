using UnityEngine;
using System.Collections;

public class QuickCommandsController : MonoBehaviour
{
    private bool isPaused;
    private bool hasPaused = false;

    public void Start()
    {
        this.isPaused = false;
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.LoadLevel("Menu");
        }

        if (Input.GetKey(KeyCode.M))
        {           
            Application.LoadLevel("Map");           
        }
        

    }

    public void OnGUI()
    {
        if (this.isPaused)
        {
            if (!this.hasPaused)
            {
                this.pauseGame();
                this.hasPaused = true;
            }
        }
        else
        {
            if (this.hasPaused)
            {
                this.resumeGame();
                this.hasPaused = false;
            }
        }


        Color32 backgroundColor = Color.red;
        GUI.backgroundColor = backgroundColor;
        Color32 txtColor = new Color32(71, 71, 71, 255);
        GUI.color = txtColor;

        var button = GUI.Button(new Rect(Screen.width * 0.7f, Screen.height * 0.13f, Screen.width * 0.15f, Screen.height * 0.1f), "PAUSE");




        if (button)
        {
            this.changePauseState();
        }

        if (Input.GetKey(KeyCode.P) || Input.GetKeyUp(KeyCode.P) || Input.GetKeyDown(KeyCode.P))
        {
            this.changePauseState();
        }

    }
    public void pauseGame()
    {
        Time.timeScale = 0;
    }

    public void resumeGame()
    {
        Time.timeScale = 1;
    }

    public void changePauseState()
    {
        this.isPaused = !this.isPaused;
    }
}
