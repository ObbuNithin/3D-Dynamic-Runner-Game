using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    public GameObject disDisplay;
  
    public int disRun;
    public bool addingDis = false;
    void Update()
    {
        if (addingDis==false)
        {
            addingDis= true;
            StartCoroutine(Addingdis());
        }
    }
    IEnumerator Addingdis()
    {
        disRun += 1;
        disDisplay.GetComponent<Text>().text = "" + disRun;
      
        yield return new WaitForSeconds(0.25f);
        addingDis = false;
    }
}
