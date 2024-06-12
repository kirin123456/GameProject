using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartToTitle : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
