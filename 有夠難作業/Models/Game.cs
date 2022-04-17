using Microsoft.AspNetCore.Mvc;

namespace 有夠難作業.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int Lovel{ get; set; }
        public string Name { get; set; }
        public int Atk { get; set; }
        public int Hp { get; set; }
    }
}
