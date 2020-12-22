using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private CanvasGroup _canvas;

    private void OnEnable()
    {
        _player.EndGame += OnEndGame;
    }

    private void OnDisable()
    {
        _player.EndGame -= OnEndGame;
    }

    private void OnEndGame()
    {
        Time.timeScale = 0;
        _canvas.alpha = 1;
    }
}
