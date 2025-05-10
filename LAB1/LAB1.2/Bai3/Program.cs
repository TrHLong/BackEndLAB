//Bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập
//từ bàn phím.

static void CountPositiveNegative(int[] arr, out int positiveCount, out int negativeCount)
{
    try
    {
        positiveCount = 0;
        negativeCount = 0;

        foreach (var num in arr)
        {
            if (num > 0)
                positiveCount++;
            else if (num < 0)
                negativeCount++;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Lỗi trong quá trình đếm: {ex.Message}");
        positiveCount = 0;
        negativeCount = 0;
    }
}
