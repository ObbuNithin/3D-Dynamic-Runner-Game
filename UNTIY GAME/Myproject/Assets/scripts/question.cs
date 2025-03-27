using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class question : MonoBehaviour
{
    [SerializeField] GameObject questionoption;
    public void QUESTIONOPTION()
    {
        questionoption.SetActive(true);
        Time.timeScale = 0f;
    }
    public void hi()
    {
        questionoption.SetActive(false);
        Time.timeScale = 1f;
    }
    public void questionoptio(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}
    


