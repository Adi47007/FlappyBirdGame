using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text highScoreText;  

    void Start()
    {
        
        int highScore = PlayerPrefs.GetInt("HighScore", 0);

        highScoreText.text = "Highest Score: " + highScore.ToString();
    }
}
