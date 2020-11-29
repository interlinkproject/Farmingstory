using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NPCQuiz : MonoBehaviour
{
    public GameObject Panel_Quiz;    
    public GameObject gamestartBtn; 

    bool canInteract;

    void Start()
    {
        Panel_Quiz.SetActive(false);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Panel_Quiz.SetActive(true);
    }

    public void OnCollisionExit2D(Collision2D collision)
        {
            Panel_Quiz.SetActive(false);
        }
    // Update is called once per frame
    public void SceneChange1(){
        SceneManager.LoadScene("New Scene");
    }
    
    public void SceneChange2(){
        SceneManager.LoadScene("WordMakeScene");
    }

    public void SceneChange3(){
        SceneManager.LoadScene("MainMenu");
    }

}
