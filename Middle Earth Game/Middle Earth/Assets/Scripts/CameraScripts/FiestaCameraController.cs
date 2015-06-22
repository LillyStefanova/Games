using UnityEngine;
public class FiestaCameraController : MonoBehaviour 
{
    public float velocity = 0.045f;
	void Start () 
    {
	
	}
	void Update () 
    {
        if (Time.timeScale == 1)
        {
            var position = this.transform.position;
            position.x += velocity;
            this.transform.position = position;
        }
	}
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Application.LoadLevel("Lose");
        }
    }
}
