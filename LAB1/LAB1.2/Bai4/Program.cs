//Bài 4: Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên.
static int FindSecondLargest(int[] arr)
{
    try
    {
        if (arr.Length < 2)
        {
            throw new ArgumentException("Mảng phải có ít nhất 2 phần tử.");
        }

        int firstLargest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (var num in arr)
        {
            if (num > firstLargest)
            {
                secondLargest = firstLargest;
                firstLargest = num;
            }
            else if (num > secondLargest && num != firstLargest)
            {
                secondLargest = num;
            }
        }

        if (secondLargest == int.MinValue)
        {
            throw new InvalidOperationException("Không có số lớn thứ hai trong mảng.");
        }

        return secondLargest;
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Lỗi: {ex.Message}");
        return int.MinValue;  // Hoặc có thể chọn giá trị trả về khác nếu cần
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"Lỗi: {ex.Message}");
        return int.MinValue;  // Hoặc có thể chọn giá trị trả về khác nếu cần
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Lỗi không xác định: {ex.Message}");
        return int.MinValue;  // Hoặc có thể chọn giá trị trả về khác nếu cần
    }
}
