using UnityEngine;

public class EndGameTrigger : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private CanvasGroup _canvas;

    private void OnEnable()
    {
        _player.AllEnemiesKilled += OnAllEnemiesKilled;
    }

    private void OnDisable()
    {
        _player.AllEnemiesKilled -= OnAllEnemiesKilled;
    }

    private void OnAllEnemiesKilled()
    {
        Time.timeScale = 0;
        _canvas.alpha = 1;
    }
}