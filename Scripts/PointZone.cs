using UnityEngine;
using UnityEngine.UI;

public class PointZone : MonoBehaviour
{
    private int _playerOneScore;
    private int _playerTwoScore;

    public Text playerOneText; 
    public Text playerTwoText;
    public SceneChanger sceneChanger;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.CompareTag("RPointZone"))
        {
            _playerOneScore++;
            UpdateScoreLabel(playerOneText, _playerOneScore);
        }
        else if (gameObject.CompareTag("LPointZone"))
        {
            _playerTwoScore++;
            UpdateScoreLabel(playerTwoText, _playerTwoScore);
        }

        other.GetComponent<BallBehaviour>().gameStarted = false;
        CheckScore();
        GetComponent<AudioSource>().Play();
    }

    private void UpdateScoreLabel(Text label, int score)
    {
        label.text = score.ToString();
    }

    private void CheckScore()
    {
        if (_playerOneScore >= 3)
        {
            sceneChanger.ChangeSceneTo("WinScene");
        } else if (_playerTwoScore >= 3)
        {
            sceneChanger.ChangeSceneTo("LoseScene");
        }
    }
}
