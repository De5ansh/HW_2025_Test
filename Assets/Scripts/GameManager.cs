using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(Wait());
        Destroy(gameObject);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        StartCoroutine(Wait());
        Destroy(gameObject);
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void GoToMenu()
    {
        StartCoroutine(Wait());
        SceneManager.LoadScene(0);
    }
}
