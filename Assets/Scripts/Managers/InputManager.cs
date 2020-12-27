using Shanaka.BallBounce.Data;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public ActivePaddle activePaddle;

    private void Update()
    {
#if UNITY_IOS || UNITY_ANDROID
        if (Input.touchCount > 0)
#else
        if (Input.GetMouseButtonUp(0) || Input.GetKeyUp(KeyCode.Return))
#endif
        {
            if (activePaddle.active != null)
            {
                activePaddle.active.ToggleColor();
            }
        }
    }
}