using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordMakeGame : MonoBehaviour
{
    // public Text buttonText;
    // public Text imageText;

    // int scoreButton;
    // int scoreImage;
    // Start is called before the first frame update

    public Text ansText;
    public Text preText;
    string ans;
    string t0, t1, t2, t3, t4, t5, t6, t7;

    public Button btn0;
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;
    public Button btn7;

    public GameObject Panel_c;
    public GameObject Panel_w;

    public Button retry;


    private void Awake()
    {
        // scoreButton = 0;
        // scoreImage = 0;
        ans = " ";
        t0 = btn0.GetComponentInChildren<Text>().text;
        t1 = btn1.GetComponentInChildren<Text>().text;
        t2 = btn2.GetComponentInChildren<Text>().text;
        t3 = btn3.GetComponentInChildren<Text>().text;
        t4 = btn4.GetComponentInChildren<Text>().text;
        t5 = btn5.GetComponentInChildren<Text>().text;
        t6 = btn6.GetComponentInChildren<Text>().text;
        t7 = btn7.GetComponentInChildren<Text>().text;

        Panel_c.SetActive(false);
        
        Panel_w.SetActive(false);
        
    }

    private void Update()
    {
        //Debug.Log(";;;;"+ansText.text+";;;;;;");
        ansText.text = ans;
        if(ansText.text == " 겨울" || ansText.text == " 울분" || ansText.text == " 아웃"){
            Panel_c.SetActive(true);
        }
        if(ansText.text.Length == 6){
            Panel_w.SetActive(true);
        }
    }

    public void onClickButton0()
    {
        Debug.Log(t0);
        preText.text = t0;
        ans = ans + t0;
        ansText.text = ans;
        //Debug.Log(";;;;"+ans+";;;;;;");
    }

    public void onClickButton1()
    {
        Debug.Log(t1);
        preText.text = t1;
        ans = ans + t1;
        ansText.text = ans;
        //Debug.Log(";;;;"+ans+";;;;;;");
    }

    public void onClickButton2()
    {
        Debug.Log(t2);
        preText.text = t2;
        ans = ans + t2;
        ansText.text = ans;
        //Debug.Log(";;;;"+ans+";;;;;;");
    }

    public void onClickButton3()
    {
        Debug.Log(t3);
        preText.text = t3;
        ans = ans + t3;
        ansText.text = ans;
        //Debug.Log(";;;;"+ans+";;;;;;");
    }

    public void onClickButton4()
    {
        Debug.Log(t4);
        preText.text = t4;
        ans = ans + t4;
        ansText.text = ans;
        //Debug.Log(";;;;"+ans+";;;;;;");
    }

    public void onClickButton5()
    {
        Debug.Log(t5);
        preText.text = t5;
        ans = ans + t5;
        ansText.text = ans;
        //Debug.Log(";;;;"+ans+";;;;;;");
    }

    public void onClickButton6()
    {
        Debug.Log(t6);
        preText.text = t6;
        ans = ans + t6;
        ansText.text = ans;
        //Debug.Log(";;;;"+ans+";;;;;;");
    }

    public void onClickButton7()
    {
        Debug.Log(t7);
        preText.text = t7;
        ans = ans + t7;
        ansText.text = ans;
        //Debug.Log(";;;;"+ans+";;;;;;");
    }
    
    public void onClickrButton()
    {
        Panel_w.SetActive(false);
        onClickDelete();
    }

    public void onClickDelete()
    {
        ans=" ";
    }


}
