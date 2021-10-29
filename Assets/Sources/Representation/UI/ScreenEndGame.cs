using UnityEngine;
using TMPro;
using Asteroids.Logic;

public class ScreenEndGame : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Score _score;
    [SerializeField] private GameObject _panelGameOver;
    [SerializeField] private TMP_Text _highScore;

    private Scene _scene;

    private void OnEnable()
    {
        _scene = new Scene();

        _player.PlayerDead += OnPlayerDead;
        _score.RewardScoreChanged += OnRewardScoreChanged;
    }

    private void OnDisable()
    {
        _player.PlayerDead -= OnPlayerDead;
        _score.RewardScoreChanged -= OnRewardScoreChanged;
    }

    public void OnReloadClick()
    {
        _scene.ReloadScene();
    }

    private void OnPlayerDead()
    {
        GameOver();
    }

    private void OnRewardScoreChanged(int rewardScore)
    {
        _highScore.text = $"HighScore: {rewardScore}";
    }

    private void GameOver()
    {
        _panelGameOver.SetActive(true);
    }
}
