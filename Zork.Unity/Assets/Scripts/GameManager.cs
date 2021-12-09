using System.Collections;
using TMPro;
using UnityEngine;
using Zork;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(zorkGameFileAssetName);

        _game = null;
        _game = Game.Load(gameJsonAsset.text);

        SetMovesText(this, 0); SetScoreText(this, 0);
        _game.Player.MovesChanged += SetMovesText;
        _game.Player.ScoreChanged += SetScoreText;
        _game.IsRunningChanged += ExitApp;
        _game.IsResettingChanged += ResetApp;

        OutputService.WriteLine("Welcome to Zork!");
        _game.Start(OutputService, InputService);
        Game.Look(_game);

        canProcess = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && canProcess)
        {
            InputService.ProcessInput();
            canProcess = false;
            StartCoroutine(ResetCanProcessInput());
        }
    }

    IEnumerator ResetCanProcessInput()
    {
        yield return new WaitForSeconds(.1f);
        canProcess = true;
    }

    void SetMovesText(object sender, int movesCount) => MovesText.text = "Moves: " + movesCount;
    void SetScoreText(object sender, int scoreCount) => ScoreText.text = "Score: " + scoreCount;

    void ExitApp(object sender, bool running)
    {
        if (resetting)
        {
            resetting = false;
            Awake();
            return;
        }
        else if (!running)
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
        }
    }

    void ResetApp(object sender, bool reset) => resetting = reset;

    [SerializeField]
    private string zorkGameFileAssetName = "Zork";
    [SerializeField]
    public UnityOutputService OutputService;
    [SerializeField]
    private UnityInputService InputService;
    [SerializeField]
    private TMP_Text MovesText;
    [SerializeField]
    private TMP_Text ScoreText;

    private bool canProcess;
    private bool resetting;
    public Game _game;
}
