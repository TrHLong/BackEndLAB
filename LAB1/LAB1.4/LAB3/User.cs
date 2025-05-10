namespace LAB3
{
    public class User
    {
        public string? id { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public string? email { get; set; }
        public string? phone { get; set; }

        public override string ToString()
        {
            return $"{id,-3} | {username,-12} | {email,-25} | {phone}";
        }
    }
}
