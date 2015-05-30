using UnityEngine;
using System.Collections;

public class RabbitController : MonoBehaviour 
{
    private GameObject player;
    private Animator animator;
	public void Start () 
    {
        this.player = GameObject.FindGameObjectWithTag("Bagira");
        this.animator = this.GetComponent<Animator>();
	}
    public void Update()
    {
        
        var velocityForRight = new Vector3(0.01f, 0.03f, 0);
        var gravity = new Vector3(0, -0.01f, 0);
        var velocityForLeft = new Vector3(-0.01f, 0.03f, 0);

        Vector3 playerPosition = player.transform.position;        
        
        var position = this.transform.position;
       
        if(playerPosition.x < position.x)
        {
            animator.SetInteger("RabbitState",0);
            position = (position + (velocityForRight + gravity)) ;           
        }

        if(playerPosition.x > position.x)
        {       
            animator.SetInteger("RabbitState",1);
            position = (position + (velocityForLeft + gravity));    
        }
       
        this.transform.position = position;

        var rotation = this.transform.rotation;
        rotation.z = 0;
        this.transform.rotation = rotation;

    }

}
