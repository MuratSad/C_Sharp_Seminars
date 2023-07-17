// 1. Напишите программу, которая перевернёт одномерный массив
//    (последний элемент будет на первом месте, а первый - на последнем и т.д.)

void RevMas(int[] arr)
{
    int size = arr.Length; // 5  11 22 33 44 55

    for (int i = 0; i < size / 2; i++)
        (arr[i], arr[size - i - 1]) = (arr[size - i - 1], arr[i]);
        // arr[0], arr[5 - 0 - 1] = arr[5 - 0 - 1], arr[0]
        // arr[0], arr[4] = arr[4], arr[0]
        // arr[1], arr[3] = arr[3], arr[1]  
}