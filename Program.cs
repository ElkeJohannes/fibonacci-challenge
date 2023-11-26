﻿// By considering the terms in the Fibonacci sequence whose values do not exceed 
// four million, find the sum of the even-valued terms

int total = 0;
int newValue = 0;
List<int> sequence = new List<int>();

for (int i = 0; ;i++ ) {
    if(i == 0 || i == 1)
        sequence.Add(i);
    else 
    {
        newValue = sequence[i -2] + sequence[i - 1];
        if(newValue > 4000000) break;
        sequence.Add(newValue);
        if(newValue % 2 == 0)
        {
            total += newValue;
        }
    }
}

Console.WriteLine($"total is: {total}");
