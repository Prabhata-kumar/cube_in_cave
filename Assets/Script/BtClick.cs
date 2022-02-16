using UnityEngine;
using UnityEngine.SceneManagement;

public class BtClick : MonoBehaviour
{
    public void BtNewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
};
