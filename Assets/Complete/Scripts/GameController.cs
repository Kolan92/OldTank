using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace Complete {
    public class GameController : MonoBehaviour {
        [HideInInspector]
        public GameData GameData;
        public static GameController InstanceGameController = null;

        private int _playerNumber = 2;

        public void Awake() {
            if (InstanceGameController == null)
                InstanceGameController = this;
            else if (InstanceGameController !=null) {
                Destroy(gameObject);

            }
            DontDestroyOnLoad(gameObject);
            InitGameData();
            Debug.Log(GameData.LastScore[0]);
            Debug.Log(GameData.LastScore[1]);
        }

        public static void StartGame() {
            SceneManager.LoadScene("CompleteMainScene");
        }

        public static void EndGame() {
            Debug.Log("Quit");
        }

        public static void BackToMenu() {
            FileMnager.SaveData("GameData", InstanceGameController.GameData);
            SceneManager.LoadScene("MainMenu");
        }

        private void InitGameData() {
            if (FileMnager.FileExist("GameData")) {
                GameData = FileMnager.LoadData<GameData>("GameData");
            }
            else {
                GameData = new GameData(_playerNumber);
                FileMnager.SaveData("GameData", GameData);
            }
        }
    }
}