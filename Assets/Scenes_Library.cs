using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes_Library : MonoBehaviour
{
    // Start is called before the first frame update
    public void GameScenesCtrl()
    {
        SceneManager.LoadScene("Linside"); // 어떤 씬 이름으로 이동 할건지 
    }
}
