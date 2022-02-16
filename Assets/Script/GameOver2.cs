
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver2 : MonoBehaviour
{
    public gameOverController2 GameOverController2;
    public GameObject playerDiedText;
    public Button RestartButton;
    public HealthBar HealthBar;
    public void Awake()
    {
       RestartButton.onClick.AddListener(RelodeLevel);
    }
    private void Start()
    {
        playerDiedText.SetActive(false);
    }

    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Finish"))
        {
            playerDiedText.SetActive(true);
        }
        else if (other.CompareTag("Enemy"))
        {
            playerDiedText.SetActive(true);
        }
        else if (other.CompareTag("spike"))
        {
            playerDiedText.SetActive(true);
        }
    }
    private void RelodeLevel()
    {
        SceneManager.LoadScene(0);
    }
}


