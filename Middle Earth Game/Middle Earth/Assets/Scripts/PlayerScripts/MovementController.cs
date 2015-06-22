using UnityEngine;
using System.Collections;

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

        animator.SetInteger("MuramasaState", 0);
        // animator.Play("MuramasaIdle");

        if (Input.anyKey && Time.timeScale > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.Play("MuramasaJump");

                Vector2 myPosition = new Vector2(this.transform.position.x, this.transform.position.y);
                Mathf.Clamp(myPosition.y, 0.644f, 1f);
                myPosition += Vector2.up;
                this.transform.position = myPosition;

            }

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                //animator.Play("MuramasaWalk");
                animator.SetInteger("MuramasaState", 1);
                var scale = transform.localScale;
                var sign = 1;

                if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                {
                    // left
                    if (scale.x > 0)
                    {
                        scale.x *= -1;
                    }
                    sign = -1;
                }

                else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                {
                    // right
                    if (scale.x < 0)
                    {
                        scale.x *= -1;
                    }
                      // sign = 1;
                    
                }

                this.transform.localScale = scale;

                transform.position = new Vector3(transform.position.x + (speed * Time.deltaTime * sign), transform.position.y, 0);

            }

            if(Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl))
            {
                animator.Play("MuramasaAttack");              
            }
                     
        }
    }
   
}
