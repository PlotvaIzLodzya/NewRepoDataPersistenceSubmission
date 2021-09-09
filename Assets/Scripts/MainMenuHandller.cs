using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuHandller : MonoBehaviour
{
    public string _playerName;
    [SerializeField] TMP_InputField _playerNameInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        DataPersistence.Instance.playerName = _playerNameInput.text;
        Debug.Log(DataPersistence.Instance.playerName);
        SceneManager.LoadScene(1);
    }
}
