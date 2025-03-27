using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionsound : MonoBehaviour
{
    
    
        // Start is called before the first frame update

        public AudioSource questionfx;

        void OnTriggerEnter(Collider other)
        {
        questionfx.Play();
            COLLECTABLECONTROLLER.coinCount += 1;
            this.gameObject.SetActive(false);
        }
    
    }
