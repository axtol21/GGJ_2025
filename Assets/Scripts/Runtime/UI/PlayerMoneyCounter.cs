using TMPro;
using UnityEngine;

public class PlayerMoneyCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

#if UNITY_EDITOR
    [SerializeField] private float testAmount;
#endif

    private void Update()
    {
        var money = 0f;

        if (Player.Instance != null)
        {
            money = Player.Instance.Money;
        }

        text.text = money.ToString();
    }

    private void OnValidate()
    {
        text = GetComponent<TextMeshProUGUI>();

        text.text = testAmount.ToString();
    }
}
