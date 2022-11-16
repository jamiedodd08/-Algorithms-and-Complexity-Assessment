using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Sort
    {
        public static void bubbleSort(int[] a, int n, bool ascend)
        {
            int counter = 0;
            for (int i= 0; i< n-1; i++)
            {
                for (int j = 0; j < n-1-i; j++)
                {
                    counter++;
                    if (ascend)
                    { 
                    if (a[j + 1] < a[j])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                    }
                    else
                    {
                        if (a[j + 1] > a[j])
                        {
                            int temp = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("steps taken: " + counter);
        }

        public static void InsertionSort(int[] data, int n, bool ascend)
        {
            int counter = 0;
            int numSorted = 1;
            int index;
            while (numSorted < n)
            {
                int temp = data[numSorted];
                for (index = numSorted; index > 0; index--)
                {
                    counter++;
                    if (ascend)
                    {
                        if (temp < data[index - 1])
                        {
                            data[index] = data[index - 1];
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (temp > data[index - 1])
                        {
                            data[index] = data[index - 1];
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                data[index] = temp;
                numSorted++;
            }
            Console.WriteLine("steps taken: " + counter);
        }

        public static void Merge (int[] data, int[] temp, int low, int middle, int high, bool ascend)
        {
            int ri = low;
            int ti = low;
            int di = middle;
            
            while (ti < middle && di <= high)
            {
                if (ascend)
                {
                    if (data[di] < temp[ti])
                    {
                        data[ri++] = data[di++];
                    }
                    else
                    {
                        data[ri++] = temp[ti++];
                    }
                }
                else
                {
                    if (data[di] > temp[ti])
                    {
                        data[ri++] = data[di++];
                    }
                    else
                    {
                        data[ri++] = temp[ti++];
                    }
                }
            }
            while (ti < middle)
            {
                data[ri++] = temp[ti++];
            }
        }
        public static void MergeSortRecursive(int[] data, int[] temp, int low, int high, bool ascend)
        {
            int n = high - low + 1;
            int middle = low + n / 2;
            int i;

            if (n < 2) return;

            for (i = low; i < middle; i++)
            {
                temp[i] = data[i];
            }

            MergeSortRecursive(temp, data, low, middle - 1, ascend);
            MergeSortRecursive(data, temp, middle, high, ascend);
            Merge(data, temp, low, middle, high, ascend);
        }

        public static void MergeSort(int[] data, int n, bool ascend)
        {
            int[] temp = new int[n];
            MergeSortRecursive(data, temp, 0, n - 1, ascend);
        }

        public static void QuickSort(int[] data, bool ascend)
        {
            int counter = Quick_Sort(data, 0, data.Length - 1, ascend);
            Console.WriteLine("steps taken: " + counter);
        }

        public static int Quick_Sort(int[] data, int left, int right, bool ascend)
        {
            int counter = 0;
            int i, j;
            int pivot, temp;

            i = left;
            j = right;
            pivot = data[(left + right) / 2];

            do
            {
                if (ascend)
                {
                    //Change > to < for Ascending
                    while ((data[i] < pivot) && (i < right)) i++;
                    while ((pivot < data[j]) && (j > left)) j--;

                }
                else
                {
                    while ((data[i] > pivot) && (i < right)) i++;
                    while ((pivot > data[j]) && (j > left)) j--;
                }

                if (i <= j)
                {

                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                    counter++;
                }
            }
            while (i <= j);
            if (left < j) counter += Quick_Sort(data, left, j, ascend);
            if (i < right) counter += Quick_Sort(data, i, right, ascend);
            return counter;
        }

        public static void HeapSort(int[] Heap, bool ascend)
        {
            int HeapSize = Heap.Length;
            int i;

            for (i = (HeapSize - 1) / 2; i >= 0; i--)
            {
                Max_Heapify(Heap, HeapSize, i, ascend);
            }
            for (i = Heap.Length - 1; i > 0; i--)
            {
                int temp = Heap[i];
                Heap[i] = Heap[0];
                Heap[0] = temp;

                HeapSize--;
                Max_Heapify(Heap, HeapSize, 0, ascend);
            }
        }
        private static void Max_Heapify(int[] Heap, int HeapSize, int Index, bool ascend)
        {
            int Left = (Index + 1) * 2 - 1;
            int Right = (Index + 1) * 2;
            int largest = 0;

            //change < to > for ascending
            if (ascend)
            {
                if (Left < HeapSize && Heap[Left] > Heap[Index])
                {
                    largest = Left;
                }
                else
                {
                    largest = Index;
                }
            }
            else
            {
                if (Left < HeapSize && Heap[Left] < Heap[Index])
                {
                    largest = Left;
                }
                else
                {
                    largest = Index;
                }
            }

            //change < to > for ascending
            if (ascend)
            {
                if (Right < HeapSize && Heap[Right] > Heap[largest])
                {
                    largest = Right;
                }
            }
            else
            {
                if (Right < HeapSize && Heap[Right] < Heap[largest])
                {
                    largest = Right;
                }
            }

            if (largest != Index)
            {
                int temp = Heap[Index];
                Heap[Index] = Heap[largest];
                Heap[largest] = temp;
                Max_Heapify(Heap, HeapSize, largest, ascend);
            }
        }
    }


}

