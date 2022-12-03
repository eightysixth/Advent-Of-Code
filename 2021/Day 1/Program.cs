// Part A
string[] lines = System.IO.File.ReadAllLines(@".\input.txt");
int lastDepth = -1;
int largerThanPrevious = 0;
for (int i = 0; i < lines.Length; i++){
    if (i == 0){
        lastDepth = int.Parse(lines[i]);
    } else {
        int currentDepth = int.Parse(lines[i]);
        
        if (currentDepth > lastDepth){
            largerThanPrevious += 1;
        }
        lastDepth = currentDepth;
    }
}

Console.WriteLine("Part A Answer: " + largerThanPrevious.ToString()); //1553


int previousWindowSum = int.MaxValue;
int largerWindowThanPrevious = 0;
int windowSize = 3;

for (int i = 0; i < lines.Length; i++){
    int currentWindowSum = 0;
    if (i + windowSize > lines.Length){
        break;
    }
    for (int j = 0; j < windowSize; j++){
        currentWindowSum += int.Parse(lines[i+j]);
    }
    if (currentWindowSum > previousWindowSum){
        largerWindowThanPrevious += 1;
    }
    previousWindowSum = currentWindowSum;
}
Console.WriteLine("Part B Answer: " + largerWindowThanPrevious.ToString()); //1597