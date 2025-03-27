using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsounf : MonoBehaviour
{
    // Start is called before the first frame update
   
    public AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        COLLECTABLECONTROLLER.coinCount += 1;
        this.gameObject.SetActive(false);
    }

// Update is called once per frame
void Update()
    {
        
    }
}
