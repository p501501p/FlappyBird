using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
    public LogicScript logicScript; 
    public int playerScore;
    public Text scoreText;
    public float globalPipeSpeed = 0f;
    public GameObject gameOverScreen; 
    public float lastSpeedScore = 0;

    public bool Dead = false;
    
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Dead = false;
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        Dead = true;
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (playerScore >= lastSpeedScore + 3) {
        globalPipeSpeed += 0.3f;
        lastSpeedScore = playerScore;
    }
    }
}