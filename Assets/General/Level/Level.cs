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
    [DefaultExecutionOrder(ExecutionOrder)]
	public class Level : MonoBehaviour
	{
        public const int ExecutionOrder = -200;

        public static Level Instance { get; protected set; }

        public PuzzleScreen puzzleScreen;

        protected int _points;
        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                if (value < 0) value = 0;

                _points = value;

                if (OnPointsChanged != null) OnPointsChanged(_points);
            }
        }
        public event Action<int> OnPointsChanged;

        void Awake()
        {
            Instance = this;
        }
	}
}