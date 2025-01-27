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

        var moneyStr = money.ToString();
        text.text = $"<cspace=-0.5em><voffset=0.275em><sprite=\"1bit 16px icons part-2\" index=81></voffset>{moneyStr[0]}</cspace>{moneyStr[1..]}";
    }

#if UNITY_EDITOR
    private void OnValidate()
    {
        text = GetComponent<TextMeshProUGUI>();

        var moneyStr = testAmount.ToString();
        text.text = $"<cspace=-0.5em><voffset=0.275em><sprite=\"1bit 16px icons part-2\" index=81></voffset>{moneyStr[0]}</cspace>{moneyStr[1..]}";
    }
#endif
}
