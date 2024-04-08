namespace AdvanceAsignment.Monsters
{
    public interface IMonster
    {
        
        int Hitpoints { get; set; }
        string Name { get; set; }
        int X { get; set; }
        int Y { get; set; }

        void DoDamage(Monster enemy);
        void ReceiveDamage(int dmg);
    }
}
