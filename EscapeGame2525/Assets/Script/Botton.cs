using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnBotton : MonoBehaviour
{
   public void HintBottonClick()
    {
        SceneManager.LoadScene("Hint1");
    }
}
