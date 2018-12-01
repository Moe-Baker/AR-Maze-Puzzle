using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal;
#endif

using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace Game
{
    [RequireComponent(typeof(Text))]
	public class LevelPointsLabel : MonoBehaviour
	{
        Text label;

        public string prefix = "Points: ";

        void Start()
        {
            label = GetComponent<Text>();

            UpdateState();

            Level.Instance.OnPointsChanged += OnPointsChanged;
        }

        void UpdateState()
        {
            label.text = prefix + Level.Instance.Points.ToString();
        }

        void OnPointsChanged(int points)
        {
            UpdateState();
        }
    }
}