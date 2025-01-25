using UnityEngine;
using UnityEngine.UI;

public class PlayerHPBar : MonoBehaviour
{
    [SerializeField] private RawImage hpBarImage;
    [SerializeField] private float barWidth;

#if UNITY_EDITOR
    [SerializeField] [Range(0, 1)] private float testPercent;
#endif

    void Update()
    {
        var percent = 0f;

        if (Player.Instance != null)
        {
            percent = Player.Instance.HpPercent;
        }

        SetBarPercent(percent);
    }

    private void OnValidate()
    {
        hpBarImage = GetComponent<RawImage>();
        barWidth = ((RectTransform)transform).rect.width;

        SetBarPercent(testPercent);
    }

    private void SetBarPercent(float percent)
    {
        transform.localScale = new Vector3(percent, 1, 1);
        hpBarImage.uvRect = new Rect(0, 0, barWidth / 14 * percent, 1);
    }
}
