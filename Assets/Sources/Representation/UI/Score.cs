using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreDisplay;

    public int RewardScore { get; private set; }

    private int _currentRewardScore;

    public event UnityAction<int> RewardScoreChanged;

    private void Update()
    {
        CorrectionCurrentRewardScore();
    }

    public void AddRewardScore(int transferRewardScore)
    {
        RewardScore += transferRewardScore;
        RewardScoreChanged?.Invoke(RewardScore);
    }

    private void CorrectionCurrentRewardScore()
    {
        if (_currentRewardScore != RewardScore)
        {
            _currentRewardScore = RewardScore;

            SetDisplayScore();
        }
    }

    private void SetDisplayScore()
    {
        _scoreDisplay.text = _currentRewardScore.ToString();
    }
}
