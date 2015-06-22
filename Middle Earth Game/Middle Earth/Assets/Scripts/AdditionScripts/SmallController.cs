using UnityEngine;
public class SmallController : MonoBehaviour 
{
    public static bool isSmall = false;
    private Collider2D collision;
	public void Start () 
    {
        this.collision = this.GetComponent<Collider2D>();
	}
	public void Update () 
    {
        OnTriggerStay2D(collision);
	}

    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            var player = collision.gameObject;
            var scale = player.transform.localScale;
            scale.x = 0.5f;
            scale.y = 0.5f;
            player.transform.localScale = scale;
            isSmall = true;
        }
    }    
}
