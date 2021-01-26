using UnityEngine;

public class EndGameTrigger : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private CanvasGroup _canvas;

    private void OnEnable()
    {
        _player.AllEnemiesKilled += Gameover;
    }

    private void OnDisable()
    {
        _player.AllEnemiesKilled -= Gameover;
    }

    private void Gameover()
    {
        Time.timeScale = 0;
        _canvas.alpha = 1;
    }
}