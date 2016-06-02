using UnityEngine;
using System.Collections;

namespace Complete {
    public class PauseManager : MonoBehaviour {
        private bool isPaused;

        private void Awake() {
            isPaused = false;
            Dispatcher.AddListener("Pause", PauseGame);
        }

        private void PauseGame(object o) {
            if (!isPaused) {
                Time.timeScale = 0;
                isPaused = true;
            }
            else {
                Time.timeScale = 1;
                isPaused = false;
            }
        }
    }
}
