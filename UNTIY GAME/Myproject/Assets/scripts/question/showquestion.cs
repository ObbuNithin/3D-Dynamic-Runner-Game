using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class showquestion : MonoBehaviour
{
    [SerializeField] GameObject questioncount;
     public void Quest()
    {
        questioncount.SetActive(true);
    }
}
