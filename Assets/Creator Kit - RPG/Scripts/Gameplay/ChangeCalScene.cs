using System.Collections;
using System.Collections.Generic;
using RPGM.Core;
using RPGM.Gameplay;
using RPGM.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeCalScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // 박스 콜라이더에 닿는 순간 이벤트 발생
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Character")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
