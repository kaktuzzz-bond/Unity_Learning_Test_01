using UnityEngine;
using Random = UnityEngine.Random;

public class SizeChanger : Shape
{
    [Range(0f, 1f)]
    [SerializeField]
    private float minSizeMultiplier;

    [Range(1f, 2f)]
    [SerializeField]
    private float maxSizeMultiplier;

    private new void Start()
    {
        base.Start();

        float min = minSizeMultiplier;
        float max = maxSizeMultiplier;

        minSizeMultiplier = Mathf.Min(min, max);
        maxSizeMultiplier = Mathf.Max(min, max);
    }

    protected override void ChangeAppearance()
    {
        float newSize = Random.Range(minSizeMultiplier, maxSizeMultiplier);

        transform.localScale = Vector3.one * newSize;
    }
}