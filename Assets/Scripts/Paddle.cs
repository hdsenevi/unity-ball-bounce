using UnityEngine;
using Utils;

[RequireComponent(typeof(ColorChange))]
public class Paddle : MonoBehaviour
{
    private ColorChange _colorChange;
    private Color _currentColor = GameColor.GetDefaultColor();

    // Start is called before the first frame update
    private void Awake()
    {
        InjectDependencies();
    }

    private void InjectDependencies()
    {
        _colorChange = GetComponent<ColorChange>();
        if (_colorChange == null)
        {
            Debug.LogError("ChangeColor component not found on this game object");
        }
    }

    public void ToggleColor()
    {
        _currentColor = _colorChange.ToggleColor(_currentColor);
    }
}
