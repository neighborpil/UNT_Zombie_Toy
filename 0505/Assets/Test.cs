using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour {
    public static Test Instance;
    //public int Score;
    //public int Diamond;
    //public int Gold;  

	// Use this for initialization
	void Start () {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Scene이 변경되더라도 사라지지 않는다
        }
        else
        {
            if(Instance != this)
                Destroy(gameObject);

        }
        //Instance = this;
        //SceneManager.GetActiveScene // 현재 Scene의 정보를 가져옴
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SceneManager.GetActiveScene().name == "TestScene")
                SceneManager.LoadScene("TestScene2");
            else if (SceneManager.GetActiveScene().name == "TestScene2")
                SceneManager.LoadScene("TestScene");

            //SceneManager.LoadScene("TestScene2");
            //AsyncOperation asyncOperation =  SceneManager.LoadSceneAsync("TestScene2");
            //if (asyncOperation.isDone)
            //{
            //    Debug.Log("Scene is changed to Scene2");
            //}
        }
    }
}
