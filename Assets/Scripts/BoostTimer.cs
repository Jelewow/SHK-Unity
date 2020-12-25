using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class BoostTimer : MonoBehaviour
{
    public event UnityAction TimerEnded;

    public void InvokeTimer(float duration)
    {
        StartCoroutine(WaitToEndBoost(duration));
    }

    private IEnumerator WaitToEndBoost(float duration)
    {
        yield return new WaitForSeconds(duration);
        Debug.Log(duration);
        TimerEnded?.Invoke();
    }
}