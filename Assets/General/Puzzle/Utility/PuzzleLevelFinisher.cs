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
	public class PuzzleLevelFinisher : MonoBehaviour
	{
        public GameObject[] enables;
        public GameObject[] disables;

        void Start()
        {
            GetComponent<Puzzle>().OnSolved += OnSolved;
        }

        void OnSolved()
        {
            for (int i = 0; i < disables.Length; i++)
                disables[i].SetActive(false);

            for (int i = 0; i < enables.Length; i++)
                enables[i].SetActive(true);
        }
    }
}