using UnityEngine;

public class GameBounds : MonoBehaviour
{
    public static Rect Bounds {get; private set;}

    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject wallPrefab;

    void Awake()
    {
        var lowerLeft = mainCamera.ScreenToWorldPoint(new Vector3(0, 0, 0));
        var upperRight = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        Bounds = new Rect(lowerLeft, upperRight - lowerLeft);

        // Build level walls
        BuildWall(2, Bounds.yMax - Bounds.yMin, Bounds.xMin - 1, 0);
        BuildWall(2, Bounds.yMax - Bounds.yMin, Bounds.xMax + 1, 0);
        BuildWall(Bounds.xMax - Bounds.xMin, 2, 0, Bounds.yMin - 1);
        BuildWall(Bounds.xMax - Bounds.xMin, 2, 0, Bounds.yMax + 1);

    }

    public static Vector3 GetRandomPointInBounds(float edgeBuffer = 0)
    {
        var xMin = Bounds.xMin + edgeBuffer;
        var xMax = Bounds.xMax - edgeBuffer;
        var yMin = Bounds.yMin + edgeBuffer;
        var yMax = Bounds.yMax - edgeBuffer;

        return new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0);
    }

    private void BuildWall(float xScale, float yScale, float xOffset, float yOffset)
    {
        var wall = Instantiate(wallPrefab);
        var wallCollider = wall.GetComponent<BoxCollider2D>();
        wallCollider.size = new Vector2(xScale, yScale);
        wallCollider.offset = new Vector2(xOffset, yOffset);
    }
}
