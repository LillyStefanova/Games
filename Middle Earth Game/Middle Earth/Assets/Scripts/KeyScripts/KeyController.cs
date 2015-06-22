using UnityEngine;
using System.Collections;

public class KeyController : MonoBehaviour 
{
    private Collider2D collision;
    private string keyInPlayer;
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
       if(collision.gameObject.tag == "Key")
       {
           PlayerPrefs.SetString(keyInPlayer, "got");
           Destroy(collision.gameObject);
       }
    }

    public bool CheckIfIsInPlayer()
    {
        string text = PlayerPrefs.GetString(keyInPlayer);
        if(text == "got")
        {
            return true;
        }
        return false;
    }
}
