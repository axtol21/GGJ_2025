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

    public bool GameActive => gameScreen.activeSelf;

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
        AudioManager.Instance.SetRoundMusic();

        startScreen.SetActive(false);
        gameOverScreen.SetActive(false);
        gameScreen.SetActive(true);

        LevelManager.StartLevel();
    }

    public void ExitShop()
    {
        AudioManager.Instance.SetRoundMusic();

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
        AudioManager.Instance.SetShopMusic();

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
        AudioManager.Instance.SetMenuMusic();

        LevelManager.Reset();
        var bubbles = FindObjectsByType<Bubble>(FindObjectsSortMode.None);

        for (int i = bubbles.Length - 1; i >= 0; i--)
        {
            Destroy(bubbles[i].gameObject);
        }

        gameScreen.SetActive(false);
        gameOverScreen.SetActive(true);
    }
}
