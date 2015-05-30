
using UnityEngine;
public class MovementController : MonoBehaviour
{
    public float speed = 1.5f;

    private Animator animator;    
    public void Start()
    {
        this.animator = this.GetComponent<Animator>();
    }

    public void Update()
    {
        animator.SetInteger("BagiraState", 0);        
        //  animator.Play("BagiraStop");

        var rotation = transform.rotation;
        rotation.z = 0;
        this.transform.rotation = rotation;


        if (Input.anyKey)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
              //  animator.SetInteger("BagiraState", 2);

                 animator.Play("BagiraRun");


                Vector2 myPosition = new Vector2(this.transform.position.x, this.transform.position.y);
                Mathf.Clamp(myPosition.y, 0.644f, 1f);
                myPosition += Vector2.up;
                this.transform.position = myPosition;

            }

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            {
               
                animator.SetInteger("BagiraState", 1);

                // animator.Play("BagiraWalk");
                var scale = transform.localScale;
                var sign = 1;

                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    // left
                    if (scale.x < 0)
                    {
                        scale.x *= -1;
                    }
                    sign = -1;
                }

                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    // right
                    if (scale.x > 0)
                    {
                        scale.x *= -1;
                    }
                    //   sign = 1;
                }
              
                this.transform.localScale = scale;

                transform.position = new Vector3(transform.position.x + (speed * Time.deltaTime * sign), transform.position.y, 0);

            }
        }
    }

}




