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
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(AudioSource))]
    public class PuzzleScreen : MonoBehaviour
	{
        public Text number1;
        public Text number2;
        public InputField solution;

        public Button confirm;
        public Button tutorial;

        Puzzle puzzle;

        Animator animator;

        AudioSource audioSource;
        public AudioClip correctSFX;
        public AudioClip wrongSFX;

        void Start()
        {
            confirm.onClick.AddListener(ConfirmClick);
            tutorial.onClick.AddListener(TutorialClick);

            solution.contentType = InputField.ContentType.IntegerNumber;

            animator = GetComponent<Animator>();

            audioSource = GetComponent<AudioSource>();
        }

        public void Show(Puzzle puzzle)
        {
            this.puzzle = puzzle;

            gameObject.SetActive(true);

            number1.text = puzzle.number1.ToString();
            number2.text = puzzle.number2.ToString();

            tutorial.gameObject.SetActive(false);
        }

        void ConfirmClick()
        {
            var answer = int.Parse(solution.text);

            if(answer == puzzle.Solution)
            {
                animator.SetTrigger("Correct");
                audioSource.PlayOneShot(correctSFX);
            }
            else
            {
                animator.SetTrigger("Wrong");
                audioSource.PlayOneShot(wrongSFX);
            }
        }

        void TutorialClick()
        {

        }

        public void Complete()
        {
            gameObject.SetActive(false);

            puzzle.Solved = true;
            puzzle = null;
        }
    }
}