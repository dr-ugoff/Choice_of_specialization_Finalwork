string[] array = InputArray();
string[] result = OutputArray(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] OutputArray(string[] input, int n) {
    string[] output = new string[SearchLessThan(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int SearchLessThan(string[] input, int n) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}

string[] InputArray() {
    Console.Write("Введите значения через запятую: ");
    return Console.ReadLine().Split(",");
}