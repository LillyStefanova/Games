using UnityEngine;
using UnityEngine.UI;
public class DamageController : MonoBehaviour
{
    public static int lives;
    public Text text;
    Collider2D collision;
    public void Start()
    {
        this.text = text.GetComponent<Text>();
        this.collision = this.GetComponent<Collider2D>();
        if (Application.loadedLevelName == "Fiesta!")
        {
            lives = 7;
        }
        UpdateLives();
    }

    public void Update()
    {
        UpdateLives();
        OnTriggerEnter2D(collision);     
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        bool isTriggered = true;
        if (collision.gameObject.tag == "Spike")
        {
            lives = 0;
        }

        if (isTriggered == true)
        {
            if (collision.gameObject.tag == "Axe")
            {
                lives -= 1;
            }
            isTriggered = false;
        }
        if (lives < 0)
        {
            lives = 0;
        }

        if (lives == 0)
        {
            Application.LoadLevel("Lose");
            lives = 7;
        }

    }

    public void UpdateLives()
    {
        text.text = "Lives: " + lives;
    }


}
