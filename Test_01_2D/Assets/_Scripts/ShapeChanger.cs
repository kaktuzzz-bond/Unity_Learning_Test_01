using UnityEngine;
using Random = UnityEngine.Random;

public class ShapeChanger : Shape
{
    [SerializeField]
    private Sprite[] sprites;

    private SpriteRenderer _sr;

    private void Awake()
    {
        _sr = GetComponentInChildren<SpriteRenderer>();
    }

    protected override void ChangeAppearance()
    {
        int index = Random.Range(0, sprites.Length);

        _sr.sprite = sprites[index];
    }
}