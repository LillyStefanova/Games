using UnityEngine;
public class DamageController : MonoBehaviour 
{
    public float lives;
    private Collider2D collision;
	public void Start () 
    {
        this.collision = this.GetComponent<Collider2D>();
	}
	public void Update () 
    {
        OnTriggerEnter2D(collision);

	    if(lives == 0)
        {
            Application.LoadLevel("Lose");
        }

	}
    public void OnTriggerEnter2D (Collider2D collision)
    {
        var position = this.transform.position;

        if(collision.gameObject.tag == "Spike")
        {
            lives = lives - 1f;
            position.x = 5f;
            position.y = 0.6529179f;
            this.transform.position = position;
            
            
        }
    }
}
