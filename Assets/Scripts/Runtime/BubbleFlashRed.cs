using UnityEngine;

public class BubbleFlashRed : MonoBehaviour
{
    [SerializeField] private AnimationCurve colorCurve;
    [SerializeField] private Gradient colorGradient;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private float startTime;
    private float speed;

    void Start()
    {
        speed = 1;
        startTime = Time.time;
    }

    void Update()
    {
        var t = speed * (Time.time - startTime);
        spriteRenderer.color = colorGradient.Evaluate(colorCurve.Evaluate(t));
        speed = Mathf.Min(3, speed + Time.deltaTime);
    }

    private void OnValidate()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
