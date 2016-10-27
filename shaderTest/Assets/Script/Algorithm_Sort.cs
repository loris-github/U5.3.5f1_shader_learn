using UnityEngine;
using System.Collections;

public class Algorithm_Sort : MonoBehaviour
{

    int[] array = {27, 64, 76, 42, 14, 90, 67, 61, 74, 83, 92, 101};

    void printArray(int[] array) 
    {
        string s = "";
        for (int i = 0;i<array.Length;i++)
        {
            s += string.Format("{0} ", array[i]);
        }
        Debug.Log(s);
    }

	void Start () {
        printArray(array);
        InsertSort(array);
        printArray(array);
	}

    void InsertSort(int[] a) 
    {
        for (int i = 1; i < a.Length - 1; i++) 
        {
            if (a[i-1] > a[i]) 
            {
                int temp = a[i];
                int j = i - 1;
                while (j >= 0 && a[j] > temp)
                {
                    a[j + 1] = a[j] ;
                    j--;
                }
                a[j + 1] = temp;
            }
        }
    }

    void shelllSort(int[] a) 
    {
        
    }

    void HeapSort(int[] a) 
    {
    
    }

    void MergingSort(int[] a) 
    {
    
    
    }

    void quickSort(int[] a, int left, int right) 
    {
        int k = a[0];
        left = 0;
        right = a.Length - 1;

        while (left < right) 
        {
            while (a[left] < k) left++;
            a[left] = k;

            while (a[right] > k) right++;
            a[right] = k;

            


            
        }

    }
}
