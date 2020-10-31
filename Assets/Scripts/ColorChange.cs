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

    public void ChangeColor()
    {
        _spriteRenderer.color = GameColor.GetRandomColor();
    }
}
