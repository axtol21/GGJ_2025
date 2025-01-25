using UnityEngine;

public class GameBounds : MonoBehaviour
{
    public static Rect Bounds {get; private set;}

    [SerializeField] private Camera mainCamera;

    void Awake()
    {
        var lowerLeft = mainCamera.ScreenToWorldPoint(new Vector3(0, 0, 0));
        var upperRight = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        Bounds = new Rect(lowerLeft, upperRight - lowerLeft);
    }

    public static Vector3 GetRandomPointInBounds(float edgeBuffer = 0)
    {
        var xMin = Bounds.xMin + edgeBuffer;
        var xMax = Bounds.xMax - edgeBuffer;
        var yMin = Bounds.yMin - edgeBuffer;
        var yMax = Bounds.yMax + edgeBuffer;

        return new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0);
    }
}
