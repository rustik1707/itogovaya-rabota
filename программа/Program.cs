string[]startarray = {"one", "orange","two", "ok"};  


string[]Newarray(string[]array)
{
    int count = 0;
    string[]newarray= new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[count] = array[i];
            count = count+1;
        }   
    }
    return newarray;
}

void Printarray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    
    Console.WriteLine();

}
string[]newarray = Newarray(startarray);
Printarray(newarray);