using UnityEngine;

public class GameUI : MonoBehaviour
{
    [SerializeField] private GameObject StartScreen;
    [SerializeField] private GameObject GameScreen;
    [SerializeField] private GameObject ShopScreen;
    [SerializeField] private GameObject GameOverScreen;

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
}
