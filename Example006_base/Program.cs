int [] arrayWeights = new int [5];
AsignValueWeights(arrayWeights);
PrintArrayWeights(arrayWeights);
System.Console.WriteLine("");
DetermineMaxWeight(arrayWeights);


void AsignValueWeights(int [] arrayWeights)
{
    for(int i = 0; i < arrayWeights.Length; i++)
    {
        arrayWeights[i] = new Random().Next(1,20); 
    }
}
void PrintArrayWeights(int [] arrayWeights)
{
    for(int i = 0; i < arrayWeights.Length; i++)
    {
        System.Console.Write(arrayWeights[i] + " ");
    }
}
void DetermineMaxWeight(int [] arrayWeights)
{
    int max = arrayWeights[0];
    for(int i = 1; i < arrayWeights.Length; i++)
    {
        if(arrayWeights[i] > max)
        {
            max = arrayWeights[i];
        }          
    }
    System.Console.WriteLine(max);
}