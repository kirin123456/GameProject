using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리를 위해 필요한 네임스페이스

public class RedCircle : MonoBehaviour
{
    private Renderer circleRenderer;
    private bool isRed = false;

    void Start()
    {
        Debug.Log("RedCircle Start");
        circleRenderer = GetComponent<Renderer>();
        circleRenderer.material.color = Color.white;
        StartCoroutine(ChangeColorAndDestroy());


    }

    private IEnumerator ChangeColorAndDestroy()
    {
        yield return new WaitForSeconds(1f);
        circleRenderer.material.color = Color.red;
        isRed = true;
        yield return new WaitForSeconds(1f);
        if (isRed)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
        if (isRed && other.CompareTag("Player"))
        {
            Debug.Log("Player collided with red circle");
            GameOver();
        }
    }

    private void GameOver()
    {
        Debug.Log("Player hit the red circle! Game Over.");
        SceneManager.LoadScene("TitleScene"); // 타이틀 씬으로 이동
    }
}
