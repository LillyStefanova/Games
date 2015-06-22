using UnityEngine;
using System.Collections;

public class OpenDoorController : MonoBehaviour 
{
    public AudioClip hatchDoor;

    private Collider2D collision;
    private AudioSource audioSource;
    public void Start () 
    {       
        this.collision = this.GetComponent<Collider2D>();
        this.audioSource = this.GetComponent<AudioSource>();
	}
	
	public void Update () 
    {
       
        OnTriggerStay2D(collision);
	}

    public void OnTriggerStay2D(Collider2D collision)
    {   
        if(collision.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(hatchDoor);
            Application.LoadLevel("FirstLevel");
        }
    }
}
