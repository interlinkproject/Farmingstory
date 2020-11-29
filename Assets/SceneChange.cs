using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public GameObject returntogameBtn;

    public void Scenechange(){
        SceneManager.LoadScene("SampleScene");
    }
    public void Scenechange2(){
        SceneManager.LoadScene("New Scene");
    }
}
