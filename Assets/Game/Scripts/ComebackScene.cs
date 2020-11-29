using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComebackScene : MonoBehaviour
{
    public GameObject returntogameBtn;

    public void Scenechange()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
