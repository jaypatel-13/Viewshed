using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   public void changeScene()
   {
       SceneManager.LoadScene("SampleScene");
   }
}
