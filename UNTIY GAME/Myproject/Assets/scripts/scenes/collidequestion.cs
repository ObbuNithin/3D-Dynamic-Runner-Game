using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collidequestion : MonoBehaviour
{

    public GameObject player1;
    public GameObject levelcontol;
    public GameObject charModel;
    public AudioSource crashThud;

    void OnTriggerEnter(Collider other)
    {
        
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            player1.GetComponent<playermove>().enabled = false;
            levelcontol.GetComponent<points>().enabled = false;

            crashThud.Play();
            SceneManager.LoadScene("question1"); 
    }
}
