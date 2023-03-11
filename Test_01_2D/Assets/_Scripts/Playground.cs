using UnityEngine;
using Random = UnityEngine.Random;

public class Playground : MonoBehaviour
{
    [SerializeField] private Shape[] shapes;

    [SerializeField] private RectTransform boardRect;

    private Vector2 _bottomLeft;

    private Vector2 _topRight;

    private void Start()
    {
        DisplayWorldCorners();
    }

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;

        InstantiateChip();
    }

    private void InstantiateChip()
    {
        Vector2 pos = GetRandomPosition();

        int shapeIndex = Random.Range(0, shapes.Length);

        Instantiate(shapes[shapeIndex], pos, Quaternion.identity);
    }

    private Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(_bottomLeft.x, _topRight.x);
        float randomY = Random.Range(_bottomLeft.y, _topRight.y);

        return new Vector2(randomX, randomY);
    }

    private void DisplayWorldCorners()
    {
        var corners = new Vector3[4];
        boardRect.GetWorldCorners(corners);

        _bottomLeft = corners[0];
        _bottomLeft = corners[2];
    }
}