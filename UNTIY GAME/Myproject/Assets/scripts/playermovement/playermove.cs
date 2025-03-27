using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermove : MonoBehaviour
{
    private CharacterController controller;
    public float moveSpeed = 19;
    public float leftRightspeed = 10;

    public bool isjumping = false;
    public bool comingdown=false;
public GameObject playerObject;

     void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        
        {


            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > levelboundary.leftside)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightspeed);

                }
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {

                if (this.gameObject.transform.position.x < levelboundary.rightside)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightspeed * -1);
                }


            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space))
            {
                if(isjumping==false)
                {
                    isjumping = true;
                    playerObject.GetComponent<Animator>().Play("jamp");
                    StartCoroutine(Jumpsequence());
                }
            }
        }
       
       if(isjumping==true)
        {
            if(comingdown==false)
            {
                transform.Translate(Vector3.up*Time.deltaTime * 8, Space.World);
            }
            if (comingdown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -8, Space.World);
            }

        }
        
    }
    IEnumerator Jumpsequence()
    {
        yield return new WaitForSeconds(0.4f);
        comingdown = true;
        yield return new WaitForSeconds(0.4f);
        comingdown = false;
        isjumping=false;

        playerObject.GetComponent<Animator>().Play("Running (2)");
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.transform.tag=="qu")
        {
            SceneManager.LoadScene("gameover1");
        }
    }
}
    
      
    
