using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    private TextMeshProUGUI textScore;
    private int Score;
    void Awake()
    {
        textScore = GetComponent<TextMeshProUGUI>();
        textScore.text = "score = 0";
    }

    void OnEnable()
    {
        Coin.OnPickup += ScoreAdded;
    }

    void OnDisable()
    {
        Coin.OnPickup -= ScoreAdded;
    }

    private void ScoreAdded(int points)
    {
        Score += points;
        textScore.text = $"score = {Score}";
    }
}
