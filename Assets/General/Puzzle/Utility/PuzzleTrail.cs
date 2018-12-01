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
	public class PuzzleTrail : MonoBehaviour
	{
        public Puzzle puzzle;

        void Start()
        {
            gameObject.SetActive(puzzle.Solved);

            puzzle.OnSolved += OnSolved;
        }

        void OnSolved()
        {
            gameObject.SetActive(true);
        }
    }
}