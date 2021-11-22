using System;
using Zork.Common;
using UnityEngine;
using TMPro;

public class UnityInputService : MonoBehaviour, IInputService 
{
    public event EventHandler<string> InputReceived;

    void Awake() => InputField.ActivateInputField();

    public void ProcessInput()
    {
        string inputString = InputField.text;
        if (InputField.text != string.Empty)
        {
            gameManager.OutputService.WriteLine("> " + inputString);
            InputReceived?.Invoke(this, inputString);
        }
        InputField.text = string.Empty;
        InputField.ActivateInputField();
    }

    [SerializeField]
    private TMP_InputField InputField;
    [SerializeField]
    private GameManager gameManager;
}
