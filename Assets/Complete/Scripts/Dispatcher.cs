using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Complete {
    public static class Dispatcher {
        public delegate void MyEvent(object o);
        public static IDictionary<string, MyEvent> Map = new Dictionary<string, MyEvent>();

        public static void AddListener(string eventName, MyEvent funct) {
            if (Map.ContainsKey(eventName))
                Map[eventName] += funct;
            else {
                Map.Add(eventName, funct);
            }
        }

        public static void RemoveListener(string eventName, MyEvent funct) {
            if (Map.ContainsKey(eventName))
                Map[eventName] -= funct;
        }

        public static void Dispatch(string eventName, object o = null) {
            if (Map.ContainsKey(eventName) && Map[eventName] != null)
                Map[eventName](o);
        }
    }
}