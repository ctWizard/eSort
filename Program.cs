using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Runtime.CompilerServices;

Random rnd = new();


string path = "nums.txt";
string[] numbString = File.ReadAllLines(path);
int length = numbString.Length;
int[] ints = new int[length];
for (int i = 0; i < length; i++)
{
    ints[i] = Convert.ToInt32(numbString[i]);
}


int[] eSort(int[] array,int length){
    //check each value making sure that it is larger then the last, if not verifyes through every previous value
    for (int i=1;i<length;i++){
        int checkedVal = array[i];
        bool endLoop = false;

        for (int previousIndex=i-1;previousIndex>=0 &&endLoop==false;){
            if (checkedVal<array[previousIndex]){
                array[previousIndex+1] = array[previousIndex];
                array[previousIndex]=checkedVal;
                previousIndex--;
            }
            else endLoop=true;
        }
    }
    return array;
}


Console.WriteLine("Insertion sort");
Console.WriteLine("Array length :"+length);
DateTime start1 = DateTime.Now;
Console.WriteLine(start1);
int[] sorted = eSort(ints, length);
DateTime end1 = DateTime.Now;
TimeSpan timeDiff2 = end1 - start1;
Console.WriteLine("Time taken: "+timeDiff2);
foreach(int item in sorted) {
    Console.WriteLine(item);
}

