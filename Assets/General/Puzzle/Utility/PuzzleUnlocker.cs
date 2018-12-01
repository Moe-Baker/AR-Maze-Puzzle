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
	public class PuzzleUnlocker : MonoBehaviour
	{
        public Puzzle target;

        void Reset()
        {
            target = transform.parent.parent.GetChild(transform.parent.GetSiblingIndex() + 1).GetComponentInChildren<Puzzle>();
        }

        void Start()
        {
            GetComponent<Puzzle>().OnSolved += OnSolved;
        }

        void OnSolved()
        {
            target.Interactable = true;
        }
    }
}