using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes_Ai : MonoBehaviour
{
    // Start is called before the first frame update
    public void GameScenesCtrl()
    {
        SceneManager.LoadScene("Ai"); // 어떤 씬 이름으로 이동 할건지 
    }
}
