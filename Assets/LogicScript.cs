using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playscore;
    public Text scoretext;
    public Text highScoreText;
    public GameObject Gameover;
    public AudioSource dingSFX;

    void Start()
    {
        if (dingSFX == null)
        {
            dingSFX = GetComponent<AudioSource>();
        }

        if (highScoreText != null)
        {
            LoadHighScore();
        }
    }

    public void AddScore()
    {
        playscore += 1;
        scoretext.text = playscore.ToString();
        dingSFX.Play();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        Gameover.SetActive(true);
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        if (playscore > highScore)
        {
            PlayerPrefs.SetInt("HighScore", playscore);
            PlayerPrefs.Save();
        }
    }

    void LoadHighScore()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + highScore.ToString();
    }

    public void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
        PlayerPrefs.Save();
        if (highScoreText != null)
        {
            highScoreText.text = "High Score: 0";
        }
    }
}
