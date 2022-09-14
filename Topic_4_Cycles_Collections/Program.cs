// 5.
int[] numArray = new int[10];
int[] numArray2 = new int[10];

Random random = new Random();

for (int i = 0; i < numArray.Length; i++) 
{
    numArray[i] = random.Next(1, 100);
    numArray2[i] = random.Next(1, 100);
}

int[] concatedArray = new int[numArray.Length + numArray2.Length];

numArray.CopyTo(concatedArray, 0);
numArray2.CopyTo(concatedArray, numArray.Length);

foreach (int item in concatedArray)
{
    Console.WriteLine(item);
}

for (int i = 0; i < concatedArray.Length; i++)
{
    for (int j = i + 1; j < concatedArray.Length; j++)
    {
        if (concatedArray[i] > concatedArray[j]) 
        {
            int temp = concatedArray[i];
            concatedArray[i] = concatedArray[j];
            concatedArray[j] = temp;
        }
    }
}

foreach (int item in concatedArray)
{
    Console.WriteLine(item);
}

//List<T>
List<string> stringList = new List<string>();
var stringLists = new List<List<string>>();
var intList = new List<int>();
List<bool> boolList = new List<bool>();

List<object> objectList = new List<object>();

stringList.Add("stringas");
intList.Add(1);

objectList.Add(1);
objectList.Add(true);
objectList.Add("stringas");
//intList.Add("stringas"); => not valid






