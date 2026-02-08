using UnityEngine;
using UnityEngine.UI;

public class Panels : MonoBehaviour
{
    [SerializeField] private Button _showButton;
    [SerializeField] private Button _hideButton;
    [SerializeField] private GameObject _panel;

    private void Start()
    {
        _showButton.onClick.AddListener(OnButtonOnClicked);
        _hideButton.onClick.AddListener(OnButtonOffClicked);

        HidePanel();
    }

    private void OnButtonOnClicked()
    {
        ShowPanel();
    }

    private void OnButtonOffClicked()
    {
        HidePanel();
    }

    private void ShowPanel()
    {
        _panel.SetActive(true);
    }

    private void HidePanel()
    {
        _panel.SetActive(false);
    }
}
