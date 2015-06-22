using UnityEngine;
using System;
public class DoorController : MonoBehaviour 
{
    public AudioClip hatchDoor;
    private GameObject player;
    private Collider2D collision;
    private Animator animator;
    private AudioSource audioSource;
	public void Start () 
    {
        this.player = GameObject.FindGameObjectWithTag("Player");
        this.collision = this.GetComponent<Collider2D>();
        this.animator = this.GetComponent<Animator>();
        this.audioSource = this.GetComponent<AudioSource>();
	}
	
	public void Update () 
    {
        this.animator.enabled = false;
        KeyController key = player.GetComponent<KeyController>();       
        bool inPlayer = key.CheckIfIsInPlayer();
        if(inPlayer == true)
        {
            this.animator.enabled = true;
        }

        OnTriggerStay2D(collision);
	}

    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && animator.enabled)
        {
            audioSource.PlayOneShot(hatchDoor);
            Application.LoadLevel("ThirdLevel");
        }
    }
}
