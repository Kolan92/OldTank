using System;
using UnityEngine;
using System.Collections.Generic;

namespace Complete {
    [Serializable]
    public class GameData {
        public IList<int> LastScore;

        public GameData(int numberOfPlayers) {
            LastScore = new List<int>();

            for (int i = 0; i < numberOfPlayers; i++) {
                LastScore.Add(0);
            }
        }
    }
}
