using UnityEngine;
using UnityEngine.Events;

public class DetectClick : MonoBehaviour
{
    public UnityEvent onClick;

    void OnMouseDown()
    {
        onClick.Invoke();
    }
}
