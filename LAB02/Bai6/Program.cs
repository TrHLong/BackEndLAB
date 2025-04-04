//Bài 6: Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.

static void SortArrayAscending(ref double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)  // Vòng lặp ngoài (duyệt qua mảng)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)  // Vòng lặp trong (sắp xếp)
        {
            if (arr[j] > arr[j + 1])  // So sánh 2 phần tử liền kề
            {
                // Hoán vị nếu phần tử trước lớn hơn phần tử sau
                double temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}
