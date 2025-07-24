using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptingProblems : MonoBehaviour
{
	public TMPro.TMP_Text premiseText;
	public TMPro.TMP_Text resultText;
    

    private void Start()
	{
		//SwapNumbers();
		//FindHighestNumber();
		//IncreaseAge();
		MovePosition();
	}

	public void SwapNumbers()
	{
		premiseText.text = "Swapping numbers: 5 and 3";
		int firstNumber = 5;
		int secondNumber = 3;
        int firstTransfer;

        firstTransfer = firstNumber;
		firstNumber = secondNumber;
		secondNumber = firstTransfer;
		resultText.text = "First number["+firstNumber.ToString()+"], Second number["+secondNumber.ToString()+"]";
	}

	public void FindHighestNumber()
	{
		premiseText.text = "Finding the highest number out of 4, 3, 5, 1, 12, 6, 2";
		List<int> numbers = new List<int>() { 4, 3, 5, 1, 12, 6, 2 };
		int highestNumber = 0;
		for (int i = 0; i < numbers.Count; i++)
		{
            Debug.Log(numbers[i]);
            if (numbers[i] > highestNumber)
			{
				highestNumber = numbers[i];
				Debug.Log("Current highest number is " + highestNumber.ToString());
			}
		}
		resultText.text = "Highest number["+highestNumber.ToString()+"]";
	}

	class Person
	{
		public int age;
		public string name;

		public Person(int inAge, string inName)
		{
			age = inAge;
			name = inName;
		}
	}

	public void IncreaseAge()
	{
		Person alice = new Person(32, "Alice");
		Person thomas = new Person(24, "Thomas");

		int ageIncrease = 3;
		premiseText.text = "Increasing age of Alice and Thomas";
		thomas.age += ageIncrease;
        alice.age += ageIncrease;
        //Debug.Log(ageIncrease);
        Debug.Log(alice.age);
        Debug.Log(thomas.age);
        resultText.text = "Alice is now "+alice.age.ToString()+" years old and Thomas is now "+thomas.age.ToString()+" years old.";
	}

	public void MovePosition()
	{
		Vector3 currentPosition = new Vector3(1.5f, 2.5f, 3.5f);
		Debug.Log(currentPosition);
		premiseText.text = "Moving the position " + currentPosition.ToString();
		float shiftedX = 3;
		currentPosition.x += shiftedX;
        Debug.Log(currentPosition);
        resultText.text = "Position is now " + currentPosition.ToString();
	}

}
