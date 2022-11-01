
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private gameOverController2 GameOverController2;
    [SerializeField] private GameObject playerDiedText;
    [SerializeField] private Button RestartButton;
    
    public void Awake()
    {
       RestartButton.onClick.AddListener(RelodeLevel);
    }
    private void Start()
    {
        playerDiedText.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag =="Finish")
        {
            playerDiedText.SetActive(true);
        }
        else if (other.tag =="Enemy")
        {
            playerDiedText.SetActive(true);
        }
        else if (other.tag =="spike")
        {
            playerDiedText.SetActive(true);
        }
    }
    private void RelodeLevel()
    {
        SceneManager.LoadScene(0);
    }
}


