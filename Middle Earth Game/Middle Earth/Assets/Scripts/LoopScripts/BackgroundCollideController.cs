using System;
using UnityEngine;

public class BackgroundCollideController : MonoBehaviour 
{
    public GameObject player;

    private int backgroundsCount;
    private float distanceBetweenBackgrounds;

    private int groundsCount;
    private float distanceBetweenGrounds;

    // private float coinPositionX;
    // private float coinPositionY;
    public void Start()
    {
        var backgrounds = GameObject.FindGameObjectsWithTag("Background");
        this.backgroundsCount = backgrounds.Length;

        if(backgroundsCount < 2)
        {
            throw new InvalidOperationException("You must have at least two backgrounds!");
        }

        var firstBackground = GameObject.Find("Sky 1");
        var secondBackground = GameObject.Find("Sky 2");

        this.distanceBetweenBackgrounds = Mathf.Abs(firstBackground.transform.position.x - secondBackground.transform.position.x);

        var grounds = GameObject.FindGameObjectsWithTag("Ground");
        this.groundsCount = grounds.Length;

        if(groundsCount < 2)
        {
            throw new InvalidOperationException("You must have at least two grounds!");
        }
        var firstGround = GameObject.Find("Ground 1");
        var secondGround = GameObject.Find("Ground 2");

        this.distanceBetweenGrounds = Mathf.Abs(firstGround.transform.position.x - secondGround.transform.position.x);

    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Background"))
        {            
            var background = collider.gameObject;
            var positionBackground = background.transform.position;
            positionBackground.x += (this.backgroundsCount * this.distanceBetweenBackgrounds);
            background.transform.position = positionBackground;
        }

        if(collider.CompareTag("Ground"))
        {
            var ground = collider.gameObject;
            var positionGround = ground.transform.position;
            positionGround.x += (this.groundsCount * this.distanceBetweenGrounds);
            ground.transform.position = positionGround;
        }
        if(collider.CompareTag("Coin") || collider.CompareTag("Grass") || collider.CompareTag("Tree"))
        {
            var thing = collider.gameObject;
            var positionThing = thing.transform.position;
            positionThing.x += (this.backgroundsCount * this.distanceBetweenBackgrounds);
            thing.transform.position = positionThing;
        }
        if(collider.CompareTag("Spike"))
        {
            var spike = collider.gameObject;
            var coefficient = UnityEngine.Random.Range(0.8f, 2);
            var positionSpike = spike.transform.position;
            positionSpike.x += coefficient * (this.backgroundsCount * this.distanceBetweenBackgrounds);
            spike.transform.position = positionSpike;
        }
       
        
    }
}
