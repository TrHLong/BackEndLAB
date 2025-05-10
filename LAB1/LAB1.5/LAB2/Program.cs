using System;
using System.Text;
using LAB2;
using System.Collections.Generic;
using System.Linq;

namespace LAB2
{
    internal class Program
    {
        // Danh sách sinh viên
        public static List<Student> students = new List<Student>()
        {
            new Student(){studentId="1", studentName="Nguyen Van A", age=20, phone="0333912821",address="Hà Nội"},
            new Student(){studentId="2", studentName="Nguyen Van B", age=20, phone="0333912822",address="Phú Thọ"},
            new Student(){studentId="3", studentName="Nguyen Van C", age=20, phone="0333912823",address="Thái Bình"},
            new Student(){studentId="4", studentName="Nguyen Van D", age=20, phone="0333912824",address="Hưng Yên"},
            new Student(){studentId="5", studentName="Nguyen Van E", age=20, phone="0333912825",address="Hà Nội"},
        };

        // Thêm sinh viên mới
        public static bool AddStudent(Student student)
        {
            try
            {
                if (students.Any(x => x.studentId == student.studentId))
                    throw new Exception("Sinh viên đã tồn tại!");
                students.Add(student);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Sửa thông tin sinh viên
        public static bool EditStudent(Student student)
        {
            var existStudent = students.FirstOrDefault(x => x.studentId == student.studentId);
            if (existStudent != null)
            {
                existStudent.studentName = student.studentName;
                existStudent.age = student.age;
                existStudent.address = student.address;
                existStudent.phone = student.phone;
                return true;
            }
            return false;
        }

        // Xoá sinh viên
        public static bool DeleteStudent(string studentId)
        {
            var student = students.FirstOrDefault(x => x.studentId == studentId);
            if (student != null)
            {
                students.Remove(student);
                return true;
            }
            return false;
        }

        // Hiển thị danh sách sinh viên
        public static void GetStudents()
        {
            Console.WriteLine("ID\tNAME\t\tAGE\tPHONE\t\tADDRESS");
            foreach (var item in students)
            {
                Console.WriteLine($"{item.studentId}\t{item.studentName}\t{item.age}\t{item.phone}\t{item.address}");
            }
        }

        // Hiển thị thông báo
        public static void Alert(bool isSuccess, string action)
        {
            string message = isSuccess ? $"{action} thành công!" : $"{action} thất bại!";
            Console.WriteLine(message);
            Console.WriteLine("Nhấn phím bất kỳ để tiếp tục...");
            Console.ReadKey();
        }

        // Menu chính
        public static void GetMenu()
        {
            int n;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------- Quản lý sinh viên -----------------------");

                GetStudents();

                Console.WriteLine("-----------------------------------------------------------------");

                Console.WriteLine("\t1. Thêm sinh viên");
                Console.WriteLine("\t2. Sửa sinh viên");
                Console.WriteLine("\t3. Xoá sinh viên");
                Console.WriteLine("\t4. Thoát");

                Console.Write("- Mời bạn chọn chức năng (1-4): ");

                while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 4)
                {
                    Console.Write("Chọn lại chức năng từ 1 đến 4: ");
                }

                switch (n)
                {
                    case 1:
                        {
                            Student student = new Student();
                            Console.Write("- Nhập ID: ");
                            student.studentId = Console.ReadLine();
                            Console.Write("- Nhập họ tên: ");
                            student.studentName = Console.ReadLine();
                            Console.Write("- Nhập tuổi: ");
                            student.age = int.Parse(Console.ReadLine());
                            Console.Write("- Nhập địa chỉ: ");
                            student.address = Console.ReadLine();
                            Console.Write("- Nhập số điện thoại: ");
                            student.phone = Console.ReadLine();
                            Alert(AddStudent(student), "Thêm");
                        }
                        break;
                    case 2:
                        {
                            Console.Write("- Nhập ID sinh viên cần sửa: ");
                            string id = Console.ReadLine();
                            var student = students.FirstOrDefault(x => x.studentId == id);
                            if (student != null)
                            {
                                Console.Write("- Nhập họ tên mới: ");
                                student.studentName = Console.ReadLine();
                                Console.Write("- Nhập tuổi mới: ");
                                student.age = int.Parse(Console.ReadLine());
                                Console.Write("- Nhập địa chỉ mới: ");
                                student.address = Console.ReadLine();
                                Console.Write("- Nhập số điện thoại mới: ");
                                student.phone = Console.ReadLine();
                                Alert(EditStudent(student), "Sửa");
                            }
                            else
                            {
                                Console.WriteLine("Không tìm thấy sinh viên!");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.Write("- Nhập ID sinh viên muốn xoá: ");
                            string id = Console.ReadLine();
                            Alert(DeleteStudent(id), "Xoá");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thoát chương trình...");
                        break;
                }
            } while (n != 4);
        }

        // Hàm Main
        static void Main(string[] args)
        {
            //Hỗ trợ tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;
            GetMenu();
        }
    }
}
