using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField playerNameInputField;
    [SerializeField] private Button startGameButton;

    private void OnEnable()
    {
        startGameButton.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        GameManager.Instance.playerName = playerNameInputField.text;
        SceneManager.LoadSceneAsync("main");
    }
}