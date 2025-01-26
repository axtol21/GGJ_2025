using UnityEngine;

public class GameUI : MonoBehaviour
{
    public static GameUI Instance;

    [SerializeField] private GameObject startScreen;
    [SerializeField] private GameObject gameScreen;
    [SerializeField] private GameObject shopScreen;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject rerollButton;

    [SerializeField] private Shop shop;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }

        Instance = this;
    }

    public void StartGame()
    {
        startScreen.SetActive(false);
        gameScreen.SetActive(true);

        LevelManager.StartLevel();
    }

    public void ExitShop()
    {
        shopScreen.SetActive(false);
        gameScreen.SetActive(true);

        LevelManager.StartLevel();
    }

    public void RerollShop()
    {
        if (Player.Instance.Money >= shop.RerollCost)
        {
            Player.Instance.Money -= shop.RerollCost;
            shop.RerollShop();
        }
    }

    public void EnterShop()
    {
        gameScreen.SetActive(false);

        shop.RerollCost = 0;
        shop.RerollShop();
        shopScreen.SetActive(true);
    }

    public void UnlockRerolls()
    {
        rerollButton.SetActive(true);
    }

    public void RemoveUpgradeFromShopPool(_Upgrade upgrade)
    {
        shop.RemoveUpgradesFromShopPool(upgrade);
    }

    public void GameOver()
    {
        LevelManager.Reset();
        gameScreen.SetActive(false);
        gameOverScreen.SetActive(true);
    }
}
