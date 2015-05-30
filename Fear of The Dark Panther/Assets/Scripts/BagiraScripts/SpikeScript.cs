using UnityEngine;
public class SpikeScript : MonoBehaviour 
{
    private Collider2D collision;
    
	public void Start () 
    {
        this.collision = this.GetComponent<Collider2D>();
        
	}

	public void Update () 
    {
        OnTriggerEnter2D(collision);
	}
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Spike")
        {
            Application.LoadLevel("FirstLevel");
        }
    }
}
