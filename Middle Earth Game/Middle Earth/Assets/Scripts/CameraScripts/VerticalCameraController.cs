using UnityEngine;
using System.Collections;

public class VerticalCameraController : MonoBehaviour 
{
    private Transform playerTransform;

    public void Update()
    {
    }
    public void FixedUpdate()
    {

        this.playerTransform = GameObject.FindWithTag("Player").transform;
        var cameraPosition = this.transform.position;

        if(playerTransform.position.y > 1.8f && playerTransform.position.y < 7.5f)
        {
            cameraPosition.y = playerTransform.position.y;
            this.transform.position = cameraPosition;
        }

        //else
        //{
        //    cameraPosition.x = playerTransform.position.x;
        //    this.transform.position = cameraPosition;
        //}
    }
}
