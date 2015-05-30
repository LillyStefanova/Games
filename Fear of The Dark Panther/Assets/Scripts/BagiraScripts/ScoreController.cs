using UnityEngine;
using UnityEngine.UI;
public class ScoreController : MonoBehaviour 
{
    private Collider2D collision;
    public static float score = 0;
    Text text;
   
    public void Start () 
    {
        this.text = this.GetComponent<Text>();
        this.collision = this.GetComponent<Collider2D>();
	}
	public void Update () 
    {
        OnTriggerEnter2D(collision);       
	
	}
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Food")
        {
            if(collision.gameObject.name == "Food_Fish")
            {
                score += 10;
            }

            if(collision.gameObject.name == "Food_Meat")
            {
                score += 20;
            }

            if (collision.gameObject.name == "Rabbit")
            {
                score += 50;
            }
            ScoreChange(score);
            Destroy(collision.gameObject);
        }
    }

    public void ScoreChange(float points)
    {
        var point = GetPoint.score;
        point += points;
        GetPoint.score = point;
    }
  
    
}
