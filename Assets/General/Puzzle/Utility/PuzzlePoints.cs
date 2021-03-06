﻿using System;
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
    [RequireComponent(typeof(Puzzle))]
	public class PuzzlePoints : MonoBehaviour
	{
        public int value;

        void Start()
        {
            GetComponent<Puzzle>().OnSolved += OnSolved;
        }

        void OnSolved()
        {
            Level.Instance.Points += value;

            GetComponent<Puzzle>().OnSolved -= OnSolved;
        }
    }
}