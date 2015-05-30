using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GetPoint : MonoBehaviour
{
    public static float score;

    public Text text;

    public void Start()
    {
        text = GetComponent<Text>();
        GetComponent<Renderer>().enabled = true;
        score = 0;
        UpdateScore();
    }


    public void Update()
    {       
        text.text = "" + score;
    }

    public void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        UpdateScore();
    }

    public void UpdateScore()
    {
        text.text = "Score: " + score;
    }
}
