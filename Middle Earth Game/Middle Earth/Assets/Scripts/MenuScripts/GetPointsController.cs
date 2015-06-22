using UnityEngine;
using UnityEngine.UI;
    public class GetPointsController : MonoBehaviour
    {
        public int points;
        public Text text;

        public void Update()
        {
            points = ScoreController.score;
            Visualize();
        }

        public void Visualize()
        {
            text.text = "Your score is " + points + " .";
        }
    }