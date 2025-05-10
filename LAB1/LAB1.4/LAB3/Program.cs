using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace LAB3       
{
    class Program
    {
        // Danh sách User sẽ đổ về
        public static List<User> users = new();

        // HttpClient tái sử dụng
        public static readonly HttpClient client = new();

        public static async Task<List<User>> getUsers()
        {
            try
            {
                string url = "https://681ee391c1c291fa663565a4.mockapi.io/users";
                // Hoặc: "https://681ee391c1c291fa663565a4.mockapi.io/api/users";

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string data = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<User>>(data) ?? new();
            }
            catch (Exception ex)
            {
                throw new Exception($"Can not load the data!\nError: {ex.Message}", ex);
            }
        }

        public static void showUsers()
        {
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Loading...");
            try
            {
                // Chặn thread chính để chờ Task (theo mẫu gốc)
                users = getUsers().Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Load False! {ex.Message}");
                return;
            }

            showUsers();
            Console.WriteLine("Load Success!");
        }
    }
}
