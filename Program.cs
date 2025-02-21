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


int[] SortInsertion(int[] array,int length){
    for (int i=1;i<length;i++){
        var key = array[i];
        var flag =0;

        for (int j =i-1; j>=0 && flag!=1;)
        {
            if (key<array[j]){
                array[j+1] = array[j];
                j--;
                array[j+1]=key;
            }
            else flag =1;
            
        }
    }
    return array;
}

Console.WriteLine("Insertion sort");
DateTime start1 = DateTime.Now;
Console.WriteLine(start1);
int[] sorted = SortInsertion(ints, length);
DateTime end1 = DateTime.Now;
TimeSpan timeDiff2 = end1 - start1;
Console.WriteLine("Time taken: "+timeDiff2);
foreach(int item in sorted) {
    Console.WriteLine(item);
}

