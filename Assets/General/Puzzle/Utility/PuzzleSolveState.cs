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
    [RequireComponent(typeof(Puzzle))]
    [RequireComponent(typeof(Image))]
    public class PuzzleSolveState : MonoBehaviour
	{
        public Color solved = Color.green;
        public Sprite sprite;

		void Start()
        {
            GetComponent<Puzzle>().OnSolved += OnSolved;
        }

        void OnSolved()
        {
            var image = GetComponent<Image>();
            image.color = solved;
            image.sprite = sprite;
        }
    }
}