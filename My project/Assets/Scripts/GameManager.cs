using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Score = 0;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI GameOverText;
    public Button RestartButton;
    public bool SuperSexTime = true;
    public List<GameObject> Target;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score: " + Score;
        StartCoroutine(SpawnTarget());
    }
    public void Cumin(int addToScore)
    {
        Score += addToScore;
        Debug.Log("Score: " + Score.ToString());
        ScoreText.text = "Score: " + Score.ToString();
    }
    public void GameOver()
    {
        SuperSexTime = false;
        GameOverText.gameObject.SetActive(true);
        RestartButton.gameObject.SetActive(true);
    }
    public void retard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    IEnumerator SpawnTarget()
    {
        while(SuperSexTime)
        {
            yield return new WaitForSeconds(1);
            int index = Random.Range(0, Target.Count);
            Instantiate(Target[index]);
        }
        
    }
}
