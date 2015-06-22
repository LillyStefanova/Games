using UnityEngine;
public class OrcDamageController : MonoBehaviour 
{  
    public GameObject player;
    public int  lives = 3;
    public static int sum = 0;
	void Start () 
    {
	}
	void Update () 
    {
        int points = ScoreController.score;
        if(lives == 0)
        {
            Destroy(this.gameObject);
            points = 10;
            ScoreController.score += points;
            sum += 1;
        }
	}

    public void TakeLives()
    {
        lives -= 1;
    }
    
    public int CheckLives()
    {
        return lives;
    }
}
