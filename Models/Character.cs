namespace dotnetcore_App.Models
{
    public class Character
    {
        public int id { get; set; } = 0;
        
        public string name { get; set; } = "Frodo";

        public int hitPoints { get; set; } = 100;

        public int strength { get; set; } = 10;

        public int defense { get; set; } = 10;

        public int intelligence { get; set; } = 10;

        public RpgClass role { get; set; } = RpgClass.Knigth;
    }
}