using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CsQuiz : MonoBehaviour
{
    
    [Header("Source")]
    public GameObject Panel_Correct;

    public GameObject returntogameBtn; 
    // [SerializeField] private InputField Answer;
        public InputField inputField;
    
        public static string answer_txt;

        private void Start() {
            Panel_Correct.SetActive(false);
        }
        private void Update(){

        if(inputField.text == "사자" || inputField.text == "생쥐")
        {
            Panel_Correct.SetActive(true);
        }   
    }
    public void SceneChange(){
        SceneManager.LoadScene("SampleScene");
    }
}
