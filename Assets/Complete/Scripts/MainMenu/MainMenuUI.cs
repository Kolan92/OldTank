using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Net.Mime;
using Complete;
using UnityEngine.SceneManagement;

namespace CompilerGenerated {
    public class MainMenuUI : MonoBehaviour {

        [SerializeField]
        private Text _redScore;

        [SerializeField]
        private Text _blueScore;

        private void Start() {
            _redScore.text = GameController.InstanceGameController.GameData.LastScore[0].ToString();
            _blueScore.text = GameController.InstanceGameController.GameData.LastScore[1].ToString();
        }
        public void StartGame() {
            GameController.StartGame();
        }

        public void EndGame() {
            GameController.EndGame();
        }
    }
}