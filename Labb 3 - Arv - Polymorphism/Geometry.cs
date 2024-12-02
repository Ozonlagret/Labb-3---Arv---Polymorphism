namespace Labb_3___Arv___Polymorphism
{
    internal class Geometry
    {
        // bidrar polymorfism då Name används flera gånger med olika värden på underklasser
        public string Name { get; set; } = String.Empty;

        // Jag ändrar ToString() metoden att ge tillbaks Name istället för namnet på objektet som kallas.
        // Name ändras i varje form till namnet på respektive
        public override string ToString()
        {
            return Name;
        }

        // Area återanvänds i varje underklass för att ge ut olika
        // värden beroende på vilken area-ekvation som krävs
        public virtual double Area()
        {
            return default;
        }
    }
}
