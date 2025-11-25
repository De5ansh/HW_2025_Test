using UnityEngine;
using TMPro;

public class Tile : MonoBehaviour
{
    public TextMeshPro timerText;   // assign in prefab

    private float destroyTime;
    private float timeRemaining;

    void Start()
    {
        float minDestroyTime = GameConfig.I.data.pulpit_data.min_pulpit_destroy_time;
        float maxDestroyTime = GameConfig.I.data.pulpit_data.max_pulpit_destroy_time;

        destroyTime = Random.Range(minDestroyTime, maxDestroyTime);
        timeRemaining = destroyTime;

        // Optional: show full time at start
        UpdateTimerText();
    }

    void Update()
    {
        timeRemaining -= Time.deltaTime;

        if (timeRemaining < 0f)
            timeRemaining = 0f;

        UpdateTimerText();

        if (timeRemaining <= 0f)
        {
            Destroy(gameObject);
        }
    }

    void UpdateTimerText()
    {
        if (timerText == null) return;

        timerText.text = timeRemaining.ToString("0.00");
    }
}
