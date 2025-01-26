using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopUpgradeSlot : MonoBehaviour
{
    [SerializeField] private _Upgrade upgrade;
    [SerializeField] private TextMeshProUGUI displayName;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private TextMeshProUGUI cost;
    [SerializeField] private Image icon;

    public void BuyUpgrade()
    {
        if (Player.Instance.Money > upgrade.baseCost)
        {
            Debug.Log($"Bought Upgrade: {upgrade.displayName}");

            Player.Instance.Money -= upgrade.baseCost;

            upgrade.OnBuyFromShop();
            Destroy(gameObject);
        }
    }

    private void OnValidate()
    {
        SetUpgrade(upgrade);
    }

    public void SetUpgrade(_Upgrade upgrade)
    {
        this.upgrade = upgrade;
        displayName.text = upgrade.displayName;
        description.text = upgrade.GetDescription();
        var costStr = upgrade.baseCost.ToString();
        cost.text = $"<cspace=-0.5em><voffset=0.275em><sprite=\"1bit 16px icons part-2\" index=81></voffset>{costStr[0]}</cspace>{costStr[1..]}";
    }
}
