using UnityEngine;
using System.Collections;

public class LoopController : MonoBehaviour
{
    public GameObject player;

    private float offset;
    public void Start()
    {
        this.offset = this.transform.position.x - this.player.transform.position.x;
    }

    public void Update()
    {
        // If you prefer the camera not to follow the player all the time, uncomment the following code.

        //if(this.gameObject.tag == "MainCamera")
        //{
        //   if(player.transform.position.x > this.transform.position.x + 1)
        //    {
        //        UpdatePosition();
        //    }
        //}

        //else
        //{   
       //if(this.transform.position.x < 48)
       //{

           UpdatePosition();
       //}
        
       
        //}


    }

    public void UpdatePosition()
    {
        var position = this.transform.position;
        position.x = this.player.transform.position.x + offset;
        this.transform.position = position;


    }
}
