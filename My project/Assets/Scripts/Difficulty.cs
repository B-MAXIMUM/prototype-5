using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    private Button _button;
    public int Dickculty;
    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.Find("Gay Manager").GetComponent<GameManager>();
        _button = GetComponent<Button>();
        _button.onClick.AddListener(SetDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetDifficulty()
    {
        //Debug.Log(gameObject.name + "was clicked"  );
        _gameManager.startGame(Dickculty);
    }
}
