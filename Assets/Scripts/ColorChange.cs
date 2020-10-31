using UnityEngine;
using Utils;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorChange : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public Color ChangeColor()
    {
        Color col = GameColor.GetRandomColor();
        _spriteRenderer.color = col;
        return col;
    }

    public Color ToggleColor(Color currentColor)
    {
        Color col = GameColor.GetNextColor(currentColor);
        _spriteRenderer.color = col;
        return col;
    }
}
