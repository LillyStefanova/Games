using UnityEngine;
using System.Collections;

public class LevelCameraController : MonoBehaviour 
{
    private Transform playerTransform;	
   
    public void FixedUpdate()
    {
        this.playerTransform = GameObject.FindWithTag("Player").transform;

        var cameraPosition = this.transform.position;
         if (playerTransform.position.x > 2.4f && playerTransform.position.x < 12f)
            {
                cameraPosition.x = playerTransform.position.x;
                this.transform.position = cameraPosition;
            }     
   
        //else
        //{
        //    cameraPosition.y = playerTransform.position.y;
        //    this.transform.position = cameraPosition;
        //}


    }
}
