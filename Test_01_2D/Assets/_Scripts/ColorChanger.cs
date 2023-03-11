using UnityEngine;

public class ColorChanger : Shape
{
    [SerializeField]
    private Color[] colors;

    private SpriteRenderer _sr;

    private void Awake()
    {
        _sr = GetComponentInChildren<SpriteRenderer>();
    }

    protected override void ChangeAppearance()
    {
        int index = Random.Range(0, colors.Length);

        _sr.color = colors[index];
    }
}