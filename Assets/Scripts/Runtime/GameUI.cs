using UnityEngine;

public class GameUI : MonoBehaviour
{
    public static GameUI Instance;

    [SerializeField] private GameObject StartScreen;
    [SerializeField] private GameObject GameScreen;
    [SerializeField] private GameObject ShopScreen;
    [SerializeField] private GameObject GameOverScreen;

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
        StartScreen.SetActive(false);
        GameScreen.SetActive(true);

        LevelManager.StartLevel();
    }

    public void ExitShop()
    {
        ShopScreen.SetActive(false);
        GameScreen.SetActive(true);

        LevelManager.StartLevel();
    }

    public void RerollShop()
    {

    }

    public void EnterShop()
    {
        GameScreen.SetActive(false);
        ShopScreen.SetActive(true);
    }
}
