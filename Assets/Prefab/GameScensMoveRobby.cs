using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScensMoveRobby : MonoBehaviour
{

    public void GameScenesCtrl()
    {
        SceneManager.LoadScene("Robby"); // 어떤 씬 이름으로 이동 할건지 
    }
}

