//Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng.

static int SumEvenNumbers(int[] arr)
{
    try
    {
        int sum = 0;
        foreach (var num in arr)
        {
            if (num % 2 == 0)  // Kiểm tra số chẵn
            {
                sum += num;
            }
        }
        return sum;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Lỗi trong quá trình tính toán: {ex.Message}");
        return 0;  // Nếu có lỗi, trả về 0
    }
}
